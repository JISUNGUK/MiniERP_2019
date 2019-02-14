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
    public partial class FrmDashBoard : Form
    {
        private bool menu_OpenChk = false;
        public FrmDashBoard()
        {
            InitializeComponent();
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;
        }

        private void Hide_btn(object sender, EventArgs e)
        {
            if (menu_OpenChk)
            {
                split.Panel1Collapsed = false;
                menu_OpenChk = false;
                btn_hideR.Visible = false;
            }
            else
            {
                split.Panel1Collapsed = true;
                menu_OpenChk = true;
                btn_hideR.Visible = true;
            }
        }
    }
}
