using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.VO;
using MiniERP.View;

namespace MiniERP
{
    public partial class ToDoList_Detail : UserControl
    {
        private Trade trade;
        Panel detail_Panel;
        private FrmDashBoard frmDashBoard;

        //  진짜
        public ToDoList_Detail(Trade trade, Panel detail_Panel, FrmDashBoard frmDashBoard)
        {
            InitializeComponent();
            this.trade = trade;
            this.detail_Panel = detail_Panel;
            this.frmDashBoard = frmDashBoard;

            Setting();
            PrintItemList();
        }

        private void Setting()
        {
            lbl_TradeCode.Text = "주문번호 : " + trade.Trade_code;
            lbl_WareHouse.Text = "출고창고 : " + trade.Warehouse_name;
            txt_State.Text = trade.Trade_status;
            lbl_Master.Text = "담당자 : " + trade.Clerk_name;
            lbl_EndDate.Text = "마감일 : " + trade.End_date_str;
            lbl_Client.Text = "거래처 : " + trade.Business_name;
        }

        private void txt_State_Click(object sender, EventArgs e)
        {
            View.TradeManagement.Frm_ModifyTrade form = new View.TradeManagement.Frm_ModifyTrade(trade);
            form.ShowDialog();
            Setting();
            frmDashBoard.TradeListShow();
        }

        /// <summary>
        /// 그리드뷰에 아이템 품목을 호출합니다.
        /// </summary>
        private void PrintItemList()
        {
            string trade_Code = trade.Trade_code;
            int totalFee = 0;

            DataTable dt = new DataTable();
            DataColumn[] dataColumns = new DataColumn[7]{
                new DataColumn("주문번호"),
                new DataColumn("품목"),
                new DataColumn("품목코드"),
                new DataColumn("갯수"),
                new DataColumn("금액"),
                new DataColumn("단위(unit)"),
                new DataColumn("규격(standard)")
            };
            dt.Columns.AddRange(dataColumns);

            foreach (SampleOrder order in new Model.DAO.OrderedDAO().SelectSampleOrdered(trade_Code))
            {
                DataRow dataRow = dt.NewRow();
                dataRow["주문번호"] = order.Order_Code;
                dataRow["품목"] = order.Item_Name;
                dataRow["품목코드"] = order.Item_Code;
                dataRow["갯수"] = order.Item_Count;
                dataRow["금액"] = order.Item_Wrote_Fee;
                dataRow["단위(unit)"] = order.Item_unit;
                dataRow["규격(standard)"] = order.Item_standard;
                dt.Rows.Add(dataRow);

                totalFee += (int)order.Item_Wrote_Fee;
            }

            dv_OrderList.DataSource = dt;
            lbl_TotalFee.Text = "총 금액 : " + totalFee;
        }
    }
}
