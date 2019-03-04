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
        private string head;                //  [command]

        public string Head
        {
            get { return head; }
            set { head = value; }
        }

        private string name;                //  [pc1]

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string command_Value;       //  프로그램종료

        public string Command_Value
        {
            get { return command_Value; }
            set { command_Value = value; }
        }

        private Chatting chatinfo;

        private List<Barcode> barcodes;

        public Command(string name, string command_Head, string command_Value,Chatting chatinfo,object barcodelist)
        {
            this.name = name;
            this.head = command_Head;
            this.command_Value = command_Value;
            this.chatinfo = chatinfo;
            this.barcodes = (List<Barcode>)barcodelist;
        }

        public Command(string command_Value)
        {
            this.command_Value = command_Value;
        }
        
        //  바코드 리스트를 보내는 메소드
        public void BarcodeMsgMaker(List<Barcode> barcodes)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------[투입 현황]" + this.Name);
            sb.AppendLine(NowTime());
            foreach (var item in barcodes)
            {
                sb.AppendLine("*[" + item.Barcode_Code + "]" + "\t" + item.Barcode_Count);
            }
            sb.AppendLine("----------------------------");

            chatinfo.SendMsg(sb.ToString());
        }

        /// <summary>
        /// 현재 시간의 스트링을 만드는 메서드
        /// </summary>
        private string NowTime()
        {
            DateTime dt = DateTime.Now;
            return
                "---------[" + dt.ToShortDateString() + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second + "]";
        }

        public void ChangeIp()
        {
            //  [command][this.name][ip]192.168.0.8
            if (new Form1().IsValidIp(this.command_Value))
            {
                AppConfiguration.SetAppConfig("ip", this.command_Value);
                chatinfo.SendMsg(this.name + "ip change ok");
            }
            else
            {
                chatinfo.SendMsg(this.name + "ip change not ok");
            }
        }
        public void ChangeName()
        {
            //  [command][this.name][name]pc2
            AppConfiguration.SetAppConfig("name", this.command_Value);
        }

        public  void CommandRunning()
        {
            if (this.command_Value.Contains("[ip]"))                            //  ip변경 커맨드
            {
                this.command_Value = Command_Value.Replace("[ip]", "");
                ChangeIp();
                return;
            }
            else if (this.command_Value.Contains("[name]"))                     //  이름변경 커맨드
            {
                this.command_Value = Command_Value.Replace("[name]", "");
                ChangeName();
                Application.Restart();                                          //  이름변경후 재시작
                return;
            }

            switch (this.command_Value)                                         //  커맨드 선택부
            {
                case "test_module": System.Windows.Forms.MessageBox.Show("Test"); break;
                case "exit": Application.Exit(); break;
                case "restart": Application.Restart(); break;
                case "barcode": BarcodeMsgMaker(barcodes); break;

                default:
                    break;
            }
        }


    }
}
