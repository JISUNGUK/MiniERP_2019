using MiniERP.Model;
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
    public partial class Frm_EstimateInsert : Form
    {
        public Frm_EstimateInsert()
        {
            InitializeComponent();
        }

        private void btn_ItemSelect_Click(object sender, EventArgs e)
        {
            Frm_ItemSelect itemSelect = new Frm_ItemSelect();
            itemSelect.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_BusinessSelect businessSelect = new Frm_BusinessSelect();
            businessSelect.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiniErpDB minierp = new MiniErpDB();
           // minierp.GET_ORDER("");
        }
    }
}
