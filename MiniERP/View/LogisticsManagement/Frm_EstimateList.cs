﻿using Microsoft.Office.Interop.Excel;
using MiniERP.Model;
using MiniERP.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.LogisticsManagement
{
    public partial class Frm_EstimateList : Form
    {
        //private bool chkbox = false;
        MiniErpDB erpdb = new MiniErpDB();
        string orderCode = "";
        private int rowcount;//엑셀을 출력할지를 결정함 0보다 커야 출력
        List<SampleOrder> sampleList = new List<SampleOrder>();      
        public Frm_EstimateList()
        {
            InitializeComponent();
        }

        



        private void button8_Click(object sender, EventArgs e)
        {
            if (orderedCode.Text != "")
            {
                sampleList.Clear();
               
                foreach (var item in Outputorder())
                {
                    SampleOrder so = new SampleOrder();
                    orderCode = orderedCode.Text;
                    so.Item_Code = item.item_code;
                    so.Item_Count = item.Item_count;
                    so.Item_Name = item.Item_name;
                    so.Item_Wrote_Fee = item.Item_wrote_fee;
                    so.Item_unit = item.Item_unit;
                    so.Item_standard = item.Item_standard;
                    sampleList.Add(so);
                }
                sampleOrder.DataSource = sampleList;
                sampleOrder.Columns.RemoveAt(0);
                sampleOrder.Columns[0].HeaderText = "품목코드";
                sampleOrder.Columns[1].HeaderText = "품목이름";
                sampleOrder.Columns[2].HeaderText = "품목수량";
                sampleOrder.Columns[3].HeaderText = "단가";
                sampleOrder.Columns[4].HeaderText = "단위";
                sampleOrder.Columns[5].HeaderText = "규격";
            }
            else
            {
                MessageBox.Show("주문코드를 입력해주세요");
            }

        }

        /// <summary>
        /// 저장프로시저를 실행시킨후 폼에서 넣은 조건들과 일치하는 결과들을 컬렉션으로 반환
        /// 
        /// </summary>
        /// <returns></returns>
        private IEnumerable<GET_ORDERResult> Outputorder()
            {
            bool condition=true;


          

            //폼의 컨트롤들의 상태를 보고 컨트롤들에 유효 값이 있을시 조건에 추가
            var result = from im in erpdb.GET_ORDER(orderedCode.Text)
                         where condition
                         select im;

            return result;

            }

       

       

        

       
        private void Frm_EstimateList_Resize(object sender, EventArgs e)
        {
           // button4.Location = new System.Drawing.Point(btn_search.Location.X + btn_search.Width + 5, btn_search.Location.Y);
        }

        

        private void orderBtn_Click_1(object sender, EventArgs e)
        {
            Frm_OrderSelect order = new Frm_OrderSelect();
            if(order.ShowDialog() == DialogResult.OK)
            {
                    orderedCode.Text = order.SelectOrder.Order_Code;
            }

           

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            rowcount = 0;
            if (orderedCode.Text != "")
            {
                sampleOrder.DataSource = null;
                sampleList.Clear();

                foreach (var item in Outputorder())
                {
                    SampleOrder so = new SampleOrder();
                    orderCode = orderedCode.Text;
                    so.Item_Code = item.item_code;
                    so.Item_Count = item.Item_count;
                    so.Item_Name = item.Item_name;
                    so.Item_Wrote_Fee = item.Item_wrote_fee;
                    so.Item_unit = item.Item_unit;
                    so.Item_standard = item.Item_standard;
                    sampleList.Add(so);
                }
                sampleOrder.DataSource = sampleList;
                sampleOrder.Columns.RemoveAt(0);
                sampleOrder.Columns[0].HeaderText = "품목이름";
                sampleOrder.Columns[1].HeaderText = "품목코드";
                sampleOrder.Columns[2].HeaderText = "품목수량";
                sampleOrder.Columns[3].HeaderText = "단가";
                sampleOrder.Columns[4].HeaderText = "단위";
                sampleOrder.Columns[5].HeaderText = "규격";
            }
            else
            {
                MessageBox.Show("주문코드를 입력해주세요");
            }
        }

        private void exportExcel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(System.Environment.CurrentDirectory);
            if (sampleOrder.Rows.Count > 0)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "견적서.xls";
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
                        wb = excelApp.Workbooks.Open(System.Environment.CurrentDirectory+"\\resources\\견적서.xlsx");
                        ws = wb.Worksheets.get_Item(1) as Worksheet;

                        // 데이타 넣기
                       
                        ws.Cells[10, 4] = DateTime.ParseExact(orderCode.Remove(orderCode.IndexOf("_")), "yyyyMMdd", null);//string을 날짜형태로 바꿔줌
                        ws.Cells[10, 19] = orderCode;
                        foreach (DataGridViewRow data in sampleOrder.Rows)
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
                        MessageBox.Show("엑셀 파일로 모두 출력했습니다");
                    }
                }


            }
        }
    }
}
