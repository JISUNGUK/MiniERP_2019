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
 * 재고 조회 폼클래스
 * 완료일: 2019-03-02
 */
namespace MiniERP.View.TradeManagement
{
    /// <summary>
    /// 재고조회를 할수있는 폼클래스,
    /// 작성자: 조성호
    /// </summary>
    public partial class Frm_StockListReal : Form
    {
        public Frm_StockListReal()
        {
            InitializeComponent();
        }
        List<Stock> stocks;

        /// <summary>
        /// 창고,품목선택버튼클릭이벤트,
        /// 선택한 버튼에 따라 알맞는 검색폼을 띄워준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 신규버튼이벤트,
        /// 신규 재고등록 폼을 띄워준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Frm_StockInsertReal frm = new Frm_StockInsertReal();
            frm.ShowDialog();
        }

        /// <summary>
        /// 검색버튼 클릭이벤트,
        /// 재고테이블을 검색하여 결과를 데이터그리드뷰에 띄워준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_serch_Click(object sender, EventArgs e)
        {
            StockDAO stockDAO = new StockDAO();
            stocks = stockDAO.Get_Stock(txt_WareCode.Text, txt_ItemCode.Text);
            gVIewStock.Rows.Clear();

            foreach (var item in stocks)
            {
                gVIewStock.Rows.Add(item.Warehouse_code,item.Warehouse_name, item.Item_code, item.Stock_name, item.Stock_standard, item.Stock_count);
            }
            
        }

        /// <summary>
        /// 다시쓰기버튼 클릭이벤트,
        /// 텍스트박스의 텍스트문자열을 지운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ItemCode.Clear();
            txt_ItemName.Clear();
            txt_WareCode.Clear();
            txt_WareName.Clear();
        }
    }
}
