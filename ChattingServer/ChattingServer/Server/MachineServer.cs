using ChattingServer.Message;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ChattingServer.Server
{
    class MachineServer
    {
        public static Hashtable machineList = new Hashtable();
        //public static List<ChattingElement> machi = new List<ChattingElement>();
        private string ipaddress = "192.168.0.6";
        public void StartMessage()
        {

            var ipaddr = IPAddress.Parse(ipaddress);
            try
            {
                System.Net.Sockets.TcpListener serverListener = new System.Net.Sockets.TcpListener(ipaddr, 4444);
                serverListener.Start();
                //  FTPServer.Logger.Text += "채팅서버 가동>>>>\n";
                //ChattingElement chattingAll = new ChattingElement();//전체 채팅방
                //chattingAll.RoomName = "전체";

                //chattingList.Add(chattingAll);//전체 사용자에게 전송되는 방,,,

                for (; ; )
                {
                    var machineSocket = serverListener.AcceptTcpClient();//접속된 클라이언트 반환
                    string machineName = null;
                    if (machineSocket.Connected)
                    {
                        var ns = machineSocket.GetStream();
                        Byte[] byteFrom = new Byte[machineSocket.SendBufferSize];
                        ns.Read(byteFrom, 0, machineSocket.SendBufferSize);
                        machineName = Encoding.UTF8.GetString(byteFrom);


                        int index = machineName.IndexOf("\0");
                        machineName = machineName.Remove(index, machineName.Length - index);
                        //   FTPServer.Logger.Text += "접속을 감지했습니다\n";
                        if (!machineList.Contains(machineName))
                        {

                            machineList.Add(machineName, machineSocket);//채팅참여자 관리
                            //FTPServer.Logger.Text += "\n" + clientNickName + "\n";                           
                            //참여자 목록(clientList)을 클라이언트 접속한 클라이언트에 접속

                         
                            MachineClientSocket client = new MachineClientSocket(machineSocket, machineName, machineList);
                        }
                        else
                        {
                            MachineClientSocket client = new  MachineClientSocket(machineSocket, machineName, machineList);
                           

                        }

                    }

                }
            }
            catch (Exception ee)
            {
                throw;

            }//서버가 대기하기 시작함

        }
    }
}
