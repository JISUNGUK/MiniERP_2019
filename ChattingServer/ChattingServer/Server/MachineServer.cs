using ChattingServer.Message;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChattingServer.Server
{
    class MachineServer
    {
        public static Hashtable machineTable = new Hashtable();//해당 기계의 이름과 ip를 저장
        public static Hashtable machineLog = new Hashtable();//해당 기계의 이름과 작동내역을 저장
        private string ipaddress = "192.168.0.6";
        public void StartMessage()
        {

            var ipaddr = IPAddress.Parse(ipaddress);
            try
            {
                System.Net.Sockets.TcpListener serverListener = new System.Net.Sockets.TcpListener(ipaddr, 4444);
                serverListener.Start();
                  FTPServer.Logger.Text += "머신서버 가동>>>>\n";
                

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
                           FTPServer.Logger.Text += "기계접속을 감지했습니다\n";
                        if (!machineTable.Contains(machineName))
                        {

                            
                            FTPServer.Logger.Text += "\n" + machineName+ "\n";                           
                            //참여자 목록(clientList)을 클라이언트 접속한 클라이언트에 접속

                         
                            MachineClientSocket client = new MachineClientSocket(machineSocket, machineName, machineTable);
                            machineTable.Add(machineName, client);//머신 관리
                        }
                        else
                        {
                            Unicast("해당 기계는 이미 등록되어있습니다", machineSocket);  
                           

                        }

                    }

                }
            }
            catch (Exception)
            {
                throw;

            }//서버가 대기하기 시작함



        }

        public static void Unicast(string msg,TcpClient tcpclient)
        {
            try
            {
                NetworkStream ns = tcpclient.GetStream();
                Byte[] msgByte = Encoding.UTF8.GetBytes(msg);
                ns.Write(msgByte, 0, msgByte.Length);
                ns.Flush();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void Broadcast(string msg, string machinename)
        {
            //throw new NotImplementedException();//지금 구현 부분 아니면 남겨둔다!!;
            foreach (DictionaryEntry key in machineTable)
            {
                MachineClientSocket machine =(MachineClientSocket)key.Value;
                TcpClient tcp = machine.MachineSockets;
                if (tcp.Connected)
                {
                    NetworkStream ns = tcp.GetStream();
                    byte[] bytemsg = new byte[tcp.ReceiveBufferSize];                    
                        bytemsg = Encoding.UTF8.GetBytes(msg);//메시지를 바이트배열로 저장                                       
                      ns.Write(bytemsg, 0, bytemsg.Length);
                    ns.Flush();

                }
            }

        }

    }
}
