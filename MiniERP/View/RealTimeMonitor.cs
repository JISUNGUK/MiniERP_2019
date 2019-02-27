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
        }

        private void RealTimeMonitor_Load(object sender, EventArgs e)
        {
            //  채팅에서 받는 서버 연결 확인 후 콤보박스 불들어 와줘야함

            machine_Server = new Machine_Monitoring(txt_Log,panel1);
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
            MessageBox.Show(((Button)sender).Text);
            switch (((Button)sender).Text)
            {
                case "종료": command += selectPc + "exit"; MessageBox.Show(command); machine_Server.SendMsg(command); break;
                case "재부팅": command += selectPc + "restart"; machine_Server.SendMsg(command); break;
                case "투입 자재 개수": command += selectPc + "barcode"; machine_Server.SendMsg(command); break;
                case "테스트": machine_Server.SendMsg("테스트메시지");   break;
                default:
                    break;
            }
        }

        string selectPc = "";
        private void pic_pc1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (((PictureBox)sender).BackColor != Color.Black)
                {
                    ((PictureBox)sender).BackColor = Color.Black;
                    selectPc = "[" + ((PictureBox)sender).Name + "]";
                }
                else if (((PictureBox)sender).BackColor == Color.Black)
                {
                    ((PictureBox)sender).BackColor = Color.White;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            int line = richTextBox1.Lines.Length;
            MessageBox.Show(richTextBox1.Text[line].ToString());
            
        }
    }
}
