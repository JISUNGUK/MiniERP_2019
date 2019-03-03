using MiniERP.Model;
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

namespace MiniERP.View.LogisticsManagement
{
    public partial class Frm_DistributionList : Form
    {
        MiniErpDB minierp = new MiniErpDB();
        private string status = "";//물류조회할때 쓰는 상태
        public Frm_DistributionList()
        {
            InitializeComponent();
            distributionGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            distributionGrid.Columns.Add("Distribution_code", "물류코드");
            distributionGrid.Columns.Add("Before_warehouse", "출발창고");
            distributionGrid.Columns.Add("After_warehouse", "도착창고");
            distributionGrid.Columns.Add("Item_name", "품목명");
            distributionGrid.Columns.Add("Distribution_count", "물류갯수");
            distributionGrid.Columns.Add("Distribution_status","물류상태");
            

        }
        /// <summary>
        /// 품목번호를 선택해서 갖고옴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
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
            int i = 0;
            distributionGrid.Rows.Clear();
            foreach (var item in minierp.GET_DISTRIBUTION(lowdate.Value,highdate.Value,beforeWarehouse.Text,afterWarehouse.Text,itemCode.Text,status,1,500))
            {
                distributionGrid.Rows.Add();
                distributionGrid.Rows[i].Cells["Distribution_code"].Value=item.Distribution_code;
                distributionGrid.Rows[i].Cells["Before_warehouse"].Value = item.Before_warehouse;
                distributionGrid.Rows[i].Cells["After_warehouse"].Value = item.After_warehouse;
                distributionGrid.Rows[i].Cells["Distribution_count"].Value = item.Distribution_count;
                distributionGrid.Rows[i].Cells["Distribution_status"].Value = item.Distribution_status;
                distributionGrid.Rows[i].Cells["Item_name"].Value = item.Item_name;

                i++;
            }
            if (i == 0) { 
                MessageBox.Show("찾으시는 물류 데이터가 없습니다");
                distributionGrid.Rows.Clear();
            }
        }

        private void waitRdo_CheckedChanged(object sender, EventArgs e)
        {
            if(waitRdo.Checked)
            {
                status = "대기";
            }
        }

        private void cancelRdo_CheckedChanged(object sender, EventArgs e)
        {
            if (cancelRdo.Checked)
                status = "취소";
        }

        private void exportRdo_CheckedChanged(object sender, EventArgs e)
        {
            if (exportRdo.Checked)
                status = "출고";
        }

        private void completeRdo_CheckedChanged(object sender, EventArgs e)
        {
            if (completeRdo.Checked)
                status = "완료";

        }

        private void Frm_DistributionList_Load(object sender, EventArgs e)
        {
            distributionGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            distributionGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Frm_WarehouseMovement frm = new Frm_WarehouseMovement();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                // 재 조회? 아니면 뭘넣을까?
            }
        }
    }
}
