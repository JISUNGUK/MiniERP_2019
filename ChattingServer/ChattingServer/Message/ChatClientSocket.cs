﻿using System;
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
                catch (Exception ee)
                {
                    System.Windows.Forms.MessageBox.Show("해당 클라이언트와 연결이 끊겼습니다.from ChatclientSocket");
                }
               if(Encoding.UTF8.GetString(messageByte).Replace("\0", "") != "")
                {
               string receivestr= Encoding.UTF8.GetString(messageByte).Replace("\0","");
                    string date = "보낸시간:" + DateTime.Now + "\n";
                    if (receivestr.Contains("$$$$"))//전체에게 전송되는 메시지
                { 
               int letterlastIndex= receivestr.IndexOf("$$$$");
                receivestr = receivestr.Substring(0, letterlastIndex);
                if(receivestr.Contains(""))
                        {
                            Server.chattingList[0].MessageBody += date + "보낸이:" + ClientNickName + Environment.NewLine + "메시지:"+receivestr +"\n";
                            Server.Broadcast(receivestr, ClientNickName, false);
                        }

                    }
                if(receivestr.Contains("방에 메시지를 보냅니다"))
                {
                    int index = receivestr.IndexOf("방에 메시지를 보냅니다");
                    string roomname = receivestr.Substring(0, index);
                    string message = receivestr.Remove(0, 12 + index).Replace("//", "");
                    foreach (ChattingElement item in Server.chattingList)
                    {
                        if (item.RoomName == roomname)
                        {
                                
                            
                           item.MessageBody += date+"보낸이:"+ ClientNickName + Environment.NewLine + "메시지:"+message+"\n";
                            if (item.NicNames != "")
                                item.NicNames += "," + ClientNickName;
                            else
                                item.NicNames += ClientNickName;
                                Server.Multicast(message, ClientNickName, item, false);
                           // FTPServer.Logger.Text+="\n"+ClientNickName + "의 메시지:" + message;
                        }
                    }
                }
               
                if (receivestr.Contains("방에 참가했습니다"))
                {
                    int index = receivestr.IndexOf("방에 참가했습니다");
                    string roomname = receivestr.Remove(index);
                    foreach (ChattingElement item in Server.chattingList)
                    {
                        if (item.RoomName == roomname)
                        {
                            if(item.NicNames!="")
                                item.NicNames += ","+ClientNickName;                                
                            else
                                item.NicNames +=ClientNickName;
                                Server.Multicast(roomname + "에 참가했습니다", ClientNickName, item, true);
                                FTPServer.Logger.Text += "\n" + ClientNickName +"님이 방에 참여 했습니다"+roomname+"\n";
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
                    for(int i=0;i< Server.chattingList.Count;i++)
                    {
                        if(Server.chattingList[i].RoomName==roomname)
                        {
                            Server.Unicast("해당 방은 있습니다", this, true);
                                FTPServer.Logger.Text += "\n" + "해당 방은 있습니다\n";
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
                            Server.chattingList.Add(chatting);
                        int count = 0;
                        foreach(var v in Server.chattingList)
                        {
                            if (count != 0)
                                rooms += "," + v.RoomName;
                            else
                                rooms += v.RoomName;
                                FTPServer.Logger.Text += "\n" + "방명:" +v.RoomName;
                                FTPServer.Logger.Text += "\n" + "참가자들:" +v.NicNames;
                            count++;
                        }
                     
                        Server.Broadcast("방 목록:" + rooms + ";;", ClientNickName, true);
                    }

                }
                if(receivestr.Contains("접속종료합니다"))
                {                                                                                                                             
                            Server.clientList.Remove(ClientNickName);
                        string members = "";
                        for(int i=0;i < Server.chattingList.Count;i++)
                        {
                            if (Server.chattingList[i].NicNames.Contains(ClientNickName))
                            {
                                Server.chattingList[i].NicNames.Replace(ClientNickName, "");
                                if (Server.chattingList[i].NicNames.Contains(",,"))
                                    Server.chattingList[i].NicNames.Replace(",,", ",");
                                if (Server.chattingList[i].NicNames.IndexOf(",") == 1)
                                    Server.chattingList[i].NicNames.Substring(1);
                                if (Server.chattingList[i].NicNames.IndexOf(",") == Server.chattingList[i].NicNames.Length - 1)
                                    Server.chattingList[i].NicNames = Server.chattingList[i].NicNames.Remove(Server.chattingList[i].NicNames.Length - 1);
                            }
                        }
                        members = Server.GetMember();
                       FTPServer.Logger.Text += "\n" + ClientNickName +"님이 접속 종료했습니다\n";
                        Server.Broadcast("접속 인" +
                            "원:" + members + "::", ClientNickName, true);
                        break;
                    }
                if(receivestr.Contains("방을 삭제합니다"))
                    {
                        int lastIndex = receivestr.IndexOf("방을 삭제합니다");
                        string roomName = receivestr.Remove(lastIndex);
                        string roomList = "";
                        
                        for (int i = 0; i < Server.chattingList.Count; i++)
                        {
                       
                            if (Server.chattingList[i].RoomName==roomName)
                            {
                                Server.chattingList.RemoveAt(i);
                                continue;
                            }
                            if(roomList!="")
                                roomList += "," + Server.chattingList[i].RoomName;
                            else
                                roomList += Server.chattingList[i].RoomName;

                        }
                        Server.Broadcast("방 목록:" + roomList + ";;", ClientNickName, true);


                    }
                }

            
            }
        }
    }
}
