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
    public partial class Frm_EstimateList : Form
    {
        public Frm_EstimateList()
        {
            InitializeComponent();
        }

        private void btn_BusinessSelect_Click(object sender, EventArgs e)
        {
            Frm_BusinessSelect businessSelect = new Frm_BusinessSelect();
            businessSelect.ShowDialog();
        }

        private void btn_WarehouseSelect_Click(object sender, EventArgs e)
        {
            Frm_WarehouseSelect warehouseSelect = new Frm_WarehouseSelect();
            warehouseSelect.ShowDialog();
        }

        private void btn_EstimateSelect_Click(object sender, EventArgs e)
        {
            Frm_EstimateSelect estimateSelect = new Frm_EstimateSelect();
            estimateSelect.ShowDialog();
        }

        private void btn_ItemSelect_Click(object sender, EventArgs e)
        {
            Frm_ItemSelect itemSelect = new Frm_ItemSelect();
            itemSelect.ShowDialog();
        }

        private void btn_ClerkSelect_Click(object sender, EventArgs e)
        {
            Frm_ClerkSelect clerkSelect = new Frm_ClerkSelect();
            clerkSelect.ShowDialog();
        }
    }
}
