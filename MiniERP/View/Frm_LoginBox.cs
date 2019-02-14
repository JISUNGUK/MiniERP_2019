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
        int test2 = 0;
        private Form1 form1;

        public Frm_LoginBox(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("로그인성공");
                form1.logIn = DialogResult.OK;
            }
            this.Close();
        }

        private void Frm_LoginBox_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
