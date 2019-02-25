using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.Model.DAO;
using MiniERP.VO;

namespace MiniERP.View.StockManagement
{
    public partial class Frm_ItemInsert : Form
    {
        private List<Item> items;

        public Frm_ItemInsert()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 등록하려는 아이템코드가 이미 존재하는지 판단하는 메서드입니다.
        /// </summary>
        /// <param name="itemCode">새로 등록하려는 아이템코드입니다.</param>
        /// <returns>등록하려는 아이템코드가 이미 Item테이블에 존재하면 true, 그렇지 않으면 false를 반환합니다.</returns>
        private bool CheckItemCode(string itemCode)
        {
            bool result = false;

            foreach (var i in items)
            {
                if (i.Item_code == itemCode)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("품목코드를 입력해주세요.", "품목코드를 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("품목이름을 입력해주세요.", "품목이름을 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (String.IsNullOrEmpty(mTxtFee.Text))
            {
                MessageBox.Show("품목가격을 입력해주세요.", "품목가격을 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mTxtFee.Focus();
            }
            else
            {
                if (CheckItemCode(txtCode.Text))
                {
                    MessageBox.Show("이미 존재하는 품목코드입니다. 다른 코드를 입력해주세요.", "코드가 중복됩니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCode.Focus();
                }
                else
                {
                    Item item = new Item()
                    {
                        Item_code = txtCode.Text,
                        Item_name = txtName.Text,
                        Item_standard = txtStandard.Text,
                        Item_unit = txtUnit.Text,
                        Item_class = cmbClass.Text,
                        Item_fee = Int32.Parse(mTxtFee.Text),
                        Stock_count = 0,
                        Item_image = pbxImage.Image,
                        Item_group = txtGroup.Text,
                        Item_comment = txtComment.Text
                    };

                    if (new ItemDAO().InsertItem(item) != 0)
                    {
                        MessageBox.Show("새로운 품목을 등록했습니다.", "품목등록 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("품목등록에 실패했습니다.", "품목등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnImageSearch_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxImage.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ItemInsert_Load(object sender, EventArgs e)
        {
            items = new ItemDAO().GetItems("");
            cmbClass.SelectedIndex = 0;
        }
    }
}
