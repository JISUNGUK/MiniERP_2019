using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MiniErp_Client_jsu
{
    class Machine
    {
        TcpClient client;
        static NetworkStream nstream = default(NetworkStream);     //기본값 할당(해당 객체의 기본값 참조형은 null)

        private string serverIp = "192.168.0.240";


        //  처음실행시 접속을 위한 셋팅
        public void Setting()
        {
            if (client == null)
            {
                client = new TcpClient(serverIp, 3333);
                nstream = client.GetStream();
                nstream.Flush();
                //Console.WriteLine("client is setting");
            }
            else if (client.Connected == false)
            {
                client = new TcpClient(serverIp, 3333);
                nstream = client.GetStream();
                //Console.WriteLine("다시엽니당");
            }

            Console.WriteLine("sever state : " + client.Connected.ToString());
        }


        /// <summary>
        /// 메시지 보내기
        /// </summary>
        /// <param name="msg">command, err code 샌딩</param>
        public void SendingMsg(string msg)
        {
            try
            {
                Byte[] tempBytes = Encoding.Unicode.GetBytes(msg);
                nstream.Write(tempBytes, 0, tempBytes.Length);
                System.Windows.Forms.MessageBox.Show("sending ok");
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("sending fail");
            }
        }


        public void CloseSeverTest()
        {
            client.Close();
            nstream.Close();

            //Console.WriteLine("sever state : " + client.Connected.ToString());
        }

        public bool SeverState()
        {
            return client.Connected;
        }

        
    }
}
