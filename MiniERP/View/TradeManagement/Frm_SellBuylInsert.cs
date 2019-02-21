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

        private void rdo_Sell_CheckedChanged(object sender, EventArgs e)
        {
            lab_Warehouse.Text = "출고창고";
        }

        private void rdo_Buy_CheckedChanged(object sender, EventArgs e)
        {
            lab_Warehouse.Text = "입고창고";
        }

        // 텍스트박스에 입력시 비움.
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            ((TextBox)sender).Clear();
        }
    }
}
