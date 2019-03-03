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

/* 구현: 조성호
 * 진행중인 거래 조회 폼
 * 완료일: 2019-02-28
 */
namespace MiniERP.View.TradeManagement
{
    /// <summary>
    /// 진행중인 거래를 판매/구매로 나누어 조회할수있는 폼클래스,
    /// 작성자: 조성호
    /// </summary>
    public partial class Frm_SellBuyList : Form
    {
        List<Trade> trades = new List<Trade>();

        public Frm_SellBuyList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 신규 버튼이벤트 , 거래등록 폼을 띄운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Frm_SellBuyInsert frm = new Frm_SellBuyInsert();
            frm.ShowDialog();
        }

        private void Frm_SellBuyList_Load(object sender, EventArgs e)
        {
            GViewSetData();
        }

        /// <summary>
        /// 그리드뷰에 데이터를 입력하는 함수
        /// </summary>
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

        /// <summary>
        /// 라디오버튼 체크이벤트, 그리드뷰를 갱신한다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                GViewSetData();
            }
        }

        /// <summary>
        /// 그리드뷰 셀 더블클릭 이벤트, 해당 ROW의 수정폼을 띄운다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gViewTrade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1)
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
}
