using MiniERP.Model.DAO;
using MiniERP.VO;
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
    public partial class Frm_StockListReal : Form
    {
        public Frm_StockListReal()
        {
            InitializeComponent();
        }
        List<Stock> stocks;
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Frm_StockInsertReal frm = new Frm_StockInsertReal();
            frm.ShowDialog();
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            StockDAO stockDAO = new StockDAO();
            stocks = stockDAO.Get_Stock(txt_WareCode.Text, txt_WareName.Text);
            foreach (var item in stocks)
            {
                gVIewStock.Rows.Add(item.Warehouse_name, item.Item_code, item.Stock_name, item.Stock_standard, item.Stock_count);
            }
            
        }
    }
}
