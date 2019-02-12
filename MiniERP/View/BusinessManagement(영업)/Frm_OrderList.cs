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
    public partial class Frm_OrderList : Form
    {
        private bool boxchk = true;

        public Frm_OrderList()
        {
            InitializeComponent();
        }

        private void Frm_OrderList_Load(object sender, EventArgs e)
        {
            
        }

        private void button9_Click_1(object sender, EventArgs e)
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
            Frm_OrderInsert orderInsert = new Frm_OrderInsert();
            orderInsert.Show();
        }
    }
}
