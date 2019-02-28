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
    public partial class Frm_TradeList : Form
    {
        public Frm_TradeList()
        {
            InitializeComponent();
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            pnl_serchbox.Visible = !pnl_serchbox.Visible;
        }

        private void Frm_TradeList_Load(object sender, EventArgs e)
        {
            GViewSetting();
        }

        List<Trade> trades;
        private void GViewSetData()
        {
            TradeDAO tradeDAO = new TradeDAO();
            trades = tradeDAO.GetTrade(low_date.Value,max_date.Value,null);
            gViewTrade.Rows.Clear();
            string button="";
            foreach (var item in trades)
            {
                if (item.Trade_standard == "판매")
                    button = "매출전표";
                else
                    button = "매입전표";
                gViewTrade.Rows.Add(item.Trade_standard, item.Trade_code, item.Clerk_name, item.Business_name, item.Item_summary, item.Total_fee, item.Trade_status,item.End_date,button);
            }
        }

        private void GViewSetting()
        {

        }

        private void gViewTrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(gViewTrade.CurrentCell.ColumnIndex==8)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.ShowDialog();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Frm_SellBuyInsert frm = new Frm_SellBuyInsert();
            frm.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            GViewSetData();
        }

        private void gViewTrade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var item in trades)
            {
                if(item.Trade_code == gViewTrade.Rows[e.RowIndex].Cells["trade_code"].Value.ToString())
                {
                    Frm_ModifyTrade frm = new Frm_ModifyTrade(item);
                    if(frm.ShowDialog() != DialogResult.Cancel)
                    {
                        GViewSetData();
                    }
                    break;
                }
            }
        }
    }
}
