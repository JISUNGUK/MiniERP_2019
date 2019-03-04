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
using MiniERP.Model.DAO;



//using Excel = Microsoft.Office.Interop.Excel;



namespace MiniERP.View.LogisticsManagement
{
    public partial class Frm_productionList : Form
    {
        private string order_code = "";
        MiniErpDB miniErp = new MiniErpDB();

        public Frm_productionList()
        {
            InitializeComponent();
            produceGrid.Columns.Add("item_code", "품목코드");
            produceGrid.Columns.Add("item_name", "품목명");
            produceGrid.Columns.Add("item_standard", "품목규격");
            produceGrid.Columns.Add("M", "수량");
            produceGrid.Columns.Add("Item_wrote_fee", "단가");

        }





        private void searchPlan_Click(object sender, EventArgs e)
        {
            DisplayProduction();

        }
        /// <summary>
        /// 생산계획 결과를 입력받아 데이터그리드뷰에 내용을 출력
        /// </summary>
        private void DisplayProduction()
        {
            int i = 0;
            if (ordercode.Text != "")
            {

                produceGrid.Rows.Clear();
                foreach (var item in miniErp.GET_MANUFACTURE_PLAN(ordercode.Text))
                {
                    order_code = ordercode.Text;
                    produceGrid.Rows.Add();
                    produceGrid.Rows[i].Cells[0].Value = item.Item_code;
                    produceGrid.Rows[i].Cells[1].Value = item.Item_name;
                    produceGrid.Rows[i].Cells[2].Value = item.Item_standard;
                    produceGrid.Rows[i].Cells[3].Value = item.M;
                    produceGrid.Rows[i].Cells[4].Value = item.Item_wrote_fee;
                    i++;
                }
                if (i == 0)
                    MessageBox.Show("찾으시는 주문에 대한 생산계획이 없습니다");
            }
            else
                MessageBox.Show("주문코드를 입력해주세요");
        }

        private void exportExcel_Click(object sender, EventArgs e)
        {

            if (produceGrid.Rows.Count > 0)
            {
                new PrintExcelDAO().outputExcel("생산 계획서", order_code, produceGrid);              
            }
        }

        

        private void orderSearch_Click(object sender, EventArgs e)
        {
            Frm_OrderSelect order = new Frm_OrderSelect();
            if (order.ShowDialog() == DialogResult.OK)
            {
                ordercode.Text = order.SelectOrder.Order_Code;
            }
        }

        private void produceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}