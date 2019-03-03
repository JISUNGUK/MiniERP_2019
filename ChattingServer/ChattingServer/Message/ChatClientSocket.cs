using System;
using System.Collections;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChattingServer
{
    /// <summary>
    /// 채팅 참여자 각각이 메시지를 서버측에 보내는 메시지를 읽는 스레드를 위한 클래스
    /// </summary>
    public class ChatClientSocket
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
                    ns.Read(messageByte, 0, ChatClientSockets.ReceiveBufferSize);
                    }
                }
                catch (Exception)
                {
                    ChatServer.clientList.Remove(clientNickName);                                    
                    break;

                }
                if(messageByte!=null)
                { 
               if(Encoding.UTF8.GetString(messageByte).Replace("\0", "") != "")
                {
               string receivestr= Encoding.UTF8.GetString(messageByte).Replace("\0","");
                    string date = "보낸시간:" + DateTime.Now + "\n";
                        //FTPServer.Logger.Text +="들어온 메시지:"+ receivestr+"\n";
                    if (receivestr.Contains("$$$$"))//전체에게 전송되는 메시지
                { 
               int letterlastIndex= receivestr.IndexOf("$$$$");
                receivestr = receivestr.Substring(0, letterlastIndex);
                if(receivestr.Contains(""))
                        {
                            ChatServer.chattingList[0].MessageBody += date + "보낸이:" + ClientNickName + Environment.NewLine + "메시지:"+receivestr +"\n";
                            ChatServer.Broadcast(receivestr, ClientNickName, false);
                                ServerForm.chattcount++;
                            }

                    }
                if(receivestr.Contains("방에 메시지를 보냅니다"))
                {
                    int index = receivestr.IndexOf("방에 메시지를 보냅니다");
                    string roomname = receivestr.Substring(0, index);
                    string message = receivestr.Remove(0, 12 + index).Replace("//", "");
                    foreach (ChattingElement item in ChatServer.chattingList)
                    {
                        if (item.RoomName == roomname)
                        {
                                
                            
                           item.MessageBody += date+"보낸이:"+ ClientNickName + Environment.NewLine + "메시지:"+message+"\n";
                            if (item.NicNames != "")
                                item.NicNames += "," + ClientNickName;
                            else
                                item.NicNames += ClientNickName;
                                ChatServer.Multicast(message, ClientNickName, item, false);
                                ServerForm.chattcount++;
                                    //FTPServer.Logger.Text+="\n"+ClientNickName + "의 메시지:" + message;
                                }
                    }
                }
               
                if (receivestr.Contains("방에 참가했습니다"))
                {
                    int index = receivestr.IndexOf("방에 참가했습니다");
                    string roomname = receivestr.Remove(index);
                    foreach (ChattingElement item in ChatServer.chattingList)
                    {
                        if (item.RoomName == roomname)
                        {
                            if(item.NicNames!="")
                                item.NicNames += ","+ClientNickName;                                
                            else
                                item.NicNames +=ClientNickName;
                               ChatServer.Multicast(roomname + "에 참가했습니다", ClientNickName, item, true);
                                //FTPServer.Logger.Text += "\n" + ClientNickName +"님이 방에 참여 했습니다"+roomname+"\n";
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
                    for(int i=0;i< ChatServer.chattingList.Count;i++)
                    {
                        if(ChatServer.chattingList[i].RoomName==roomname)
                        {
                           // ChatServer.Unicast("해당 방은 있습니다", this, true);
                              //  FTPServer.Logger.Text += "\n" + "해당 방은 있습니다\n";
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
                            ChatServer.chattingList.Add(chatting);
                        int count = 0;
                        foreach(var v in ChatServer.chattingList)
                        {
                            if (count != 0)
                                rooms += "," + v.RoomName;
                            else
                                rooms += v.RoomName;
                                      //FTPServer.Logger.Text += "\n" + "방명:" +v.RoomName+"\n";
                                    // FTPServer.Logger.Text += "\n" + "참가자들:" +v.NicNames+"\n";
                                    count++;
                        }

                            ChatServer.Broadcast("방 목록:" + rooms + ";;", ClientNickName, true);
                    }

                }
                if(receivestr.Contains("접속종료합니다"))
                {
                        ChatServer.clientList.Remove(ClientNickName);
                        string members = "";
                        for(int i=0;i < ChatServer.chattingList.Count;i++)
                        {
                            if (ChatServer.chattingList[i].NicNames.Contains(ClientNickName))
                            {
                                ChatServer.chattingList[i].NicNames.Replace(ClientNickName, "");
                                if (ChatServer.chattingList[i].NicNames.Contains(",,"))
                                    ChatServer.chattingList[i].NicNames.Replace(",,", ",");
                                if (ChatServer.chattingList[i].NicNames.IndexOf(",") == 1)
                                    ChatServer.chattingList[i].NicNames.Substring(1);
                                if (ChatServer.chattingList[i].NicNames.IndexOf(",") == ChatServer.chattingList[i].NicNames.Length - 1)
                                    ChatServer.chattingList[i].NicNames = ChatServer.chattingList[i].NicNames.Remove(ChatServer.chattingList[i].NicNames.Length - 1);
                            }
                        }
                        members = ChatServer.GetMember();
                       //FTPServer.Logger.Text += "\n" + ClientNickName +"님이 접속 종료했습니다\n";
                        ChatServer.Broadcast("접속 인" +
                            "원:" + members + "::", ClientNickName, true);
                        break;
                    }
                if(receivestr.Contains("방을 삭제합니다"))
                    {
                        int lastIndex = receivestr.IndexOf("방을 삭제합니다");
                        string roomName = receivestr.Remove(lastIndex);
                        string roomList = "";
                        
                        for (int i = 0; i < ChatServer.chattingList.Count; i++)
                        {
                       
                            if (ChatServer.chattingList[i].RoomName==roomName)
                            {
                                ChatServer.chattingList.RemoveAt(i);
                                continue;
                            }
                            if(roomList!="")
                                roomList += "," + ChatServer.chattingList[i].RoomName;
                            else
                                roomList += ChatServer.chattingList[i].RoomName;

                        }
                        ChatServer.Broadcast("방 목록:" + roomList + ";;", ClientNickName, true);


                    }
                }
                }


            }
        }
    }
}
