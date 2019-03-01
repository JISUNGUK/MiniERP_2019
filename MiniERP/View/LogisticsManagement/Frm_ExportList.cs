using Microsoft.Office.Interop.Excel;
using MiniERP.Model;
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
        private string warehousecode;
        public Frm_ExportList()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void warehouseBtn_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ExportList_Resize(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void warehouseBtn_Click_1(object sender, EventArgs e)
        {
            Frm_WarehouseSelect warehouse = new Frm_WarehouseSelect();
            if (warehouse.ShowDialog() == DialogResult.OK)
               warehouseCode.Text = warehouse.Warehouse.Warehouse_code;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            warehousecode = warehouseCode.Text;
            exportGrid.Rows.Clear();
            foreach (var item in mini.Get_Export(move_date
                .Value,warehouseCode.Text))

            {
               
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(exportGrid, item.before_warehouse, item.Distribution_count, item.item_name, item.item_standard);
                exportGrid.Rows.Add(dr);
            } 
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            if (exportGrid.Rows.Count > 0)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "출하 증명서.xls";
                DialogResult dr = savefile.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application excelApp = null;
                    Workbook wb = null;
                    Worksheet ws = null;

                    try
                    {
                        int r = 13;//열번호
                        // Excel 첫번째 워크시트 가져오기                
                        excelApp = new Microsoft.Office.Interop.Excel.Application();
                        wb = excelApp.Workbooks.Open(System.Environment.CurrentDirectory + "\\resources\\출하 증명서.xlsx");
                        ws = wb.Worksheets.get_Item(1) as Worksheet;

                        // 데이타 넣기

                        ws.Cells[10, 4] = DateTime.ParseExact(warehouseCode.Text.Remove(warehouseCode.Text.IndexOf("_")), "yyyyMMdd", null);//string을 날짜형태로 바꿔줌
                        ws.Cells[10, 19] = warehousecode;
                        foreach (DataGridViewRow data in exportGrid.Rows)
                        {
                            ws.Cells[r, 2] = data.Cells[1].Value;
                            ws.Cells[r, 8] = data.Cells[0].Value;
                            ws.Cells[r, 14] = data.Cells[5].Value;
                            ws.Cells[r, 20] = data.Cells[2].Value;
                            r++;
                        }

                        // 엑셀파일 저장
                        wb.SaveAs(savefile.FileName, XlFileFormat.xlWorkbookNormal);
                        wb.Close(true);
                        excelApp.Quit();
                    }
                    finally
                    {
                        // Clean up
                        Marshal.ReleaseComObject(ws);
                        Marshal.ReleaseComObject(wb);
                        Marshal.ReleaseComObject(excelApp);
                    }
                }


            }
        }

        private void Frm_ExportList_Load(object sender, EventArgs e)
        {
            exportGrid.Columns.Add("after_warehouse", "도착창고");
            exportGrid.Columns.Add("Distribution_count", "수량");
            exportGrid.Columns.Add("item_name", "품목명");
            exportGrid.Columns.Add("item_standard", "품목규격");
        }
    }
}
