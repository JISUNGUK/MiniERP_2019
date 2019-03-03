using Microsoft.Office.Interop.Excel;
using MiniERP.Model;
using MiniERP.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.LogisticsManagement
{
    public partial class Frm_ExportList : Form
    {
        MiniErpDB mini = new MiniErpDB();
        private string warehousecode;//창고 번호
        private string warehouseName;//검색하는 창고이름
        public Frm_ExportList()
        {
            InitializeComponent();
            
        }

       
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void warehouseBtn_Click(object sender, EventArgs e)
        {
            Frm_WarehouseSelect warehouse = new Frm_WarehouseSelect();
            if (warehouse.ShowDialog() == DialogResult.OK)
            { 
               warehouseCode.Text = warehouse.Warehouse.Warehouse_code;
                warehouseName = warehouse.Warehouse.Warehouse_name;
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
        if(warehouseCode.Text!="")
            { 
            int rowcount = 0;
            warehousecode = warehouseCode.Text;
            exportGrid.Rows.Clear();
            foreach (var item in mini.Get_Export(move_date
                .Value,warehouseCode.Text))

            {
               
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(exportGrid, item.afterName, item.item_name, item.Distribution_count,  item.item_standard);
                exportGrid.Rows.Add(dr);
                rowcount++;
            } 
            if(rowcount==0)
                MessageBox.Show("찾으시는 결과가 없습니다");
            }
        else
                MessageBox.Show("창고 코드를 입력해주세요");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (exportGrid.Rows.Count > 0)
            {
                new PrintExcelDAO().outputExcel("출하 증명서", warehouseName, move_date.Value, exportGrid);


            }
        }

        private void Frm_ExportList_Load(object sender, EventArgs e)
        {            
            exportGrid.Columns.Add("after_warehouse", "도착창고");            
            exportGrid.Columns.Add("item_name", "품목명");
            exportGrid.Columns.Add("Distribution_count", "수량");
            exportGrid.Columns.Add("item_standard", "규격");
        }
    }
}
