using ChattingServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChattingServer.Message
{
    class MachineClientSocket
    {
        private TcpClient machineSockets;
        private string machineName;
        private Hashtable machineList;

        public MachineClientSocket(TcpClient machineSockets, string machineName, Hashtable machineList)
        {
            this.machineSockets = machineSockets;
            this.MachineName = machineName;
            this.MachineList = machineList;
            Thread thread = new Thread(Doread);
            thread.Start();

        }

        public TcpClient MachineSockets { get => machineSockets; set => machineSockets = value; }
        public string MachineName { get => machineName; set => machineName = value; }
        public Hashtable MachineList { get => machineList; set => machineList = value; }

        

        /// <summary>
        /// 머신 클라이언트가 접속후 보내온 메시지를 읽어들임
        /// </summary>
        private void Doread()
        {
           
            while (true)
            {
                Byte[] messageByte = null;
                try
                {
                    if (machineSockets.Connected)
                    {
                        
                        NetworkStream ns = machineSockets.GetStream();
                        messageByte = new Byte[machineSockets.ReceiveBufferSize];
                        ns.Read(messageByte, 0, machineSockets.ReceiveBufferSize);
                    }
                }
                catch (Exception)
                {
                    MachineServer.machineTable.Remove(machineName);
                   
                    break;
                }
                if(messageByte!=null)
                {
                    if (Encoding.UTF8.GetString(messageByte).Replace("\0", "") != "")
                    {
                        string receivestr = Encoding.UTF8.GetString(messageByte).Replace("\0", "");
                        string date = "작업시간:" + DateTime.Now + "\n";                                       
                        FTPServer.Logger.Text += receivestr+"\n";
                        MachineServer.Broadcast(receivestr, machineName);
                        MachineServer.machineLog[machineName] += date+ "\n" + receivestr;
                        ServerForm.machinCount++;

                        if (receivestr.Contains("endconnecting"))
                        {
                            MachineServer.machineTable.Remove(machineName);
                            MachineServer.machineLog.Remove(machineName);
                            FTPServer.Logger.Text += "\n" + MachineName + "기계가 중지되었습니다\n";                     
                            break;
                        }

                    }   
                }                
                }


            }
        
        /// <summary>
        /// 해당 머신에게 명령을 전송 
        /// </summary>
        /// <param name="message">해당기계에게 전송될 메시지</param>
        public void sendMessage(string message)
        {
            NetworkStream ns = this.machineSockets.GetStream();
            Byte[] messagebyte = Encoding.UTF8.GetBytes(message);
            ns.Write(messagebyte, 0, messagebyte.Length);
            ns.Flush();
        }
    }
}

