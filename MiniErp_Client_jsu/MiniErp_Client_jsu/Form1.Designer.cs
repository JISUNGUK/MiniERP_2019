namespace MiniErp_Client_jsu
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.test_btn = new System.Windows.Forms.Button();
            this.chk_Server = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Log = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자재투입현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Location = new System.Drawing.Point(6, 31);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(307, 21);
            this.txt_Barcode.TabIndex = 0;
            this.txt_Barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Barcode_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_Barcode);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "바코드 인식";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.chk_Server);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(244, 20);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(75, 23);
            this.test_btn.TabIndex = 0;
            this.test_btn.Text = "button1";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Visible = false;
            this.test_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_Server
            // 
            this.chk_Server.AutoSize = true;
            this.chk_Server.Enabled = false;
            this.chk_Server.Location = new System.Drawing.Point(6, 20);
            this.chk_Server.Name = "chk_Server";
            this.chk_Server.Size = new System.Drawing.Size(59, 16);
            this.chk_Server.TabIndex = 0;
            this.chk_Server.Text = "server";
            this.chk_Server.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Log);
            this.groupBox3.Controls.Add(this.test_btn);
            this.groupBox3.Location = new System.Drawing.Point(12, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 241);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // txt_Log
            // 
            this.txt_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Log.Location = new System.Drawing.Point(3, 17);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(313, 221);
            this.txt_Log.TabIndex = 0;
            this.txt_Log.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sssToolStripMenuItem,
            this.프로그램종료ToolStripMenuItem,
            this.재시작ToolStripMenuItem,
            this.자재투입현황ToolStripMenuItem,
            this.설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sssToolStripMenuItem
            // 
            this.sssToolStripMenuItem.Name = "sssToolStripMenuItem";
            this.sssToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.sssToolStripMenuItem.Text = "화면고정";
            // 
            // 프로그램종료ToolStripMenuItem
            // 
            this.프로그램종료ToolStripMenuItem.Name = "프로그램종료ToolStripMenuItem";
            this.프로그램종료ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.프로그램종료ToolStripMenuItem.Text = "종료";
            // 
            // 재시작ToolStripMenuItem
            // 
            this.재시작ToolStripMenuItem.Name = "재시작ToolStripMenuItem";
            this.재시작ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.재시작ToolStripMenuItem.Text = "재시작";
            // 
            // 자재투입현황ToolStripMenuItem
            // 
            this.자재투입현황ToolStripMenuItem.Name = "자재투입현황ToolStripMenuItem";
            this.자재투입현황ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.자재투입현황ToolStripMenuItem.Text = "자재투입현황";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.ipToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // ipToolStripMenuItem
            // 
            this.ipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.ipToolStripMenuItem.Name = "ipToolStripMenuItem";
            this.ipToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ipToolStripMenuItem.Text = "Ip";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox2_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "err_1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(99, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 16);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "err_2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txt_Log;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.CheckBox chk_Server;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재시작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자재투입현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem ipToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

