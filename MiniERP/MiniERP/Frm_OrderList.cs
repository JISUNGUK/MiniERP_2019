using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class Frm_OrderList : Form
    {
        public Frm_OrderList()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_OrderInsert orderInsert = new Frm_OrderInsert();
            orderInsert.Show();
        }

        private void Frm_OrderList_Load(object sender, EventArgs e)
        {

        }
    }
}
