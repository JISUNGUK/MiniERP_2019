﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.TradeManagement
{
    public partial class Frm_SellBuyInsert : Form
    {
        public Frm_SellBuyInsert()
        {
            InitializeComponent();
            txt_BusinessCode.ReadOnly = true;
        }

        #region 라디오박스 이벤트
        private void rdo_Sell_CheckedChanged(object sender, EventArgs e)
        {
            lab_Warehouse.Text = "출고창고";
        }

        private void rdo_Buy_CheckedChanged(object sender, EventArgs e)
        {
            lab_Warehouse.Text = "입고창고";
        }
        #endregion

        /// <summary>
        /// 다시작성 버튼클릭 이벤트, 텍스트박스와 그리드뷰를 Clear 한다
        /// </summary>
        private void btn_Cleaner_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Clear();
                }
                else if (item.GetType() == typeof(DataGridView))
                {
                    ((DataGridView)item).Rows.Clear();
                }
            }
        }

        #region 품목 추가/삭제시 총액구하기
        private void gView_Order_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (gView_Order.RowCount > 0)
            {
                Get_TotalFee();
            }
        }

        private void gView_Order_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (gView_Order.RowCount > 0)
            {
                Get_TotalFee();
            }
        }

        private void Get_TotalFee()
        {
            int totalFee = 0;
            foreach (DataGridViewRow item in gView_Order.Rows)
            {
                totalFee += (int)item.Cells["totalFee"].Value;
            }
            lab_TotalPrice.Text = string.Format("{0:n0}", totalFee);
        }
        #endregion

        /// <summary>
        /// 그리드뷰 체크박스 (확인필요)
        /// </summary>
        private void gView_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //gView_Order.Rows[e.RowIndex].Cells["Select"].Value = (bool)gView_Order.Rows[e.RowIndex].Cells["Select"].Value ? false : true;
            }
        }

        private void btn_Text_Click(object sender, EventArgs e)
        {
            Form frm;
            if (((Button)sender).Name.Contains("Clerk"))
            {
                frm = new Frm_ClerkSelect();
                if (frm.ShowDialog() != DialogResult.Cancel)
                {
                    this.txt_ClerkCode.Text = ((Frm_ClerkSelect)frm).Clerk.Clerk_code;
                    this.txt_ClerkName.Text = ((Frm_ClerkSelect)frm).Clerk.Clerk_name;
                }
            }
            else if (((Button)sender).Name.Contains("Business"))
            {
                frm = new Frm_BusinessSelect();
                if (frm.ShowDialog() != DialogResult.Cancel)
                {
                    this.txt_BusinessCode.Text = ((Frm_BusinessSelect)frm).Business.Code;
                    this.txt_BusinessName.Text = ((Frm_BusinessSelect)frm).Business.Name;
                }
            }
            else if (((Button)sender).Name.Contains("Warehouse"))
            {
                frm = new Frm_WarehouseSelect();
                if (frm.ShowDialog() != DialogResult.Cancel)
                {
                    this.txt_WareCode.Text = ((Frm_WarehouseSelect)frm).Warehouse.Warehouse_code;
                    this.txt_WareName.Text = ((Frm_WarehouseSelect)frm).Warehouse.Warehouse_name;
                }
            }
        }
    }
}
