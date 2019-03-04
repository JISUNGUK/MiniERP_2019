using MiniERP.Model;
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
 * 거래조회 폼
 * 완료일: 2019-03-01
 */
namespace MiniERP.View.TradeManagement
{
    /// <summary>
    /// 일정 날짜 범위의 모든 거래내역을 보여주는 폼클래스
    /// 작성자: 조성호
    /// </summary>
    public partial class Frm_TradeList : Form
    {
        List<Business> businessList = new List<Business>();

        public Frm_TradeList()
        {
            InitializeComponent();
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            pnl_serchbox.Visible = !pnl_serchbox.Visible;
        }

        List<Trade> trades;
        #region 데이터그리드뷰 데이터입력
        /// <summary>
        /// 일반 검색함수
        /// </summary>
        private void GViewSetData()
        {            
            TradeDAO tradeDAO = new TradeDAO();
            trades = tradeDAO.GetTrade(low_date.Value, max_date.Value, null);
            gViewTrade.Rows.Clear();
            string button = "";
            businessList.Clear();
            foreach (var item in trades)
            {              
                foreach (var business in new MiniErpDB().Get_Specific_Business(item.Business_code))
                {
                    Business business1 = new Business();
                    business1.Code = business.Business_code;
                    business1.Addr = business.Business_addr;
                    business1.Email = business.Business_email;
                    business1.Presenter = business.Business_presenter;
                    business1.Tel = business.Business_tel;
                    business1.Name = business.Business_name;
                    businessList.Add(business1);
                }   
                if (item.Trade_standard == "판매")
                    button = "매출전표";
                else
                    button = "매입전표";
                gViewTrade.Rows.Add(item.Trade_standard, item.Trade_code, item.Clerk_name, item.Business_name, item.Item_summary, item.Total_fee, item.Trade_status, item.End_date_str, button);
            }
        }

        /// <summary>
        /// 상세 검색함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_detailSearch_Click(object sender, EventArgs e)
        {
            TradeDAO tradeDAO = new TradeDAO();
            trades = tradeDAO.GetTrade(low_date.Value, max_date.Value, txt_bussiness.Text);
            gViewTrade.Rows.Clear();
            string button = "";
            businessList.Clear();
            foreach (var item in trades)
            {
                foreach (var business in new MiniErpDB().Get_Specific_Business(item.Business_code))
                {
                    Business business1 = new Business();
                    business1.Code = business.Business_code;
                    business1.Addr = business.Business_addr;
                    business1.Email = business.Business_email;
                    business1.Presenter = business.Business_presenter;
                    business1.Name = business.Business_name;
                    business1.Tel = business.Business_tel;
                    businessList.Add(business1);
                }

                if (item.Trade_standard == "판매")
                    button = "매출전표";
                else
                    button = "매입전표";
                gViewTrade.Rows.Add(item.Trade_standard, item.Trade_code, item.Clerk_name, item.Business_name, item.Item_summary, item.Total_fee, item.Trade_status, item.End_date_str, button);
            }
        } 
        #endregion

        private void gViewTrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(gViewTrade.CurrentCell.ColumnIndex==8 && gViewTrade.CurrentRow.Cells[6].Value.ToString()=="완료")
            {
               PrintExcelDAO excel=new PrintExcelDAO();
                excel.outputExcel(gViewTrade.CurrentCell.Value.ToString(), gViewTrade.CurrentRow.Cells[1].Value.ToString(), businessList[gViewTrade.CurrentRow.Index],gViewTrade.CurrentRow);
            }
        }

        /// <summary>
        /// 신규 버튼 클릭이벤트, 거래등록폼을 띄운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Frm_SellBuyInsert frm = new Frm_SellBuyInsert();
            frm.ShowDialog();
        }

        /// <summary>
        /// 일반 검색 커튼 클릭이벤트, 일반검색함수를 호출한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Search_Click(object sender, EventArgs e)
        {
            GViewSetData();
        }

        /// <summary>
        /// 셀 더블클릭이벤트, 거래수정폼을 띄운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gViewTrade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.ColumnIndex != 8)
            {
                foreach (var item in trades)
                {
                    if (item.Trade_code == gViewTrade.Rows[e.RowIndex].Cells["trade_code"].Value.ToString())
                    {
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

        /// <summary>
        /// 검색 텍스트박스 진입시 텍스트박스의 텍스트를 모두 지운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_bussiness_Enter(object sender, EventArgs e)
        {
            txt_bussiness.Clear();
        }

        private void gViewTrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
