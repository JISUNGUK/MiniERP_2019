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
        private List<Clerk> clerks;

        /// <summary>
        /// 등록하려는 Clerk_code가 이미 존재하는지 확인합니다.
        /// </summary>
        /// <param name="clerkCode">저장하려는 clerk_code입니다.</param>
        /// <returns>등록하려는 Clerk_code가 이미 존재하면 true, 그렇지 않으면 false를 반환합니다.</returns>
        private bool CheckClerkcode(string clerkCode)
        {
            bool result = false;

            foreach (var item in clerks)
            {
                if (item.Clerk_code == clerkCode)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public Frm_ClerkInsert()
        {
            InitializeComponent();
        }

        public Frm_ClerkInsert(List<Clerk> clerks) : this()
        {
            this.clerks = clerks;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("사원코드를 입력해주세요.");
                txtCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("사원이름을 입력해주세요.");
                txtName.Focus();
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                txtPassword.Focus();
            }
            else
            {
                if (CheckClerkcode(txtCode.Text))
                {
                    MessageBox.Show("이미 존재하는 사원코드입니다. 다른 사원코드를 입력해주세요.");
                    txtCode.Focus();
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
                        MessageBox.Show("새로운 사원을 등록했습니다.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("등록에 실패했습니다.");
                    }
                }
            }
        }
    }
}
