using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Machine_Client
{
    //  콘솔에서 바코드 통신 시리얼로 구현
    //  키워드 비동기 시리얼 통신
    //  https://icodebroker.tistory.com/1599

    class SerialPortManager
    {
        #region field
        private SerialPort serialPort;

        private Thread GetThread;       //  Read
        private Thread SetThread;       //  Write
        #endregion

        public SerialPortManager()
        {
            try
            {
                this.serialPort = new SerialPort("Scanner", 57600, Parity.None, 8);
                this.serialPort.Open();
            }
            catch (Exception exception)

            {
                Console.WriteLine(exception.Message);
            }
        }

        public void Start()
        {
            this.GetThread = new Thread(new ThreadStart(Read));

            this.GetThread.IsBackground = true; // Background에서 실행되게 한다.

            this.GetThread.Start();

            this.GetThread = new Thread(new ThreadStart(Write));

            this.GetThread.IsBackground = false; // 콘솔 창 출력을 위해 Foreground로 실행되게 한다.

            this.GetThread.Start();
        }

        private void Write()
        {
            for (; ; )
            {
                this.serialPort.WriteLine(Console.ReadLine());
                Thread.Sleep(200); // 200 밀리초 시간마다 다른 쓰레드가 실행될 수 있게 한다.
            }
        }


        private void Read()
        {
            for (; ; )
            {
                Console.Write(this.serialPort.ReadExisting());
                Thread.Sleep(200); // 200 밀리초 시간마다 다른 쓰레드가 실행될 수 있게 한다.
            }
        }
    }
}
