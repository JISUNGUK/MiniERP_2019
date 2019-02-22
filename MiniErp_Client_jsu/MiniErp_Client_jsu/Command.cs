using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//  커맨드 생성
//  올바른 커멘드인지 체크
//  커멘드 펑션 실행 ( 정지, 재시작 )
namespace MiniErp_Client_jsu
{
    class Command
    {
        private string head;

        public string Head
        {
            get { return head; }
            set { head = value; }
        }
        private string command_String;

        public string Command_String
        {
            get { return command_String; }
            set { command_String = value; }
        }

        public Command(string command_String)
        {
            this.head = command_String.Substring(command_String.IndexOf('['), command_String.IndexOf(']')+1);   //  명령어
            this.command_String = command_String.Replace(this.head, "").Trim();
        }

        public  void CommandRunning()
        {
            if (this.head != "[command]")
                return;
            switch (this.command_String)
            {
                case "mbtest": System.Windows.Forms.MessageBox.Show("Test"); break;
                case "exit": Application.Exit(); break;
                case "restart": Application.Restart();  break;
                case "logsand": break;

                default:
                    break;
            }
        }


    }
}
