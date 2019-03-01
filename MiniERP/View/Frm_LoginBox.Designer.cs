namespace MiniERP.View
{
    partial class Frm_LoginBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.autologin = new System.Windows.Forms.CheckBox();
            this.savepwd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(173, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mini ERP 로그인";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(539, 84);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(110, 94);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "사원 ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "사원 PW";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(138, 88);
            this.txt_id.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(370, 32);
            this.txt_id.TabIndex = 4;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(138, 142);
            this.txt_pw.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(370, 32);
            this.txt_pw.TabIndex = 5;
            // 
            // autologin
            // 
            this.autologin.AutoSize = true;
            this.autologin.Enabled = false;
            this.autologin.Location = new System.Drawing.Point(379, 208);
            this.autologin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.autologin.Name = "autologin";
            this.autologin.Size = new System.Drawing.Size(141, 25);
            this.autologin.TabIndex = 6;
            this.autologin.Text = "자동로그인";
            this.autologin.UseVisualStyleBackColor = true;
            // 
            // savepwd
            // 
            this.savepwd.AutoSize = true;
            this.savepwd.Location = new System.Drawing.Point(138, 208);
            this.savepwd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.savepwd.Name = "savepwd";
            this.savepwd.Size = new System.Drawing.Size(162, 25);
            this.savepwd.TabIndex = 7;
            this.savepwd.Text = "입력정보저장";
            this.savepwd.UseVisualStyleBackColor = true;
            this.savepwd.CheckedChanged += new System.EventHandler(this.savepwd_CheckedChanged);
            // 
            // Frm_LoginBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(668, 257);
            this.Controls.Add(this.savepwd);
            this.Controls.Add(this.autologin);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LoginBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_LoginBox_FormClosed);
            this.Load += new System.EventHandler(this.Frm_LoginBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.CheckBox autologin;
        private System.Windows.Forms.CheckBox savepwd;
    }
}