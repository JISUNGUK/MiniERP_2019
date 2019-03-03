using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.VO;

namespace MiniERP.View
{
    public partial class ToDoList : UserControl
    {
        private Trade trade;
        Panel detail_Panel;
        private FrmDashBoard frmDashBoard;

        //  애가진짜
        public ToDoList(Trade trade, Panel detail_Panel, FrmDashBoard frmDashBoard)
        {
            InitializeComponent();
            this.trade = trade;
            this.detail_Panel = detail_Panel;
            this.frmDashBoard = frmDashBoard;
            this.trade.Trade_standard = "판매";           //  Detail 의 콤보박스리스트를 위한 값초기화
        }

        private void btn_Layer_Click(object sender, EventArgs e)
        {
            ToDoList_Detail detail = new ToDoList_Detail(trade, detail_Panel, frmDashBoard);
            detail.Dock = DockStyle.Fill;

            detail_Panel.Controls.Clear();
            detail_Panel.Controls.Add(detail);
            detail.Show();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            lbl_Ordcode.Text = trade.Trade_code;
            btn_Layer.Text = trade.Trade_status;
        }
    }
}
