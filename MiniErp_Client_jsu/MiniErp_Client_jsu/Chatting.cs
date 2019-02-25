using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniErp_Client_jsu
{
    class Chatting
    {
        private string ip;
        private string name;

        public Chatting(string ipAddr, string name)
        {
            this.ip = ipAddr;   this.name = name;
        }

        TcpClient client;
        NetworkStream network = default(NetworkStream);//기본값 할당(해당 객체의 기본값 참조형은 null)
        string readData = null;

        Thread thread;
        public void Start()
        {
            if (client == null)
            {
                System.Windows.Forms.MessageBox.Show("클라is null");
                client = new TcpClient("192.168.0.6", 3333);
                network = client.GetStream();

                byte[] name = Encoding.UTF8.GetBytes("기계1");
                network.Write(name, 0, name.Length);
                network.Flush();
            }
            else if (client.Connected == false)
            {
                client = new TcpClient("192.168.0.6", 3333);
                network = client.GetStream();
            }
            System.Windows.Forms.MessageBox.Show(client.Connected.ToString());

            if (thread == null)
            {
                System.Windows.Forms.MessageBox.Show("쓰레드is null");
                thread = new Thread(getMsg);
                thread.Start();
            }
        }


        private void DisplayText(string text)
        {
            Byte[] outStream = Encoding.UTF8.GetBytes(text);
            network.Write(outStream, 0, outStream.Length);
            network.Flush();//스트림에 쓴후에 flush를 해야한다
        }


        List<string> command = new List<string>();
        List<string> erro = new List<string>();
        public List<string> Command { get { return command; } }
        public List<string> Erro { get { return erro; } }

        private void getMsg()
        {
            //  서버가 보내준 메시지를 받음!!!
            //  보내오는 메시지는 커멘드인지 확인을 하고 리스트에 저장함!
            while (true)
            {
                network = client.GetStream();
                Byte[] byteFrom = new byte[client.SendBufferSize];
                network.Read(byteFrom, 0, client.SendBufferSize);
                readData = Encoding.UTF8.GetString(byteFrom);
                System.Windows.Forms.MessageBox.Show(readData);
                command.Add(readData);
            }
        }
        
        //  바코드 리스트를 보내는 메소드
        public void BarcodeMsgMaker(List<Barcode> barcodes)
        {
            StringBuilder temp = new StringBuilder();
            foreach (var item in barcodes)
            {
                temp.AppendLine(item.Barcode_Code + "\t" + item.Barcode_Count);
            }

            SendMsg(temp.ToString());
        }

        //  메시지 보내기
        public void SendMsg(string msg)
        {
            Byte[] bytefrom = Encoding.UTF8.GetBytes(msg);
            network.Write(bytefrom, 0, bytefrom.Length);
            network.Flush();
        }



        //  서버종료
        public void CloseSeverTest()
        {
            client.Close();
            network.Close();

            //Console.WriteLine("sever state : " + client.Connected.ToString());
        }
    }
}
