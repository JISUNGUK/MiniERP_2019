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
    public partial class Frm_ClerkInsert : Form
    {
        public Frm_ClerkInsert()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("사원코드를 입력해주세요.", "사원코드를 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
            }
            else if (new ClerkDAO().CheckClerkData(txtCode.Text))
            {
                MessageBox.Show("이미 등록되어있는 사원코드입니다.\n다른 사원코드를 사용해주세요.", "사원코드 중복", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("사원이름을 입력해주세요.", "사원이름을 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요.", "비밀번호를 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                Clerk clerk = new Clerk
                {
                    Clerk_code = txtCode.Text,
                    Clerk_name = txtName.Text,
                    Clerk_job = cmbJob.Text,
                    Clerk_password = txtPassword.Text
                };
                if (new ClerkDAO().InsertClerk(clerk) != -1)
                {
                    MessageBox.Show("새로운 사원을 등록했습니다.", "사원등록 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("사원등록에 실패했습니다.", "사원등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Frm_ClerkInsert_Load(object sender, EventArgs e)
        {
            cmbJob.SelectedIndex = 0;
        }
    }
}
