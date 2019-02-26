using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                
                List<VO.Clerk>clerklist=login.GetClerk(loginclerk);
                if (clerklist.Count > 0)
                    afterclerk = clerklist[0];

            }

            if (!String.IsNullOrEmpty(afterclerk.Clerk_name))
            {
                
                form1.logIn = DialogResult.OK;
                form1.nickname = afterclerk.Clerk_name + "[" + afterclerk.Clerk_job + "]";
                form1.Id = txt_id.Text;
                form1.Pwd = txt_pw.Text;
                form1.Save = this.savepwd.Checked;
                form1.Autologin = autologin.Checked + "";
                MessageBox.Show("로그인 되었습니다");

                
                this.Close();
                
            }
            else
            { 
                MessageBox.Show("아이디나 비밀번호가 정확하지 않습니다");
                txt_id.Text = "";
                txt_pw.Text = "";
            }
        }

        private void Frm_LoginBox_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Frm_LoginBox_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Frm_LoginBox_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("login.txt"))
            {
                FileStream fs = new FileStream("login.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                int count = 0;
                while (!sr.EndOfStream)
                {
                    if (count == 0)
                        txt_id.Text = sr.ReadLine().Substring(3);
                    else if (count == 1)
                        txt_pw.Text = sr.ReadLine().Substring(3);
                    else
                    { 
                        string logincheck = sr.ReadLine().Substring(10);
                        if (logincheck == "True")
                             autologin.Checked= true; 
                        else
                            autologin.Checked = false;
                    }
                    count++;
                }
                if(autologin.Checked)
                    btn_Login_Click(null, null);
                fs.Close();
            }

        }

        private void savepwd_CheckedChanged(object sender, EventArgs e)
        {
            if(savepwd.Checked)
            {
                autologin.Enabled = true;
            }
            else
            {
                autologin.Enabled = false;
            }
        }
    }
}
