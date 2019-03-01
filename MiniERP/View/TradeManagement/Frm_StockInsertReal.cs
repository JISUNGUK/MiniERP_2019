using MiniERP.Model.DAO;
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
    public partial class Frm_StockInsertReal : Form
    {
        public Frm_StockInsertReal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 기본값 (담당자,거래처,창고)를 입력하는 버튼이벤트
        /// </summary>
        private void btn_Text_Click(object sender, EventArgs e)
        {
            Form frm;
            if (((Button)sender).Name.Contains("Item"))
            {
                frm = new Frm_ItemSelect();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.txt_ItemCode.Text = ((Frm_ItemSelect)frm).SelectItem.Item_code;
                    this.txt_ItemName.Text = ((Frm_ItemSelect)frm).SelectItem.Item_name;
                }
            }
            else if (((Button)sender).Name.Contains("Warehouse"))
            {
                frm = new Frm_WarehouseSelect();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.txt_WareCode.Text = ((Frm_WarehouseSelect)frm).Warehouse.Warehouse_code;
                    this.txt_WareName.Text = ((Frm_WarehouseSelect)frm).Warehouse.Warehouse_name;
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                StockDAO stockDAO = new StockDAO();
                try
                {
                    stockDAO.Set_Stock_Item(txt_ItemCode.Text, txt_WareCode.Text, Convert.ToInt32(num_count.Value));
                    MessageBox.Show("재고추가 성공");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("재고추가 실패\r\n"+er.Message);
                    this.Close();
                }
            }
        }

        private bool Validation()
        {
            if (String.IsNullOrWhiteSpace(txt_ItemCode.Text))
            {
                MessageBox.Show("품목은 반드시 선택하셔야합니다.");
                btn_Item.Select();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txt_WareCode.Text))
            {
                MessageBox.Show("창고는 반드시 선택하셔야합니다.");
                btn_Warehouse.Select();
                return false;
            }
            return true;
        }
    }
}
