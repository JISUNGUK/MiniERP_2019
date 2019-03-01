using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("품목코드를 입력해주세요.", "품목코드를 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
            }
            else if (new ItemDAO().CheckItemData(txtCode.Text))
            {
                MessageBox.Show("이미 사용중인 품목코드입니다.\n다른 코드를 입력해주세요.", "품목코드 중복", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnImageSearch_Click(object sender, EventArgs e)
        {
            Regex imageRegex = new Regex(@"([^\s]+(\.(?i)(jpg|png|gif|bmp))$)"); // 이미지파일인지 아닌지 확인하는 정규식입니다.

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (imageRegex.IsMatch(openFileDialog1.FileName))
                {
                    pbxImage.ImageLocation = openFileDialog1.FileName;
                }
                else
                {
                    MessageBox.Show("선택한 파일은 지원하지 않는 이미지타입 이거나,\n사용할 수 없는 이미지입니다.\n다른 이미지를 선택해주세요.", "이미지선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
