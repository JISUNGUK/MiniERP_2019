using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.LogisticsManagement
{
    public partial class Frm_EstimateList : Form
    {
        private bool chkbox = false;
        public Frm_EstimateList()
        {
            InitializeComponent();
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            if (chkbox)
            {
                pnl_serchbox.Visible = true;
                chkbox = false; 
            }
            else
            {
                pnl_serchbox.Visible = false;
                chkbox = true;
            }
        }
    }
}
