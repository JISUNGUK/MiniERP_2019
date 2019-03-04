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
        #region 멤버 변수

        TcpClient client;
        NetworkStream stream = default(NetworkStream);              //  기본값 할당(해당 객체의 기본값 참조형은 null)
        Thread thread;                                              //  서버 쓰레드
        string readData = null;                                     //  서버의 메시지

        private string ip;
        private string name;
        object barcodeList;                                         //  바코드정보를 담는 리스트

        List<Command> command = new List<Command>();                //  명령어 리스트
        List<string> erro = new List<string>();                     //  에러 리스트
        public List<Command> Command { get { return command; } }
        public List<string> Erro { get { return erro; } }
        public TcpClient Client { get { return client; } }
        #endregion

        public Chatting(string ipAddr, string name, object barcodelist)
        {
            this.ip = ipAddr; this.name = name;
            this.barcodeList = barcodelist;
        }



        /// <summary>
        /// 머신 클라이언트를 시작합니다.
        /// 머신 서버와 접속합니다..
        /// </summary>
        public bool Start()
        {
            IAsyncResult access = null;
            try
            {
                if (client == null)
                {
                    client = new TcpClient();
                    access = client.BeginConnect(this.ip, 4444, null, null);
                    var result = access.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
                    stream = client.GetStream();

                    SendMsg(this.name);          //  접속클라이언트 이름 보냄
                }
                else if (client.Connected == false)
                {
                    access = client.BeginConnect(this.ip, 4444, null, null);
                    var result = access.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
                    stream = client.GetStream();
                }

                if (thread == null)
                {
                    thread = new Thread(getMsg);
                    thread.Start();
                    if (client.Connected)
                        SendMsg("[command]" + this.name + "is connecting");     //접속성공했다면 메시지
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void DisplayText(string text)
        {
            Byte[] outStream = Encoding.UTF8.GetBytes(text);
            stream.Write(outStream, 0, outStream.Length);
            stream.Flush();
        }

        /// <summary>
        /// 서버가 보내오는 메시지를 수신합니다.    쓰레드호출 메서드
        /// </summary>
        private void getMsg()
        {
            while (true)
            {
                stream = client.GetStream();
                Byte[] byteFrom = new byte[client.SendBufferSize];
                stream.Read(byteFrom, 0, client.SendBufferSize);
                readData = Encoding.UTF8.GetString(byteFrom);
                readData = readData.Replace("\0", "");      //  바이트배열에 빈값(쓰레기값 제거)
                CommandChacker(readData);//  올바른커맨드 판별              
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
                return;
            else if (readData.Contains("접속") == true)   //  서버접속시 접속이라고 보내기에 이를 무시
                return;

            string tempHead = readData.Substring(readData.IndexOf("[command]"), "[command]".Length);
            string tempName = readData.Substring(readData.IndexOf(this.name), this.name.Length);
            string tempValue = readData.Replace(tempHead, "").Replace(tempName, "").Replace("\0","").Trim();

            //  임시커맨드 객체 생성후 리스트에 삽입, 그 후 커맨드 실행함
            Command tempCommand = new Command(tempHead, tempName, tempValue, this, barcodeList);
            command.Add(new Command(tempHead, tempName, tempValue, this, barcodeList));
            tempCommand.CommandRunning();
        }

        /// <summary>
        /// 메시지 보내기
        /// </summary>
        public void SendMsg(string msg)
        {
            stream = client.GetStream();
            Byte[] byteFrom = Encoding.UTF8.GetBytes(msg);
            stream.Write(byteFrom, 0, byteFrom.Length);
            stream.Flush();
        }

        //  서버종료
        public void CloseServer()
        {
            // ex) [command][pc1]is endconnecting
            if (client != null)
            {
                byte[] msgTemp = Encoding.UTF8.GetBytes("[command]" + this.name + "is endconnecting");
                stream = client.GetStream();
                stream.Write(msgTemp, 0, msgTemp.Length);
                stream.Flush();
                client.Close();
                stream.Close();
            }
           
        }

        
    }
}
