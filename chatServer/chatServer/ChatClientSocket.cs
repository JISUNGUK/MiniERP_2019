using System;
using System.Collections;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace chatServer
{
    /// <summary>
    /// 채팅 참여자 각각이 메시지를 서버측에 보내는 메시지를 읽는 스레드를 위한 클래스
    /// </summary>
    internal class ChatClientSocket
    {
        private TcpClient chatClientSockets;
        private string clientNickName;
        private Hashtable clientList;

        public ChatClientSocket(TcpClient chatClientSocket, string clientNickName, Hashtable clientList)
        {
            this.ChatClientSockets = chatClientSocket;
            this.ClientNickName = clientNickName;
            this.ClientList = clientList;
            Thread thread = new Thread(Doread);
            thread.Start();

        }

        public TcpClient ChatClientSockets { get => chatClientSockets; set => chatClientSockets = value; }
        public string ClientNickName { get => clientNickName; set => clientNickName = value; }
        public Hashtable ClientList { get => clientList; set => clientList = value; }

        private void Doread()
        {
            while(true)
            {
                Byte[] messageByte=null;
                try
                {
                    if(ChatClientSockets.Connected)
                     { 
                    NetworkStream ns = ChatClientSockets.GetStream();
                    messageByte = new Byte[ChatClientSockets.ReceiveBufferSize];
                    if(messageByte!=null)
                        ns.Read(messageByte, 0, ChatClientSockets.ReceiveBufferSize);
                    }
                }
                catch (Exception ee)
                {

                    
                }
               if(messageByte!=null)
                {
               string receivestr= Encoding.UTF8.GetString(messageByte).Replace("\0","");
               
                if(receivestr.Contains("$$$$"))//전체에게 전송되는 메시지
                { 
               int letterlastIndex= receivestr.IndexOf("$$$$");
                receivestr = receivestr.Substring(0, letterlastIndex);
                if(receivestr.Contains(""))
                        {
                            Program.chattingList[0].MessageBody += ClientNickName + "님의 메시지:" + receivestr+"\n";
                    Program.Broadcast(receivestr, ClientNickName, false);
                        }

                    }
                if(receivestr.Contains("방에 메시지를 보냅니다"))
                {
                    int index = receivestr.IndexOf("방에 메시지를 보냅니다");
                    string roomname = receivestr.Substring(0, index);
                    string message = receivestr.Remove(0, 12 + index).Replace("//", "");
                    foreach (ChattingElement item in Program.chattingList)
                    {
                        if (item.RoomName == roomname)
                        {
                           item.MessageBody += Environment.NewLine + message;
                            if (item.NicNames != "")
                                item.NicNames += "," + ClientNickName;
                            else
                                item.NicNames += ClientNickName;
                            Program.Multicast(message, ClientNickName, item, false);
                            Console.WriteLine(ClientNickName + "의 메시지:" + message);
                        }
                    }
                }
               
                if (receivestr.Contains("방에 참가했습니다"))
                {
                    int index = receivestr.IndexOf("방에 참가했습니다");
                    string roomname = receivestr.Remove(index);
                    foreach (ChattingElement item in Program.chattingList)
                    {
                        if (item.RoomName == roomname)
                        {
                            if(item.NicNames!="")
                                item.NicNames += ","+ClientNickName;                                
                            else
                                item.NicNames +=ClientNickName;
                            Program.Multicast(roomname + "에 참가했습니다", ClientNickName, item, true);
                            Console.WriteLine(ClientNickName+"님이 방에 참여 했습니다"+roomname);
                        }
                    }
                    
                }               
                if(receivestr.Contains("방을 만듭니다 방명:"))
                {
                    int index = receivestr.IndexOf("방을 만듭니다 방명:");
                        int lastIndex = receivestr.IndexOf("인원:");
                    int duplicateCount = 0;
                        string nicknames = receivestr.Substring(lastIndex+3).Replace("//", "");//방참가자들
                        string roomname = receivestr.Remove(lastIndex);//인원:문자가 나오는 이후의 문자들을 모두 제거
                        roomname = roomname.Substring(11);
                    for(int i=0;i<Program.chattingList.Count;i++)
                    {
                        if(Program.chattingList[i].RoomName==roomname)
                        {
                            Program.Unicast("해당 방은 있습니다", this, true);
                            Console.WriteLine("해당 방은 있습니다");
                            duplicateCount++;
                            break;
                        }
                    }
                    if(duplicateCount==0)
                    {
                        ChattingElement chatting = new ChattingElement();
                        string rooms="";
                        chatting.RoomName = roomname;
                        chatting.MessageBody = "";
                        chatting.RoomOwner = ClientNickName;
                        chatting.NicNames += nicknames;
                        Program.chattingList.Add(chatting);
                        int count = 0;
                        foreach(var v in Program.chattingList)
                        {
                            if (count != 0)
                                rooms += "," + v.RoomName;
                            else
                                rooms += v.RoomName;
                            Console.WriteLine("방명:"+v.RoomName);
                            Console.Write("참가자들:"+v.NicNames);
                            count++;
                        }
                        Console.WriteLine();
                        Program.Broadcast("방 목록:" + rooms + ";;", ClientNickName, true);
                    }

                }
                if(receivestr.Contains("접속종료합니다"))
                {                                                                                                                             
                            Program.clientList.Remove(ClientNickName);
                        string members = "";
                        for(int i=0;i< Program.chattingList.Count;i++)
                        {
                            if(Program.chattingList[i].NicNames.Contains(ClientNickName))
                            {
                                Program.chattingList[i].NicNames.Replace(ClientNickName, "");
                                if (Program.chattingList[i].NicNames.Contains(",,"))
                                    Program.chattingList[i].NicNames.Replace(",,", ",");
                                if (Program.chattingList[i].NicNames.IndexOf(",") == 1)
                                    Program.chattingList[i].NicNames.Substring(1);
                                if (Program.chattingList[i].NicNames.IndexOf(",") == Program.chattingList[i].NicNames.Length - 1)
                                    Program.chattingList[i].NicNames=Program.chattingList[i].NicNames.Remove(Program.chattingList[i].NicNames.Length - 1);
                            }
                        }
                        members = Program.GetMember();
                        Console.WriteLine(ClientNickName+"님이 접속 종료했습니다");
                        Program.Broadcast("접속 인원:" + members + "::", ClientNickName, true);
                    }
                if(receivestr.Contains("방을 삭제합니다"))
                    {
                        int lastIndex = receivestr.IndexOf("방을 삭제합니다");
                        string roomName = receivestr.Remove(lastIndex);
                        string roomList = "";
                        
                        for (int i = 0; i < Program.chattingList.Count; i++)
                        {
                       
                            if (Program.chattingList[i].RoomName==roomName)
                            {
                                Program.chattingList.RemoveAt(i);
                                continue;
                            }
                            if(roomList!="")
                                roomList += ","+Program.chattingList[i].RoomName;
                            else
                                roomList += Program.chattingList[i].RoomName;

                        }
                        Program.Broadcast("방 목록:" + roomList + ";;", ClientNickName, true);


                    }
                }

            
            }
        }
    }
}
