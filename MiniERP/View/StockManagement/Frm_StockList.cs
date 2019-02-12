using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.StockManagement
{
    public partial class Frm_StockList : Form
    {
        private bool boxchk = true;
        public Frm_StockList()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_serch_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_StockInsert stockInsert = new Frm_StockInsert();
            stockInsert.Show();
        }
    }
}
