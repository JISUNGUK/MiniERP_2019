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

        TcpClient client = new TcpClient();//tcpclient를 미리 초기화해놓음
        NetworkStream stream = default(NetworkStream);
        Thread thread;
        object txtBox;
        
        

        string ip = "192.168.0.6";


        string readData = null;

        public Machine_Monitoring(object txtBox)
        {
            this.txtBox = txtBox;
        }

        public void Start()
        {
            IAsyncResult access = null;
            try
            {
                access = client.BeginConnect(ip, 4444, null, null);
                var result = access.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));

                stream = client.GetStream();

                byte[] name = Encoding.UTF8.GetBytes("master");     //  접속 닉네임? 주라고하드라 추후수정
                stream.Write(name, 0, name.Length);
                stream.Flush();

                thread = new Thread(getMsg);
                thread.Start();
            }
            catch (Exception)
            {
                return;
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

                ((TextBox)txtBox).Text = readData;

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
