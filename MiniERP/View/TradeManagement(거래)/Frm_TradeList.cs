using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.TradeManagement_거래_
{
    public partial class Frm_TradeList : Form
    {
        private bool serchbox;

        public Frm_TradeList()
        {
            InitializeComponent();
        }

        private void pnl_serchbox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serchbox)
            {
                pnl_serchbox.Visible = true;
                serchbox = false;
            }
            else
            {
                pnl_serchbox.Visible = false;
                serchbox = true;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
