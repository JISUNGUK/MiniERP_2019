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
            StringBuilder temp = new StringBuilder();
            foreach (var item in barcodes)
            {
                temp.AppendLine(item.Barcode_Code + "\t" + item.Barcode_Count);
            }

            chatinfo.SendMsg(temp.ToString());
        }

        public  void CommandRunning()
        {
            switch (this.command_Value)
            {
                case "test_module": System.Windows.Forms.MessageBox.Show("Test"); break;
                case "exit": Application.Exit(); break;
                case "restart": Application.Restart();  break;
                case "barcode": BarcodeMsgMaker(barcodes); break;

                default:
                    break;
            }
        }


    }
}
