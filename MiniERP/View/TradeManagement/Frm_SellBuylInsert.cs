using System;
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
        /// 텍스트박스에 키이벤트를 주면 해당 텍스트박스와 관련 텍스트박스를 Clear한다.
        /// </summary>
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (((TextBox)sender).Name.Contains("Clerk"))
            {
                txt_ClerkCode.Clear();
                txt_ClerkName.Clear();
            }
            else if (((TextBox)sender).Name.Contains("Business"))
            {
                txt_BusinessCode.Clear();
                txt_BusinessName.Clear();
            }
            else if (((TextBox)sender).Name.Contains("Ware"))
            {
                txt_WareCode.Clear();
                txt_WareName.Clear();
            }
        }

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
            Get_TotalFee();
        }

        private void gView_Order_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Get_TotalFee();
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
            //gView_Order.Rows[e.RowIndex].Cells["Select"].Value = (bool)gView_Order.Rows[e.RowIndex].Cells["Select"].Value ? false : true;
        }

        private void btn_Warehouse_Click(object sender, EventArgs e)
        {
            Frm_WarehouseSelect frm = new Frm_WarehouseSelect();
            if (frm.ShowDialog() != DialogResult.Cancel)
            {
                this.txt_WareCode.Text = frm.Warehouse.Warehouse_code;
                this.txt_WareName.Text = frm.Warehouse.Warehouse_name;
            }
        }

        private void btn_Business_Click(object sender, EventArgs e)
        {
            Frm_BusinessSelect frm = new Frm_BusinessSelect();
            if (frm.ShowDialog() != DialogResult.Cancel)
            {
                this.txt_BusinessCode.Text = frm.Business.Code;
                this.txt_BusinessName.Text = frm.Business.Name;
            }
        }
    }
}
