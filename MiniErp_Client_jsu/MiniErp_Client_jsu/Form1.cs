using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//  taskkill /im minierp_client_jsu.exe /f 
namespace MiniErp_Client_jsu
{
    public partial class Form1 : Form
    {
        Machine machine = new Machine();
        Chatting chatting;

        //  erro , command 리스트
        List<Erro> erros = new List<Erro>();
        List<Command> commands = new List<Command>();
        List<Barcode> codes = new List<Barcode>();

        public Form1()
        {
            InitializeComponent();
            this.Text = machine.Name;
            this.TopMost = true;
            chatting = new Chatting(machine.Ip, machine.Name, codes);

            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("---------[투입 현황]");
            //sb.AppendLine("---------[2019-03-02 6:44:50]");
            //sb.AppendLine("*[1234]	1");
            //sb.AppendLine("*[1235]	1");
            //sb.AppendLine("----------------------------");

            ////  바코드 문자열잘라줄때쓰자
            //string temp = sb.ToString().Remove(0, sb.ToString().IndexOf('*')).Replace("-", "").Trim();
            //string[] temp2 = temp.Split('*');
            //MessageBox.Show(temp);
            //foreach (var item in temp2)
            //{
            //    MessageBox.Show(item);
            //}
        }



        private void txt_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string temp = txt_Barcode.Text;
                txt_Barcode.Clear();

                foreach (var item in codes)
                {
                    if (item.Barcode_Code == temp)
                    {
                        item.Barcode_Count += 1;    // 같다면 카운트
                        return;
                    }
                }

                //  없다면 추가
                codes.Add(new Barcode(temp));
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region erro test 모듈
            //Erro testErro = new Erro(1);
            //MessageBox.Show(testErro.Erro_Code + "\n" + testErro.Head + testErro.Erro_String);
            #endregion

            if (chatting.Start())
                chk_Server.Checked = true;

            toolStripTextBox1.Text = AppConfiguration.GetAppConfig("name");
            toolStripTextBox2.Text = AppConfiguration.GetAppConfig("ip");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------[투입 현황]"+machine.Name);
            sb.AppendLine(NowTime());
            foreach (var item in codes)
            {
                txt_Log.Clear();
                sb.AppendLine("*["+item.Barcode_Code+"]" + "\t" + item.Barcode_Count);
            }
            sb.AppendLine("----------------------------");
            txt_Log.Text = sb.ToString();

            this.txt_Barcode.Focus();
        }

        private string NowTime()
        {
            DateTime dt = DateTime.Now;
            return
                "---------[" + dt.ToShortDateString() + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second + "]";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            chatting.CloseSeverTest();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "화면고정":
                    if (this.TopMost != true)
                        this.TopMost = true;
                    else
                        this.TopMost = false;
                    break;

                case "종료":  this.Close();   break;
                case "재시작":  Application.Restart();   break;
                case "자재투입현황":  button1_Click(null, null);   break;

                default:
                    break;
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {   //name 변경
            if (e.KeyCode == Keys.Enter)
            {
                AppConfiguration.SetAppConfig("name", toolStripTextBox1.Text);
                MessageBox.Show("변경되었습니다.");
            }
        }

        private void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {   //  ip  변경
            if (e.KeyCode == Keys.Enter)
            {
                if (IsValidIp(toolStripTextBox2.Text))
                {
                    AppConfiguration.SetAppConfig("ip", toolStripTextBox2.Text);
                    MessageBox.Show("변경되었습니다.");
                }
                else
                {
                    toolStripTextBox2.Text = AppConfiguration.GetAppConfig("ip");
                    MessageBox.Show("올바른 IP 주소가 아닙니다.");
                    return;
                }
                
            }
        }
        public bool IsValidIp(string addr)
        {
            IPAddress ip;
            bool valid = !string.IsNullOrEmpty(addr) && IPAddress.TryParse(addr, out ip);
            return valid;
        }
    }
}
