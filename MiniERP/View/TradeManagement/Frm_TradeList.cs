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
        // 콤보박스 데이터바인딩 https://social.msdn.microsoft.com/Forums/vstudio/en-US/e22f9093-22b0-4b72-9ba4-ff75110b9d0f/datagridview-combobox-column-on-a-listltgt-property?forum=csharpgeneral
        private void btn_Detail_Click(object sender, EventArgs e)
        {
            pnl_serchbox.Visible = !pnl_serchbox.Visible;
        }

        private void Frm_TradeList_Load(object sender, EventArgs e)
        {

        }
    }
}
