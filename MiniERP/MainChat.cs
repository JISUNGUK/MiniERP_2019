using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    public static Hashtable clientList = new Hashtable();
    public static List<ChattingElement> chattingList = new List<ChattingElement>();
    static void Main(string[] args)
    {
        var ipaddr = IPAddress.Parse("192.168.0.8");
        TcpListener serverListener = new TcpListener(ipaddr, 3333);
        serverListener.Start();//서버가 대기하기 시작함
        Console.WriteLine("채팅서버 가동>>>>");
        ChattingElement chattingAll = new ChattingElement();//전체 채팅방
        chattingAll.RoomName = "전체";

        chattingList.Add(chattingAll);//전체 사용자에게 전송되는 방,,,

        for (; ; )
        {
            var chatClientSocket = serverListener.AcceptTcpClient();//접속된 클라이언트 반환
            string clientNickName = null;
            var ns = chatClientSocket.GetStream();
            Byte[] byteFrom = new Byte[chatClientSocket.SendBufferSize];
            ns.Read(byteFrom, 0, chatClientSocket.SendBufferSize);
            int duplicateCount = 0;
            clientNickName = Encoding.UTF8.GetString(byteFrom);
            if (clientList.Count > 0)
            {

                foreach (DictionaryEntry de in clientList)
                {
                    if (de.Key.ToString() == clientNickName)
                    {
                        Unicast("해당 닉네임은 존재합니다 다른 이름으로 사용하세요", clientNickName, true);
                        duplicateCount++;
                    }
                }
            }
            if (duplicateCount == 0)
            {
                int index = clientNickName.IndexOf("\0");
                clientNickName = clientNickName.Remove(index, clientNickName.Length - index);
                clientList.Add(clientNickName, chatClientSocket);//채팅참여자 관리
                Console.WriteLine(clientNickName + "님이 접속했습니다");
                Broadcast(clientNickName + "님 접속했습니다", clientNickName, true);
                //참여자 목록(clientList)을 클라이언트 접속한 클라이언트에 접속

                string roomList = "";
                int count = 0;
                foreach (ChattingElement item in chattingList)
                {

                    if (count != 0)
                        roomList += "," + item.RoomName;
                    else
                        roomList += item.RoomName;
                    count++;
                }
                string memberList = "";
                count = 0;
                foreach (DictionaryEntry v in clientList)
                {

                    if (count != 0)
                        memberList += "," + v.Key;
                    else
                        memberList += v.Key;
                    count++;
                }


                Broadcast("접속 인원:" + memberList + "::", clientNickName, true);
                Broadcast("방 목록:" + roomList + ";;", clientNickName, true);
                ChatClientSocket client = new ChatClientSocket(chatClientSocket, clientNickName, clientList);
            }


        }
    }

    public static string GetMember()
    {
        string peoples = "";
        int count = 0;
        foreach (DictionaryEntry de in clientList)
        {
            if (count != 0)
                peoples += de.Key + ",";
            else
                peoples += de.Key;
            count++;
        }
        return peoples;
    }

    /// <summary>
    /// 현재 서버에 접속된 모든 클라이언트에게 메시지를 전송!!!
    /// </summary>
    /// <param name="msg">브로드 캐스팅 메시지</param>
    /// 
    /// <param name="clientNickName">대화메시지를 보낸 클라이언트 닉네임</param>
    /// <param name="isServerMsg">true:서버 메시지 /false:일반 대화 메시지</param>
    public static void Broadcast(string msg, string clientNickName, bool isServerMsg)
    {
        //throw new NotImplementedException();//지금 구현 부분 아니면 남겨둔다!!

        foreach (DictionaryEntry item in clientList)
        {
            TcpClient tcp = (TcpClient)item.Value;
            NetworkStream ns = tcp.GetStream();
            byte[] bytemsg = new byte[tcp.ReceiveBufferSize];
            if (!isServerMsg)//클라이언트가 보낸 메시지일때
                bytemsg = Encoding.UTF8.GetBytes(clientNickName + "님의 메시지:" + msg);//메시지를 바이트배열로 저장
            else//서버가 보낸  메시지 일때
            {
                string chattingRooms = "";
                foreach (ChattingElement chatting in chattingList)
                    chattingRooms += chatting.RoomName;
                bytemsg = Encoding.UTF8.GetBytes("서버 메시지:" + msg);
            }
            ns.Write(bytemsg, 0, bytemsg.Length);
            ns.Flush();
            Program.chattingList[0].MessageBody += clientNickName + "님의 메시지:" + msg + "\n";
        }
    }
    /// <summary>
    /// 방정보를 입력받아 해당 닉네임의 사용자의 메시지를 전달
    /// </summary>
    /// <param name="msg">전달될 메시지</param>
    /// <param name="chattingElement">해당 메시지가 전달될 방정보</param>
    /// <param name="clientNickName">대화메시지를 보낸 클라이언트 닉네임</param>
    /// <param name="isServerMsg">true:서버 메시지 /false:일반 대화 메시지</param>
    public static void Multicast(string msg, string clientNickName, ChattingElement chattingElement, bool isServerMsg)
    {
        //throw new NotImplementedException();//지금 구현 부분 아니면 남겨둔다!!            
        foreach (DictionaryEntry item in clientList)
        {
            if (chattingElement.NicNames.Contains((string)item.Key))//해당닉네임이 방정보에 추가되어있는 것만 tcp연결하여 메시지를 전송시킴
            {
                TcpClient tcp = (TcpClient)item.Value;
                NetworkStream ns = tcp.GetStream();
                byte[] bytemsg = new byte[tcp.ReceiveBufferSize];
                if (!isServerMsg)//클라이언트가 보낸 메시지일때
                {
                    chattingElement.MessageBody += clientNickName + "님의 메시지:" + msg + "\n";
                    bytemsg = Encoding.UTF8.GetBytes(clientNickName + "님의 메시지:" + msg);//메시지를 바이트배열로 저장
                }
                else//서버가 보낸  메시지 일때
                {
                    int count = 0;

                    bytemsg = Encoding.UTF8.GetBytes("서버 메시지:" + msg + " 현재방 접속 인원:" + chattingElement.NicNames + "::");
                }
                ns.Write(bytemsg, 0, bytemsg.Length);
                ns.Flush();
            }
        }
    }

    public static string GetMember(ChattingElement chattingElement)
    {

        return chattingElement.NicNames;

    }
    public static string GetRoom()
    {
        string rooms = "";
        int count = 0;
        foreach (ChattingElement item in chattingList)
        {
            if (count != 0)
                rooms += "," + item.RoomName;
            else
                rooms += item.RoomName;
        }

        return rooms;
    }

    public static void Unicast(string msg, string clientNickName, bool isServerMsg)
    {
        //throw new NotImplementedException();//지금 구현 부분 아니면 남겨둔다!!

        foreach (DictionaryEntry item in clientList)
        {
            if (item.Key == clientNickName)
            {
                TcpClient tcp = (TcpClient)item.Value;
                NetworkStream ns = tcp.GetStream();
                byte[] bytemsg = new byte[tcp.ReceiveBufferSize];
                if (!isServerMsg)//클라이언트가 보낸 메시지일때
                    bytemsg = Encoding.UTF8.GetBytes(clientNickName + "님의 메시지:" + msg);//메시지를 바이트배열로 저장
                else//서버가 보낸  메시지 일때
                {
                    string chattingRooms = "";
                    foreach (ChattingElement chatting in chattingList)
                        chattingRooms += chatting.RoomName;
                    bytemsg = Encoding.UTF8.GetBytes("서버 메시지:" + msg + " 현재 접속인원:" + GetMember());
                }
                ns.Write(bytemsg, 0, bytemsg.Length);

                ns.Flush();
                break;
            }
        }
    }
}
