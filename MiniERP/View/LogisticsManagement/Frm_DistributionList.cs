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
    public partial class Frm_DistributionList : Form
    {
        public Frm_DistributionList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 품목번호를 선택해서 갖고옴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemBtn_Click(object sender, EventArgs e)
        {
            Frm_ItemSelect item = new Frm_ItemSelect();
            if (item.ShowDialog() == DialogResult.OK)
               itemCode.Text = item.SelectItem.Item_code;

        }

        /// <summary>
        /// 출발 창고를 선택해서 갖고옴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwButton_Click(object sender, EventArgs e)
        {
            Frm_WarehouseSelect warehouse = new Frm_WarehouseSelect();
            if (warehouse.ShowDialog() == DialogResult.OK)
                beforeWarehouse.Text = warehouse.Warehouse.Warehouse_code;
        }

        /// <summary>
        /// 도착 창고를 갖고옴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void awButton_Click(object sender, EventArgs e)
        {
            Frm_WarehouseSelect warehouse = new Frm_WarehouseSelect();
            if (warehouse.ShowDialog() == DialogResult.OK)
               afterWarehouse.Text = warehouse.Warehouse.Warehouse_code;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
