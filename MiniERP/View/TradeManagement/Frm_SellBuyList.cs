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
    public partial class Frm_SellBuyList : Form
    {
        List<Trade> trades = new List<Trade>();

        public Frm_SellBuyList()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Frm_SellBuyInsert frm = new Frm_SellBuyInsert();
            frm.ShowDialog();
        }

        private void Frm_SellBuyList_Load(object sender, EventArgs e)
        {
            GViewSetData();
        }

        private void GViewSetData()
        {
            gViewTrade.Rows.Clear();
            TradeDAO tradeDAO = new TradeDAO();
            if (rdo_sell.Checked)
            {
                trades = tradeDAO.GetProgTrade("판매");
                gViewTrade.Columns["warehouse"].HeaderText = "출고창고";
            }
            else
            {
                trades = tradeDAO.GetProgTrade("구매");
                gViewTrade.Columns["warehouse"].HeaderText = "입고창고";
            }

            foreach (var item in trades)
            {
                gViewTrade.Rows.Add(item.Trade_code, item.Clerk_name, item.Business_name, item.Item_summary, item.Total_fee, item.Trade_status, item.Warehouse_name);
            }
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                GViewSetData();
            }
        }

        private void gViewTrade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var item in trades)
            {
                if (item.Trade_code == gViewTrade.Rows[e.RowIndex].Cells["code"].Value.ToString())
                {
                    if (rdo_sell.Checked)
                    {
                        item.Trade_standard = rdo_sell.Text;
                    }
                    else
                    {
                        item.Trade_standard = rdo_buy.Text;
                    }

                    Frm_ModifyTrade frm = new Frm_ModifyTrade(item);
                    if (frm.ShowDialog() != DialogResult.Cancel)
                    {
                        GViewSetData();
                    }
                    break;
                }
            }
        }
    }
}
