using MiniERP.View.LogisticsManagement;
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
    public partial class Frm_BomList : Form
    {
        private bool boxchk = true;

        public Frm_BomList()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
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
            Frm_BomInesrt bomInesrt = new Frm_BomInesrt();
            bomInesrt.Show();
        }

        private void Frm_BomList_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
        }
    }
}
