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
using System.Data.SqlClient;

namespace MiniERP.View.StockManagement
{
    public partial class Frm_ItemInfo : Form
    {
        private Item item; // 부모폼으로부터 얻어오는, 선택된 아이템에 대한 정보를 저장하고 있는 객체입니다.

        public Frm_ItemInfo()
        {
            InitializeComponent();
        }

        public Frm_ItemInfo(Item item) : this()
        {
            this.item = item;
        }

        private void Frm_ItemInfo_Load(object sender, EventArgs e)
        {
            txtCode.Text = item.Item_code;
            txtName.Text = item.Item_name;
            txtStandard.Text = item.Item_standard;
            txtUnit.Text = item.Item_unit;
            cmbClass.Text = item.Item_class;
            mTxtFee.Text = item.Item_fee.ToString();
            pbxImage.Image = item.Item_image;
            txtGroup.Text = item.Item_group;
            txtComment.Text = item.Item_comment;
        }
    }
}
