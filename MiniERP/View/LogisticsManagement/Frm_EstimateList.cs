using Microsoft.Office.Interop.Excel;
using MiniERP.Model;
using MiniERP.Model.DAO;
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
        private int rowcount;//엑셀을 출력할지를 결정함 0보다 커야 출력
        List<SampleOrder> sampleList = new List<SampleOrder>();      
        public Frm_EstimateList()
        {
            InitializeComponent();
            
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
            DisplayEstimate();

        }

        /// <summary>
        /// 생산계획서의 결과를 데이터그리드뷰에 출력시킴
        /// </summary>
        private void DisplayEstimate()
        {
            rowcount = 0;
            if (orderedCode.Text != "")
            {
                sampleOrder.Rows.Clear();

                foreach (var item in Outputorder())
                {
                    sampleOrder.Rows.Add();
                    sampleOrder.Rows[rowcount].Cells[0].Value = item.item_code;
                    sampleOrder.Rows[rowcount].Cells[1].Value = item.Item_name;
                    sampleOrder.Rows[rowcount].Cells[2].Value = item.Item_count;
                    sampleOrder.Rows[rowcount].Cells[3].Value = item.Item_standard;
                    sampleOrder.Rows[rowcount].Cells[4].Value = item.Item_wrote_fee;
                    sampleOrder.Rows[rowcount].Cells[5].Value = item.Item_unit;
                    rowcount++;
                }
                if (rowcount > 0)
                {
                    MessageBox.Show("찾으시는 결과가 없습니다");
                }

            }
            else
            {
                MessageBox.Show("주문코드를 입력해주세요");
            }
        }

        private void exportExcel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(System.Environment.CurrentDirectory);
            if (rowcount > 0)
            {
                new PrintExcelDAO().outputExcel("견적서",orderedCode.Text, sampleOrder);
               

            }
        }

       
    }
}
