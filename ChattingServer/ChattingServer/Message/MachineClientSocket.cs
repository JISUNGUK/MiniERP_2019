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
                catch (Exception ee)
                {
                    System.Windows.Forms.MessageBox.Show("해당 클라이언트와 연결이 끊겼습니다.from ChatclientSocket");
                }
                if(messageByte!=null)
                { 
                if (Encoding.UTF8.GetString(messageByte).Replace("\0", "") != "")
                {
                    string receivestr = Encoding.UTF8.GetString(messageByte).Replace("\0", "");
                    string date = "보낸시간:" + DateTime.Now + "\n";
                    if (receivestr.Contains("$$$$"))//서버에게 작업보고
                    {
                        int letterlastIndex = receivestr.IndexOf("$$$$");
                        receivestr = receivestr.Substring(0, letterlastIndex);
                        if (receivestr.Contains(""))
                        {
                            MachineServer.machineList[0] += date + "기계명:" + machineName + Environment.NewLine + "메시지:" + receivestr + "\n";
                           //Server.Broadcast(receivestr, ClientNickName, false);
                        }

                    }                                                         
                    if (receivestr.Contains("접속종료합니다"))
                    {
                        ServerForm.machineList.Remove(machineName);

                        //FTPServer.Logger.Text += "\n" + MachineName + "기계가 중지되었습니다\n";                     
                        break;
                    }
                    
                }
                }


            }
        }
    }
}
