using MiniERP.Model.DAO.Message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View
{
    public partial class RealTimeMonitor : Form
    {
        Machine_Monitoring machine_Server;

        public RealTimeMonitor()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;                                 //  작업표시줄X
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;   //  프로그램 전환기 숨기기
        }

        private void RealTimeMonitor_Load(object sender, EventArgs e)
        {
            machine_Server = new Machine_Monitoring(txt_Log);
            machine_Server.Start();
            
        }

        private void txt_Log_TextChanged(object sender, EventArgs e)
        {
            txt_Log.SelectionStart = txt_Log.Text.Length;
            richTextBox1.AppendText(txt_Log.Text + Environment.NewLine);

            //ClientConnectingCheck(txt_Log.Text);
        }
        private void ClientConnectingCheck(string msg)
        {
            string temp = "";
            if (msg.Contains("[command]") && msg.Contains("is connecting"))
                temp = msg.Replace("[command]", "").Replace("is connecting", "");    //[pc1]

            
            foreach (Control item in panel1.Controls)
            {
                if (item.Text == temp) 
                {
                    ((CheckBox)item).Checked = true;
                }
            }
            
        }

        private void RealTimeMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            machine_Server.CloseSever();
        }

        private void btn_inputCountRequest_Click(object sender, EventArgs e)
        {
            string command = "[command]";
            switch (((Button)sender).Text)
            {
                case "종료": command += selectPc + "exit"; machine_Server.SendMsg(command); break;
                case "재부팅": command += selectPc + "restart"; machine_Server.SendMsg(command); break;
                case "투입 자재 개수": command += selectPc + "barcode"; machine_Server.SendMsg(command); break;
                case "머신 설정 변경": Machine_Info_Change change = new Machine_Info_Change(machine_Server, selectPc); change.ShowDialog(); break;                    
                default:
                    break;
            }
        }

        string selectPc = ""; bool clickSwitch = false;
        private void pic_pc1_MouseClick(object sender, MouseEventArgs e)
        {           
            if (e.Button == MouseButtons.Left && clickSwitch == false)
            {
                if (((PictureBox)sender).BackColor != SystemColors.ButtonShadow)
                {
                    ((PictureBox)sender).BackColor = SystemColors.ButtonShadow;
                    selectPc = "[" + ((PictureBox)sender).Name + "]";
                }
                clickSwitch = true;
            }

            else if (((PictureBox)sender).BackColor == SystemColors.ButtonShadow && clickSwitch == true)
            {
                clickSwitch = false;
                if (((PictureBox)sender).BackColor == SystemColors.ButtonShadow)
                {
                    ((PictureBox)sender).BackColor = SystemColors.ButtonHighlight;
                }
            }
            else
                MessageBox.Show("한번에 하나의 명령만 가능합니다.");
        }

        /// <summary>
        /// 리치텍스트박스 변경시 일어날 메소드
        /// </summary>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
         {
            ServerStateChecker();
        }
        /// <summary>
        /// 텍스트박스의 서버의 커맨드를 이용해 체크박스 체크해줍니다.
        /// </summary>
        private void ServerStateChecker()
        {
            string temp = txt_Log.Text;
            if (temp.Contains("[command]") && temp.Contains("is connecting"))
            {
                temp = temp.Replace("[command]", "").Replace("is connecting", "");
                foreach (Control item in panel1.Controls)
                {
                    if (item.Text == temp)
                    {
                        ((CheckBox)item).Checked = true;                        
                    }
                }
            }

            else if (temp.Contains("[command]") && temp.Contains("is endconnecting"))
            {
                temp = temp.Replace("[command]", "").Replace("is endconnecting", "");
                foreach (Control item in panel1.Controls)
                {
                    if (item.Text == temp)
                    {
                        ((CheckBox)item).Checked = false;
                    }
                }
            }
        }
        /// <summary>
        /// 텍스트박스의 서버 상태를 체크하고, 버튼의 enable속성을 변경해줍니다.
        /// </summary>
        private void check_pc1_CheckedChanged(object sender, EventArgs e)
        {
            string temp = ((Control)sender).Text;                       //  [pc1]
            temp = temp.Replace("[", "").Replace("]", "");              //  pc1

            foreach (Control item in panel1.Controls)
            {
                if (item.Name == temp&&((CheckBox)sender).Checked)
                    ((PictureBox)item).Enabled = Enabled;
                
                else if (item.Name == temp && !((CheckBox)sender).Checked)
                    ((PictureBox)item).Enabled = false;
            }
        }

        //  테스트 위한 메서드
        private void btn_Tester_Click(object sender, EventArgs e)
        {
            pc1.Enabled = true;
            pc2.Enabled = true;
            pc3.Enabled = true;
            pc4.Enabled = true;
            pc5.Enabled = true;
        }
    }
}
