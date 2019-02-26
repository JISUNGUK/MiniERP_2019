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

namespace MiniERP.View.BusinessManagement
{
    public partial class Frm_BusinessInsert : Form
    {
        public Frm_BusinessInsert()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("거래처코드를 입력해주세요.", "거래처코드를 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
            }
            else if (new BusinessDAO().CheckBusinessCode(txtCode.Text))
            {
                MessageBox.Show("이미 사용중인 거래처코드입니다.\n다른 코드를 사용해주세요.", "거래처코드 중복", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("거래처명을 입력해주세요.", "거래처명을 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (String.IsNullOrEmpty(txtTel.Text))
            {
                MessageBox.Show("거래처 연락처를 입력해주세요.", "거래처 연락처를 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTel.Focus();
            }
            else if (String.IsNullOrEmpty(txtAddr.Text))
            {
                MessageBox.Show("거래처 주소를 입력해주세요.", "거래처 주소를 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddr.Focus();
            }
            else if (String.IsNullOrEmpty(txtPresenter.Text))
            {
                MessageBox.Show("거래처 대표자명을 입력해주세요.", "거래처 대표자명을 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPresenter.Focus();
            }
            else
            {
                Business business = new Business
                {
                    Code = txtCode.Text,
                    Name = txtName.Text,
                    Tel = txtTel.Text,
                    Addr = txtAddr.Text,
                    Email = txtEmail.Text,
                    Presenter = txtPresenter.Text
                };
                try
                {
                    new BusinessDAO().InsertBusiness(business);
                    MessageBox.Show("새로운 거래처를 등록했습니다.", "등록 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("등록에 실패했습니다.", "등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
