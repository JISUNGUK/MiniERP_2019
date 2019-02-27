using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniErp_Client_jsu
{
    class Chatting
    {
        private string ip;
        private string name;
        object barcodeList;

        public Chatting(string ipAddr, string name, object barcodelist)
        {
            this.ip = ipAddr; this.name = name;
            this.barcodeList = barcodelist;
            //System.Windows.Forms.MessageBox.Show(ip, name);
        }

        TcpClient client;
        NetworkStream stream = default(NetworkStream);//기본값 할당(해당 객체의 기본값 참조형은 null)

        string readData = null;

        Thread thread;

        /// <summary>
        /// 머신 클라이언트를 시작합니다.
        /// 머신 서버와 접속합니다..
        /// </summary>
        public void Start()
        {
            try
            {
                if (client == null)
                {
                    client = new TcpClient(this.ip, 4444);
                    stream = client.GetStream();

                    SendMsg(this.name);          //  접속클라이언트 이름 보냄
                }
                else if (client.Connected == false)
                {
                    client = new TcpClient(this.ip, 4444);
                    stream = client.GetStream();
                }

                if (thread == null)
                {
                    thread = new Thread(getMsg);
                    thread.Start();
                    if (client.Connected)
                        SendMsg("[command]" + this.name + "is connecting");     //접속성공했다면 메시지
                }
            }
            catch (Exception)
            {
                MessageBox.Show("접속실패");
                Application.Exit();
            }
        }

        private void DisplayText(string text)
        {
            Byte[] outStream = Encoding.UTF8.GetBytes(text);
            stream.Write(outStream, 0, outStream.Length);
            stream.Flush();//스트림에 쓴후에 flush를 해야한다
        }


        List<Command> command = new List<Command>();
        List<string> erro = new List<string>();
        public List<Command> Command { get { return command; } }
        public List<string> Erro { get { return erro; } }

        private void getMsg()
        {
            //  서버가 보내준 메시지를 받음!!!
            //  보내오는 메시지는 커멘드인지 확인을 하고 리스트에 저장함!
            while (true)
            {
                stream = client.GetStream();
                Byte[] byteFrom = new byte[client.SendBufferSize];
                stream.Read(byteFrom, 0, client.SendBufferSize);
                readData = Encoding.UTF8.GetString(byteFrom);

                readData = readData.Replace("\0", "");      //  바이트배열에 빈값(쓰레기값 제거)
                CommandChacker(readData);                   //  올바른커맨드 판별
            }
        }
        /// <summary>
        /// 올바른 command 인지 인식합니다.
        /// 올바르다면 list에 추가함
        /// </summary>
        /// <param name="readData">서버에서 msg</param>
        private void CommandChacker(string readData)
        {
            //string testMsg = "[command][pc1] 서버종료";
            if (readData.Contains("[command]") != true || readData.Contains("[pc1]") != true)
            {
                return;
                //  커맨드 조건을 통과함
                //  올바른 조건 통과한 log 남길것.
            }
            else if (readData.Contains("접속") == true)
            {
                return;
            }

            string tempHead = readData.Substring(readData.IndexOf("[command]"), "[command]".Length);
            string tempName = readData.Substring(readData.IndexOf(this.name), this.name.Length);
            string tempValue = readData.Replace(tempHead, "").Replace(tempName, "").Replace("\0","").Trim();

            Command tempCommand = new Command(tempHead, tempName, tempValue, this, barcodeList);
            
            command.Add(tempCommand);

            tempCommand.CommandRunning();
        }



        //  메시지 보내기
        public void SendMsg(string msg)
        {
            Byte[] byteFrom = Encoding.UTF8.GetBytes(msg);
            stream.Write(byteFrom, 0, byteFrom.Length);
            stream.Flush();
        }



        //  서버종료
        public void CloseSeverTest()
        {
            byte[] msgTemp = Encoding.UTF8.GetBytes(this.name+"접속종료합니다");       //[pc1]접속종료합니다.
            stream.Write(msgTemp, 0, msgTemp.Length);
            stream.Flush();

            client.Close();
            stream.Close();
        }

        
    }
}
