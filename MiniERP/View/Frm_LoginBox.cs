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
    public partial class Frm_LoginBox : Form
    {
        public Frm_LoginBox()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_LoginBox_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
