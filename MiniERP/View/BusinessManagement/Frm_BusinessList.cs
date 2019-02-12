using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.BusinessManagement
{
    public partial class Frm_BusinessList : Form
    {
        private bool boxchk = true;

        public Frm_BusinessList()
        {
            InitializeComponent();
        }

        private void btn_BusinessSelect_Click(object sender, EventArgs e)
        {
            Frm_BusinessSelect Frm_businessSelect = new Frm_BusinessSelect();
            Frm_businessSelect.ShowDialog();              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (boxchk)
            {
                pnl_serchbox.Visible = true;
                boxchk = false;
            }
            else
            {
                pnl_serchbox.Visible = false;
                boxchk = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_BusinessInsert businessInsert = new Frm_BusinessInsert();
            businessInsert.Show();
        }
    }
}
