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
        public Frm_OrderList()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_OrderInsert orderInsert = new Frm_OrderInsert();
            orderInsert.ShowDialog();
        }

        private void Frm_OrderList_Load(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Frm_BusinessSelect businessSelect = new Frm_BusinessSelect();
            businessSelect.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Frm_EstimateSelect estimateSelec = new Frm_EstimateSelect();
            estimateSelec.ShowDialog();
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

        private void btn_EstimateSelect_Click(object sender, EventArgs e)
        {
            Frm_EstimateSelect estimateSelec = new Frm_EstimateSelect();
            estimateSelec.ShowDialog();
        }

        private void btn_WarehouseSelect_Click(object sender, EventArgs e)
        {
            Frm_WarehouseSelect warehouseSelect = new Frm_WarehouseSelect();
            warehouseSelect.ShowDialog();
        }
    }
}
