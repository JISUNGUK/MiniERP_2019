using Microsoft.Office.Interop.Excel;
using MiniERP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.Model.DAO
{
    class PrintExcelDAO
    {
        public PrintExcelDAO()
        {

        }
        /// <summary>
        /// 견적서와 생산계획서를 뽑는 문서
        /// </summary>
        /// <param name="outputFileName"></param>
        /// <param name="orderCode"></param>
        /// <param name="dv"></param>
        public void outputExcel(string outputFileName,string orderCode,DataGridView dv)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = outputFileName;
            DialogResult dr = savefile.ShowDialog();            
            if (dr == DialogResult.OK)
            {                
                Microsoft.Office.Interop.Excel.Application excelApp = null;
                Workbook wb = null;
                Worksheet ws = null;

                try
                {
                    // Excel 첫번째 워크시트 가져오기                
                    excelApp = new Microsoft.Office.Interop.Excel.Application();
                    wb = excelApp.Workbooks.Open(System.Environment.CurrentDirectory + "\\resources\\" + outputFileName);
                    ws = wb.Worksheets.get_Item(1) as Worksheet;

                    // 데이타 넣기
                    int r = 13;
                    ws.Cells[10, 4] = DateTime.ParseExact(orderCode.Remove(orderCode.IndexOf("_")), "yyyyMMdd", null);//string을 날짜형
                    ws.Cells[10, 19] = orderCode;                  
                    foreach (DataGridViewRow data in dv.Rows)
                    {
                        ws.Cells[r, 2] = data.Cells[0].Value;                       
                        ws.Cells[r, 6] = data.Cells[1].Value;
                        ws.Cells[r, 11] = data.Cells[2].Value;
                        ws.Cells[r, 14] = data.Cells[3].Value;
                        if(outputFileName == "생산 계획서"|| outputFileName == "납품 요청서")
                        { 
                            ws.Cells[r,17]= data.Cells[4].Value;
                            ws.Cells[r, 20] = Int32.Parse(data.Cells[3].Value.ToString()) * Int32.Parse(data.Cells[4].Value.ToString());
                        }
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
        /// <summary>
        /// 문서에 창고가 포함되어있는 산출물
        /// </summary>
        /// <param name="outputFileName">출력할 산출물 이름 excel폴더에 있는 파일들과 이름이 똑같아야한다</param>
        /// <param name="orderCode">주문코드</param>
        /// <param name="warehouse">창고코드</param>
        /// <param name = "move_date">언제 이동했는지</param>
        /// <param name="dv">자신이 엑셀로 뽑을 데이터그리드뷰</param>
        public void outputExcel(string outputFileName, string warehouse,DateTime move_date, DataGridView dv)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = outputFileName;
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
                    wb = excelApp.Workbooks.Open(System.Environment.CurrentDirectory + "\\resources\\"+outputFileName);
                    ws = wb.Worksheets.get_Item(1) as Worksheet;

                    // 데이타 넣기

                    ws.Cells[10, 4] = move_date;//string을 날짜형태로 바꿔줌
                    ws.Cells[10, 13] = warehouse;
                    ws.Cells[10, 19] = DateTime.Now;
                    foreach (DataGridViewRow data in dv.Rows)
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
            }

        }

    }
}
