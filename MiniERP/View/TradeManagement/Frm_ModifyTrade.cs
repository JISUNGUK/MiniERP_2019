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
            txt_BusinessCode.Text = trade.Business_code;
            txt_BusinessName.Text = trade.Business_name;
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
                frm = new Frm_ClerkSelect();
                if (frm.ShowDialog() != DialogResult.Cancel)
                {
                    this.txt_ClerkCode.Text = ((Frm_ClerkSelect)frm).Clerk.Clerk_code;
                    this.txt_ClerkName.Text = ((Frm_ClerkSelect)frm).Clerk.Clerk_name;
                }
            }
            else if (((Button)sender).Name.Contains("Business"))
            {
                frm = new Frm_BusinessSelect();
                if (frm.ShowDialog() != DialogResult.Cancel)
                {
                    this.txt_BusinessCode.Text = ((Frm_BusinessSelect)frm).Business.Code;
                    this.txt_BusinessName.Text = ((Frm_BusinessSelect)frm).Business.Name;
                }
            }
            else if (((Button)sender).Name.Contains("Warehouse"))
            {
                frm = new Frm_WarehouseSelect();
                if (frm.ShowDialog() != DialogResult.Cancel)
                {
                    this.txt_WareCode.Text = ((Frm_WarehouseSelect)frm).Warehouse.Warehouse_code;
                    this.txt_WareName.Text = ((Frm_WarehouseSelect)frm).Warehouse.Warehouse_name;
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            trade.Clerk_code = txt_ClerkCode.Text;
            trade.Clerk_name = txt_ClerkName.Text;
            trade.Warehouse_code = txt_WareCode.Text;
            trade.Warehouse_name = txt_WareName.Text;
            trade.Business_code = txt_BusinessCode.Text;
            trade.Business_name = txt_BusinessName.Text;
            
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
