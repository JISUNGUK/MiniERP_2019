﻿using Microsoft.Office.Interop.Excel;
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
    public partial class Frm_ImportList : Form
    {
        MiniErpDB mini = new MiniErpDB();
        private string warehousecode;
        private string warehouseName;
        public Frm_ImportList()
        {
            InitializeComponent();
        }

        private void Frm_ImportList_Load(object sender, EventArgs e)
        {
            importGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            importGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            importGrid.Columns.Add("before_warehouse", "보낸창고");
            importGrid.Columns.Add("item_name", "품목명");
            importGrid.Columns.Add("item_standard", "규격");
            importGrid.Columns.Add("Distribution_count", "수량");            
            
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
            importGrid.Rows.Clear();
            foreach (var item in mini.Get_Import(move_date
                .Value, warehouseCode.Text))

            {

                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(importGrid, item.beforeName, item.item_name, item.item_standard,   item.Distribution_count);
                importGrid.Rows.Add(dr);
                    rowcount++;
            }
            if(rowcount==0)
                    MessageBox.Show("찾으시는 결과가 없습니다");
            }
        else
                MessageBox.Show("창고코드를 입력해주세요");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (importGrid.Rows.Count > 0)
            {

                new PrintExcelDAO().outputExcel("입고 확인서", warehouseName, move_date.Value, importGrid);
              /*  SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "입고 증명서.xls";
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
                        wb = excelApp.Workbooks.Open(System.Environment.CurrentDirectory + "\\resources\\입고 확인서.xlsx");
                        ws = wb.Worksheets.get_Item(1) as Worksheet;

                        // 데이타 넣기

                        ws.Cells[10, 4] = move_date.Value;//string을 날짜형태로 바꿔줌
                        ws.Cells[10, 13] = warehouseName;
                        ws.Cells[10, 19] = DateTime.Now.ToShortDateString();
                        foreach (DataGridViewRow data in importGrid.Rows)
                        {
                            ws.Cells[r, 2] = data.Cells[0].Value;
                            ws.Cells[r, 7] = data.Cells[1].Value;
                            ws.Cells[r, 12] = data.Cells[3].Value;
                            ws.Cells[r, 17] = data.Cells[2].Value;
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
                        MessageBox.Show("엑셀 파일로 모두 출력했습니다");
                    }
                }*/
            }
        }
    }
}
