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
    public partial class Frm_ImportList : Form
    {
        public Frm_ImportList()
        {
            InitializeComponent();
        }

        private void Frm_ImportList_Load(object sender, EventArgs e)
        {
            importGrid.Columns.Add("before_warehouse", "출발창고");
            importGrid.Columns.Add("Distribution_count", "수량");
            importGrid.Columns.Add("item_name", "품목명");
            importGrid.Columns.Add("item_standard", "품목규격");
        }

        private void exportExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void warehouseBtn_Click(object sender, EventArgs e)
        {

        }

        private void warehouseBtn_Click_1(object sender, EventArgs e)
        {
            Frm_WarehouseSelect warehouse = new Frm_WarehouseSelect();
            if (warehouse.ShowDialog() == DialogResult.OK)
                warehouseCode.Text = warehouse.Warehouse.Warehouse_code;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
