using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View
{
    public partial class Frm_LoginBox : Form
    {
        private Form1 form1;
        VO.Clerk afterclerk;

        public Frm_LoginBox(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            afterclerk = new VO.Clerk();
            if (!String.IsNullOrEmpty(txt_id.Text) && !String.IsNullOrEmpty(txt_pw.Text))
            {
                VO.Clerk loginclerk = new VO.Clerk();
                loginclerk.Clerk_code = txt_id.Text;
                loginclerk.Clerk_password = txt_pw.Text;
                Model.DAO.Message.loginDao login = new Model.DAO.Message.loginDao();
               afterclerk =login.GetClerk(loginclerk)[0];//list의 첫번째 객체를 갖고옴
            }

            if (!String.IsNullOrEmpty(afterclerk.Clerk_name))
            {
                
                form1.logIn = DialogResult.OK;
                form1.nickname = afterclerk.Clerk_name + "[" + afterclerk.Clerk_job + "]";
                MessageBox.Show("로그인 되었습니다");
                this.Close();
            }
            else
                MessageBox.Show("아이디나 비밀번호가 정확하지 않습니다");
        }

        private void Frm_LoginBox_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Frm_LoginBox_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
