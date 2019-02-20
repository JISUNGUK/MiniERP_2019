using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Machine_Client
{
    class Machine
    {
        static string err_Code;                     //  서버로 보내는 에러코드
        static string command_Code;                 //  서버에서 받는 명령어 코드

        public string Err_Code { get { return err_Code; } set { err_Code = value; } }
        public string Command_Code { get { return command_Code; } set { command_Code = value; } }


        TcpClient client;
        static NetworkStream nstream = default(NetworkStream);     //기본값 할당(해당 객체의 기본값 참조형은 null)

        private string serverIp = "192.168.0.240";

        /*
         *  서버에서 명령어 받아서 처리
         *  서버로 에러코드를 보내기
         *  해당 위치의 바코드 지나간거 갯수 트래킹하기
         */


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

        //  에러발생 알고리즘
        //  관제중 에러발생 -> 에러 코드 생성 -> 에러 전송
        /// <summary>
        /// 에러메시지 보내기
        /// </summary>
        /// <param name="err"></param>
        public void Err_Sending(string err)
        {
            if (String.IsNullOrEmpty(err) != true && err.IndexOf("[err]", 0) != -1)     //  에러메시지인지 확인된다면 sanding
            {
                byte[] ubytes = System.Text.Encoding.Unicode.GetBytes(err);
                nstream.Write(ubytes, 0, ubytes.Length);

                Console.WriteLine("errcode send : Ok", err);
            }
            else
                Console.WriteLine("errcode send : Fail");
        }

        //  서버의 명령어 받는 알고리즘
        //  서버의 명령어를 받기 -> 올바른 명령어인지 판독 -> 해당 명령어에 맞는 기능 수행( 정지/시작/실시간 통계 )
        /// <summary>
        /// 서버에서 오는 명령어가 올바른 명령어인지 인식함
        /// </summary>
        /// <param name="msg"></param>
        /// <returns>true 시 올바른 명령어</returns>
        public bool CommandChecker(string msg)
        {
            if (msg.IndexOf("[command]", 0) != -1)
            {
                command_Code = msg;
                return true;
            }
            return false;
        }

        public void CloseSeverTest()
        {
            client.Close();
            nstream.Close();

            Console.WriteLine("sever state : " + client.Connected.ToString());
        }
    }
}
