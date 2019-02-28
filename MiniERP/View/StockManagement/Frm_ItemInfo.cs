using MiniERP.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.VO;

namespace MiniERP.View.StockManagement
{
    public partial class Frm_ItemInfo : Form
    {
        private List<Item> items;
        private string itemCode; // 부모폼으로부터 얻어오는 item의 code입니다.

        public Frm_ItemInfo()
        {
            InitializeComponent();
        }

        public Frm_ItemInfo(string itemCode)
        {
            this.itemCode = itemCode;
        }

        private void Frm_ItemInfo_Load(object sender, EventArgs e)
        {
            //new ItemDAO().GetItems(itemCode)
        }
    }
}
