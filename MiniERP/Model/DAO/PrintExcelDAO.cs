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
        /// 데이터 그리드뷰의 내용을 엑셀로 출력시킴 ex)견적서와 생산계획서가 가능함
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
        /// 문서에 창고가 포함되어있는 데이터 그리드뷰를 엑셀로 출력,ex)입고 확인서,출고 확인서
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
        /// <summary>
        /// 프로시저내용과 데이터그리드뷰에 있는 내용을 엑셀문으로 출력
        /// </summary>
        /// <param name="outputFileName">출력할 산출물 이름 excel폴더에 있는 파일들과 이름이 똑같아야한다</param>
        /// <param name="orderCode">주문코드</param>
        /// <param name="warehouse">창고코드</param>
        /// <param name = "move_date">언제 이동했는지</param>
        /// <param name="dv">자신이 엑셀로 뽑을 데이터그리드뷰</param>
        public void outputExcel(string outputFileName,string ordercode,Business business,DataGridViewRow row)
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
                    ws.Cells[11, 4] = DateTime.ParseExact(ordercode.Remove(ordercode.IndexOf("_")), "yyyyMMdd", null);//string을 날짜형
                    ws.Cells[11, 31] = ordercode;//주문번호입력


                   
                    ws.Cells[14, 2] = row.Cells[7].Value;
                    ws.Cells[14, 7] = business.Name;
                    ws.Cells[14, 12] = business.Presenter;
                    ws.Cells[14, 17] = business.Tel;
                    ws.Cells[14, 26] = business.Addr;
                    int r = 20;//열번호
                    foreach (var data in new MiniErpDB().PROC_STATEMENT(ordercode))
                    {
                        ws.Cells[r, 2] = data.Item_code;
                        ws.Cells[r, 7] = data.Item_name;
                        ws.Cells[r, 12] = data.Item_standard;
                        ws.Cells[r, 17] = data.Item_count;
                        ws.Cells[r, 23] = data.Item_wrote_fee;
                        ws.Cells[r, 29] = data.Item_count * data.Item_wrote_fee;
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
