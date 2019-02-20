using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine_Client
{
    class Program
    {
        static void Main(string[] args)
        {

            //  건들지마셈 두낫 터치미
            string errMsg = "[err] Connecting is lost";
            string comMsg = "[command] test";

            Machine test = new Machine();

            //Console.WriteLine(test.CommandChecker(msg));

            test.Setting();

            if (Console.ReadLine() != "1")
            {
                // test 진입 기점
            }

            #region 재접속 테스트 블럭
            //test.Err_Sending(errMsg);

            //test.CloseSeverTest();

            //test.Setting();

            //test.Err_Sending(errMsg);
            #endregion

            ////  콘솔에서 바코드 통신 시리얼로 구현
            ////  키워드 비동기 시리얼 통신
            ////  https://icodebroker.tistory.com/1599
            //SerialPort port = new SerialPort("SCANNER");
            //port.Open();
            //string data = port.ReadLine();
            //Console.WriteLine(data);

            // 1. 기계-> 서버로 에러메시지 보내기샌드      보내기도  하나의 쓰레드가 읽고 보내고 / 쓰래드 2개 tcp 소켓2개 읽기/tcp client 2개
            // 2. 서버-> 기계로 명령어                     받기


            SerialPortManager serial = new SerialPortManager();
            serial.Start();



            //  완성품 카운트 메소드
        }
    }
}
