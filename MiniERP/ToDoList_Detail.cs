﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.VO;

namespace MiniERP
{
    public partial class ToDoList_Detail : UserControl
    {
        private Trade trade;

        public ToDoList_Detail(Trade trade)
        {
            InitializeComponent();
            this.trade = trade;
            Setting();
            PrintItemList();
        }

        private void Setting()
        {
            lbl_TradeCode.Text += trade.Trade_code;
            lbl_WareHouse.Text += trade.Warehouse_name;
            txt_State.Text = trade.Trade_status;
            lbl_Master.Text += trade.Clerk_name;
            lbl_EndDate.Text += trade.End_date.ToString();
            lbl_Client.Text += trade.Business_name;
            //lbl_TotalFee  해당 라벨은 오더리스트 구하고나서
        }

        private void txt_State_Click(object sender, EventArgs e)
        {
            View.TradeManagement.Frm_ModifyTrade form = new View.TradeManagement.Frm_ModifyTrade(trade);
            form.Show();
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
