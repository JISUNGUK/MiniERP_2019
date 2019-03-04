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
    public partial class Machine_Info_Change : Form
    {
        string name;
        string ip;
        Machine_Monitoring server; 

        public Machine_Info_Change(Machine_Monitoring server,string name)
        {
            InitializeComponent();
            this.name = name;
            this.ip = server.Ip;
            this.server = server;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Name.Checked == true)
            {
                txt_Name.Enabled = true;
                txt_Ip.Enabled = false;
            }
            else
            {
                txt_Name.Enabled = false;
                txt_Ip.Enabled = true;
            }
        }

        private void Machine_Info_Change_Load(object sender, EventArgs e)
        {
            txt_Name.Enabled = true;
            txt_Ip.Enabled = false;

            txt_Name.Text = this.name;
            txt_Ip.Text = this.ip;            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string command = "[command]";
            if (radio_Name.Checked == true)
            {
                command += this.name + "[name]" + txt_Name.Text;
                server.SendMsg(command);
            }
            else
            {
                command += this.name + "[ip]" + txt_Ip.Text;
                server.SendMsg(command);
            }

            Close();
        }
    }
}
