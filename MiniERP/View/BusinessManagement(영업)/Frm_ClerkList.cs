using MiniERP.View.StockManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.BusinessManagement_영업_
{
    public partial class Frm_ClerkList : Form
    {
        private bool serchbox = true;
        public Frm_ClerkList()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
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

        private void btn_ClerkInsert_Click(object sender, EventArgs e)
        {
            Frm_ClerkInsert clerkInsert = new Frm_ClerkInsert();
            clerkInsert.ShowDialog();
        }
    }
}
