using MiniERP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.Runtime.InteropServices;



//using Excel = Microsoft.Office.Interop.Excel;



namespace MiniERP.View.LogisticsManagement
{
    public partial class Frm_productionList : Form
    {
        private string order_code = "";
        private MiniERP.VO.Item item = new VO.Item();
        private int rowcount = 0;//생산계획이 하나라도 있는지 확인
        MiniErpDB miniErp = new MiniErpDB();       

        public Frm_productionList()
        {
            InitializeComponent();
            produceGrid.Columns.Add("item_code","품목코드");
            produceGrid.Columns.Add("item_name", "품목명");
            produceGrid.Columns.Add("item_standard", "품목규격");
            produceGrid.Columns.Add("M", "수량");

        }

        

        

        private void searchPlan_Click(object sender, EventArgs e)
        {
            rowcount = 0;
            int i = 0;
            produceGrid.DataSource = null;
            foreach (var item in miniErp.GET_MANUFACTURE_PLAN(ordercode.Text))
            { 
                
                produceGrid.Rows[i].Cells[0].Value = item.Item_code;
                produceGrid.Rows[i].Cells[1].Value = item.Item_name;
                produceGrid.Rows[i].Cells[2].Value = item.Item_standard                    ;
                produceGrid.Rows[i].Cells[3].Value = item.M;
                rowcount++;
                i++;
            }

        }

        private void exportExcel_Click(object sender, EventArgs e)
        {
           
            if (rowcount>0)
            {
                DateTime dt = DateTime.Now;
                SaveFileDialog savefile = new SaveFileDialog();
          DialogResult dr=savefile.ShowDialog();
          savefile.FileName = dt.Day+""+dt.Hour+""+dt.Minute+ "생산계획서.xls";
                if (dr==DialogResult.OK)
                {
                    Application excelApp = null;
                    Workbook wb = null;
                    Worksheet ws = null;
                    
                                        try
                                        {
                                            // Excel 첫번째 워크시트 가져오기                
                                            excelApp = new Application();
                        MessageBox.Show(System.Environment.CurrentDirectory);
                        wb = excelApp.Workbooks.Add(Properties.Resources.생산_계획서);
                                            ws = wb.Worksheets.get_Item(1) as Worksheet;

                                            // 데이타 넣기
                                            int r = 13;
                        ws.Cells[10, 4] = order_code.Remove(order_code.IndexOf("_"));
                        ws.Cells[10, 19] = order_code;
                        foreach (DataGridViewRow data in produceGrid.Rows)
                        {
                            ws.Cells[r, 2] = data.Cells[0].Value;
                            ws.Cells[r, 6] = data.Cells[1].Value;
                            ws.Cells[r, 14] = data.Cells[2].Value;
                            ws.Cells[r, 20] = data.Cells[3].Value;
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

        private void Frm_productionList_Resize(object sender, EventArgs e)
        {
            /*
            orderSearch.Location = new System.Drawing.Point(ordercode.Width + ordercode.Location.X + 5, ordercode.Location.Y);          
            label1.Location = new System.Drawing.Point(label5.Location.X, label5.Location.Y + label5.Height * 3);
            itemcode.Location = new System.Drawing.Point(ordercode.Location.X, label1.Location.Y);
            label8.Location = new System.Drawing.Point(searchPlan.Location.X, label1.Location.Y);
            itemSearch.Location = new System.Drawing.Point(orderSearch.Location.X, label1.Location.Y);
            itemcount.Location = new System.Drawing.Point(searchPlan.Location.X + searchPlan.Width, label8.Location.Y);
            */
            
        }

        private void Frm_productionList_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void orderSearch_Click(object sender, EventArgs e)
        {
            Frm_OrderSelect fis = new Frm_OrderSelect();
            if (fis.ShowDialog() == DialogResult.OK)
            {
                if(fis.SelectOrder.Order_Code!=null)
                    ordercode.Text = fis.SelectOrder.Order_Code;
            }

        }

        private void itemSearch_Click(object sender, EventArgs e)
        {
            Frm_ItemSelect fis = new Frm_ItemSelect();
            if (fis.ShowDialog() == DialogResult.OK)
            {
                if (fis.SelectItem.Item_code != null)
                    itemcode.Text = fis.SelectItem.Item_code;
            }
        }

       

      
    }
}
