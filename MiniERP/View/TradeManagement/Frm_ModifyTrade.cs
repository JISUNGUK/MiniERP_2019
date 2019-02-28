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
        }

        private void SetComboItems()
        {
            StatusList status = new StatusList(trade.Trade_standard);

            foreach (var item in status.GetStatus(trade.Trade_status))
            {
                cmb_status.Items.Add(item.StatusStr);
            }

            cmb_status.SelectedItem = trade.Trade_status;
        }

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
            tradeDAO.UpdateTrade(trade);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
