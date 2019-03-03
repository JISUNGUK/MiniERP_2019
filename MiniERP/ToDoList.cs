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
        private SplitterPanel panel2;

        public ToDoList(Trade item, SplitterPanel panel2)
        {
            InitializeComponent();
            this.trade = item;
            this.panel2 = panel2;
            this.trade.Trade_standard = "판매";           //  Detail 의 콤보박스리스트를 위한 값초기화
        }

        private void btn_Layer_Click(object sender, EventArgs e)
        {
            ToDoList_Detail detail = new ToDoList_Detail(trade);
            detail.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(detail);
            detail.Show();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            lbl_Ordcode.Text = trade.Trade_code;
            btn_Layer.Text = trade.Trade_status;
        }
    }
}
