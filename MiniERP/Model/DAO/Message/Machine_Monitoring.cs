using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.Model.DAO.Message
{
    class Machine_Monitoring
    {
        TcpClient client;
        NetworkStream stream = default(NetworkStream);
        Thread thread;

        string ip = "192.168.0.6";

        string readData = null;

        object txtBox;

        public Machine_Monitoring(object txtBox)
        {
            this.txtBox = txtBox;
        }

        public void Start()
        {
            if (client == null)
            {
                //System.Windows.Forms.MessageBox.Show("클라is null");
                client = new TcpClient("192.168.0.6", 3333);
                stream = client.GetStream();

                byte[] name = Encoding.UTF8.GetBytes("master");
                stream.Write(name, 0, name.Length);
                stream.Flush();
            }
            else if (client.Connected == false)
            {
                //System.Windows.Forms.MessageBox.Show("클라 재가동");
                client = new TcpClient("192.168.0.6", 3333);
                stream = client.GetStream();
            }
            ////System.Windows.Forms.MessageBox.Show(client.Connected.ToString());

            if (thread == null)
            {
                //System.Windows.Forms.MessageBox.Show("쓰레드is null");
                thread = new Thread(getMsg);
                thread.Start();
            }
        }
        
        private void getMsg()
        {
            while (true)
            {
                stream = client.GetStream();
                Byte[] byteFrom = new byte[client.SendBufferSize];
                stream.Read(byteFrom, 0, client.SendBufferSize);
                readData = Encoding.UTF8.GetString(byteFrom);       //  getString

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(readData);
                ((TextBox)txtBox).Text = sb.ToString();
            }
        }

        public void SendMsg(string msg)
        {
            Byte[] byteFrom = Encoding.UTF8.GetBytes(msg);
            stream.Write(byteFrom, 0, byteFrom.Length);
            stream.Flush();
        }

        public void CloseSever()
        {
            byte[] msgTemp = Encoding.UTF8.GetBytes("접속종료합니다");
            stream.Write(msgTemp, 0, msgTemp.Length);
            stream.Flush();

            client.Close();
            stream.Close();
        }
    }
}
