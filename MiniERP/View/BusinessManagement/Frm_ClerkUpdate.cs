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

namespace MiniERP.View.BusinessManagement
{
    public partial class Frm_ClerkUpdate : Form
    {
        private Clerk clerk; // 부모폼으로부터 넘겨받는 Clerk객체입니다.
        private DialogResult dialogResult = DialogResult.None; // 수정하기 버튼을 누른 후 예를 눌렀는지 아니오를 눌렀는지 판별하기 위한 변수입니다.

        public DialogResult DialogResult1 { get => dialogResult; set => dialogResult = value; }

        public Frm_ClerkUpdate()
        {
            InitializeComponent();
        }

        public Frm_ClerkUpdate(Clerk clerk) : this()
        {
            this.clerk = clerk;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ClerkUpdate_Load(object sender, EventArgs e)
        {
            lblCode.Text = clerk.Clerk_code;
            txtName.Text = clerk.Clerk_name;
            cmbJob.Text = clerk.Clerk_job;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("사원명을 입력해주세요.", "사원명 공백", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else
            {
                if (MessageBox.Show("수정하시겠습니까?", "수정 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        new ClerkDAO().UpdateClerk(new Clerk()
                        {
                            Clerk_code = lblCode.Text,
                            Clerk_name = txtName.Text,
                            Clerk_job = cmbJob.Text
                        });
                        MessageBox.Show("수정되었습니다.", "수정 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("수정에 실패했습니다.", "수정 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
