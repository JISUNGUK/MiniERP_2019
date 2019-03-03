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
        VO.Trade trade;
        private Trade item;
        private SplitterPanel panel2;

        public ToDoList(Trade item, SplitterPanel panel2)
        {
            InitializeComponent();
            this.trade = item;
            this.panel2 = panel2;
        }

        private void btn_Layer_Click(object sender, EventArgs e)
        {
            ToDoList_Detail detail = new ToDoList_Detail(trade);
            detail.Dock = DockStyle.Fill;
            //detail.Size = new Size(300, 150);

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
