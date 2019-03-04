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
 * 거래 수정 폼
 * 완료일: 2019-03-01
 */
namespace MiniERP.View.TradeManagement
{
    /// <summary>
    /// 거래 데이터 수정 폼클래스, 
    /// 작성자: 조성호
    /// </summary>
    public partial class Frm_ModifyTrade : Form
    {
        private Trade trade;
        public Trade Trade { get => trade; set => trade = value; }

        public Frm_ModifyTrade(Trade trade)
        {
            InitializeComponent();
            this.trade = trade;
        }

        private void Frm_ModifyTrade_Load(object sender, EventArgs e)
        {
            txt_ClerkCode.Text = trade.Clerk_code;
            txt_ClerkName.Text = trade.Clerk_name;
            txt_WareCode.Text = trade.Warehouse_code;
            txt_WareName.Text = trade.Warehouse_name;
            SetComboItems();
            SetListView();
        }

        /// <summary>
        /// 해당 거래의 거래품목을 리스트뷰에 보여주기위한 함수
        /// </summary>
        private void SetListView()
        {
            OrderedDAO orderedDAO = new OrderedDAO();
            List<SampleOrder> sample = orderedDAO.SelectSampleOrdered(trade.Trade_code);
            foreach (var item in sample)
            {
                string[] str = { item.Item_Code, item.Item_Name, item.Item_Count.ToString(), item.Item_Wrote_Fee.ToString() };
                ListViewItem list = new ListViewItem(str);
                lv_Item.Items.Add(list);                
            }
        }

        /// <summary>
        /// 상태정보를 담고있는 콤보박스의 아이템을 세팅하기위한 함수
        /// </summary>
        private void SetComboItems()
        {
            StatusList status = new StatusList(trade.Trade_standard);

            foreach (var item in status.GetStatus(trade.Trade_status))
            {
                cmb_status.Items.Add(item.StatusStr);
            }

            cmb_status.SelectedItem = trade.Trade_status;
        }

        /// <summary>
        /// 사원/거래처를 수정하기위한 폼을 띄우는 버튼클릭이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Form frm;
            if (((Button)sender).Name.Contains("Clerk"))
            {
                if (trade.Trade_status!="취소")
                {
                    frm = new Frm_ClerkSelect();
                    if (frm.ShowDialog() != DialogResult.Cancel)
                    {
                        this.txt_ClerkCode.Text = ((Frm_ClerkSelect)frm).Clerk.Clerk_code;
                        this.txt_ClerkName.Text = ((Frm_ClerkSelect)frm).Clerk.Clerk_name;
                    } 
                }
                else
                {
                    MessageBox.Show("담당자는 취소하기 전까지만 변경 가능합니다.");
                }
            }
            else if (((Button)sender).Name.Contains("Warehouse"))
            {

                if (trade.Trade_status == "승인전" || trade.Trade_status == "승인" || trade.Trade_status == "생산")
                {
                    frm = new Frm_WarehouseSelect();
                    if (frm.ShowDialog() != DialogResult.Cancel)
                    {
                        this.txt_WareCode.Text = ((Frm_WarehouseSelect)frm).Warehouse.Warehouse_code;
                        this.txt_WareName.Text = ((Frm_WarehouseSelect)frm).Warehouse.Warehouse_name;
                    } 
                }
                else
                {
                    MessageBox.Show("현재 상태에서는 창고를 변경할 수 없습니다.");
                }
            }
        }

        /// <summary>
        /// 수정버튼 클릭이벤트, 입력된 데이터로 거래데이터를 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            trade.Clerk_code = txt_ClerkCode.Text;
            trade.Clerk_name = txt_ClerkName.Text;
            trade.Warehouse_code = txt_WareCode.Text;
            trade.Warehouse_name = txt_WareName.Text;
            
            if (String.IsNullOrWhiteSpace(trade.Trade_status))
            {
                MessageBox.Show("상태를 선택해주세요");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            trade.Trade_status = cmb_status.SelectedItem.ToString();

            TradeDAO tradeDAO = new TradeDAO();
            try
            {
                tradeDAO.UpdateTrade(trade);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB오류 발생. \r\n" + ex.Message);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 리스트뷰 ROW 선택이 안되는것처럼 보이게 하기위한 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Item.SelectedItems.Count != 0)
            {
                foreach (ListViewItem item in lv_Item.SelectedItems)
                {
                    item.Selected = false;
                }
            }
        }

        /// <summary>
        /// 콤보박스를 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_status_Leave(object sender, EventArgs e)
        {

        }
    }
}
