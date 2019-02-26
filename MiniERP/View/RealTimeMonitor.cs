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

            machine_Server = new Machine_Monitoring(txt_Log);
            machine_Server.Start();
        }

        private void txt_Log_TextChanged(object sender, EventArgs e)
        {
            txt_Log.SelectionStart = txt_Log.Text.Length;

            richTextBox1.AppendText(txt_Log.Text + Environment.NewLine);
            //MessageBox.Show(txt_Log.Text);

            
            //MessageBox.Show(txt_Log.Lines.Max<>);
            //if (txt_Log.Lines.Max)
            //{

            //}
        }

        private void RealTimeMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            machine_Server.CloseSever();
        }
    }
}
