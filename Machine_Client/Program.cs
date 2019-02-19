using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine_Client
{
    class Program
    {
        static void Main(string[] args)
        {

            //  건들지마셈 두낫 터치미 섹스
            string msg = "[command] Connecting is lost";

            Machine test = new Machine();

            Console.WriteLine(test.CommandChecker(msg));

            //test.Setting();
            test.Err_Sending(msg);
        }
    }
}
