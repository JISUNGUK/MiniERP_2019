using System;
using System.Collections.Generic;
using System.Linq;
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

        private string serverIp = "192.168.0.6";

        /*
         *  서버에서 명령어 받아서 처리
         *  서버로 에러코드를 보내기
         *  해당 위치의 바코드 지나간거 갯수 트래킹하기
         */

        public void Setting()
        {
            if (client == null)
            {
                client = new TcpClient(serverIp, 3333);
                nstream = client.GetStream();
            }

            Console.WriteLine("setting is green");
        }

        /// <summary>
        /// 에러메시지 보내기
        /// </summary>
        /// <param name="err"></param>
        public void Err_Sending(string err)
        {
            if (String.IsNullOrEmpty(err) != false)     //  명령어
            {
                byte[] ubytes = System.Text.Encoding.Unicode.GetBytes(err);
                nstream.Write(ubytes, 0, ubytes.Length);

                Console.WriteLine("errcode send : Ok", err);
            }
            else
                Console.WriteLine("errcode send : Fail");
        }

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
    }
}
