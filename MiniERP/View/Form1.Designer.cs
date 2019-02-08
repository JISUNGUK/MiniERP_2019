namespace MiniERP.View
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Panal_Main = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.영업ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_OrdM_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Accountregistration = new System.Windows.Forms.ToolStripMenuItem();
            this.물류관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.견적서조회ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.생산계획서조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출하확인서조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기초등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.품목등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창고등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.거래처등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자재관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOM조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구매관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구매조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구매조회ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.구매입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판매ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판매조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판매입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회계관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.장부조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전표관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전표조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전표인새ㅗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.장부관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매입관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.생산관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.Panal_Main.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Panal_Main);
            this.splitContainer1.Panel2MinSize = 30;
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 681);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(421, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(135, 22);
            this.toolStripLabel1.Text = "여기에 최대화 버튼넣기";
            // 
            // Panal_Main
            // 
            this.Panal_Main.BackColor = System.Drawing.Color.Gray;
            this.Panal_Main.Controls.Add(this.tabControl1);
            this.Panal_Main.Controls.Add(this.menuStrip1);
            this.Panal_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panal_Main.Location = new System.Drawing.Point(0, 0);
            this.Panal_Main.Name = "Panal_Main";
            this.Panal_Main.Size = new System.Drawing.Size(839, 681);
            this.Panal_Main.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 657);
            this.tabControl1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.영업ToolStripMenuItem,
            this.물류관리ToolStripMenuItem,
            this.재고관리ToolStripMenuItem,
            this.구매관리ToolStripMenuItem,
            this.회계관리ToolStripMenuItem,
            this.생산관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 영업ToolStripMenuItem
            // 
            this.영업ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_OrdM_inquiry,
            this.tsm_Accountregistration});
            this.영업ToolStripMenuItem.Name = "영업ToolStripMenuItem";
            this.영업ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.영업ToolStripMenuItem.Text = "영업관리";
            // 
            // tsm_OrdM_inquiry
            // 
            this.tsm_OrdM_inquiry.Name = "tsm_OrdM_inquiry";
            this.tsm_OrdM_inquiry.Size = new System.Drawing.Size(138, 22);
            this.tsm_OrdM_inquiry.Text = "주문 조회";
            this.tsm_OrdM_inquiry.Click += new System.EventHandler(this.tsm_OrdM_inquiry_Click_1);
            // 
            // tsm_Accountregistration
            // 
            this.tsm_Accountregistration.Name = "tsm_Accountregistration";
            this.tsm_Accountregistration.Size = new System.Drawing.Size(138, 22);
            this.tsm_Accountregistration.Text = "거래처 조회";
            this.tsm_Accountregistration.Click += new System.EventHandler(this.tsm_Accountregistration_Click);
            // 
            // 물류관리ToolStripMenuItem
            // 
            this.물류관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.견적서조회ToolStripMenuItem1,
            this.생산계획서조회ToolStripMenuItem,
            this.출하확인서조회ToolStripMenuItem});
            this.물류관리ToolStripMenuItem.Name = "물류관리ToolStripMenuItem";
            this.물류관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.물류관리ToolStripMenuItem.Text = "물류관리";
            // 
            // 견적서조회ToolStripMenuItem1
            // 
            this.견적서조회ToolStripMenuItem1.Name = "견적서조회ToolStripMenuItem1";
            this.견적서조회ToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.견적서조회ToolStripMenuItem1.Text = "견적서 조회";
            this.견적서조회ToolStripMenuItem1.Click += new System.EventHandler(this.견적서조회ToolStripMenuItem1_Click_1);
            // 
            // 생산계획서조회ToolStripMenuItem
            // 
            this.생산계획서조회ToolStripMenuItem.Name = "생산계획서조회ToolStripMenuItem";
            this.생산계획서조회ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.생산계획서조회ToolStripMenuItem.Text = "생산계획서 조회";
            this.생산계획서조회ToolStripMenuItem.Click += new System.EventHandler(this.생산계획서조회ToolStripMenuItem_Click);
            // 
            // 출하확인서조회ToolStripMenuItem
            // 
            this.출하확인서조회ToolStripMenuItem.Name = "출하확인서조회ToolStripMenuItem";
            this.출하확인서조회ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.출하확인서조회ToolStripMenuItem.Text = "출하확인서 조회";
            // 
            // 재고관리ToolStripMenuItem
            // 
            this.재고관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기초등록ToolStripMenuItem,
            this.자재관리ToolStripMenuItem,
            this.기타이동ToolStripMenuItem,
            this.bOMToolStripMenuItem});
            this.재고관리ToolStripMenuItem.Name = "재고관리ToolStripMenuItem";
            this.재고관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.재고관리ToolStripMenuItem.Text = "재고관리";
            // 
            // 기초등록ToolStripMenuItem
            // 
            this.기초등록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.품목등록ToolStripMenuItem,
            this.창고등록ToolStripMenuItem,
            this.거래처등록ToolStripMenuItem});
            this.기초등록ToolStripMenuItem.Name = "기초등록ToolStripMenuItem";
            this.기초등록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.기초등록ToolStripMenuItem.Text = "기초 등록";
            // 
            // 품목등록ToolStripMenuItem
            // 
            this.품목등록ToolStripMenuItem.Name = "품목등록ToolStripMenuItem";
            this.품목등록ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.품목등록ToolStripMenuItem.Text = "품목 등록";
            // 
            // 창고등록ToolStripMenuItem
            // 
            this.창고등록ToolStripMenuItem.Name = "창고등록ToolStripMenuItem";
            this.창고등록ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.창고등록ToolStripMenuItem.Text = "창고 등록";
            // 
            // 거래처등록ToolStripMenuItem
            // 
            this.거래처등록ToolStripMenuItem.Name = "거래처등록ToolStripMenuItem";
            this.거래처등록ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.거래처등록ToolStripMenuItem.Text = "거래처 등록";
            // 
            // 자재관리ToolStripMenuItem
            // 
            this.자재관리ToolStripMenuItem.Name = "자재관리ToolStripMenuItem";
            this.자재관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.자재관리ToolStripMenuItem.Text = "자재 관리";
            // 
            // 기타이동ToolStripMenuItem
            // 
            this.기타이동ToolStripMenuItem.Name = "기타이동ToolStripMenuItem";
            this.기타이동ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.기타이동ToolStripMenuItem.Text = "기타 이동";
            // 
            // bOMToolStripMenuItem
            // 
            this.bOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOM조회ToolStripMenuItem});
            this.bOMToolStripMenuItem.Name = "bOMToolStripMenuItem";
            this.bOMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bOMToolStripMenuItem.Text = "BOM";
            // 
            // bOM조회ToolStripMenuItem
            // 
            this.bOM조회ToolStripMenuItem.Name = "bOM조회ToolStripMenuItem";
            this.bOM조회ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bOM조회ToolStripMenuItem.Text = "BOM 조회";
            this.bOM조회ToolStripMenuItem.Click += new System.EventHandler(this.bOM조회ToolStripMenuItem_Click);
            // 
            // 구매관리ToolStripMenuItem
            // 
            this.구매관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.구매조회ToolStripMenuItem,
            this.판매ToolStripMenuItem});
            this.구매관리ToolStripMenuItem.Name = "구매관리ToolStripMenuItem";
            this.구매관리ToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.구매관리ToolStripMenuItem.Text = "판매/구매관리";
            // 
            // 구매조회ToolStripMenuItem
            // 
            this.구매조회ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.구매조회ToolStripMenuItem1,
            this.구매입력ToolStripMenuItem});
            this.구매조회ToolStripMenuItem.Name = "구매조회ToolStripMenuItem";
            this.구매조회ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.구매조회ToolStripMenuItem.Text = "구매";
            // 
            // 구매조회ToolStripMenuItem1
            // 
            this.구매조회ToolStripMenuItem1.Name = "구매조회ToolStripMenuItem1";
            this.구매조회ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.구매조회ToolStripMenuItem1.Text = "구매조회";
            // 
            // 구매입력ToolStripMenuItem
            // 
            this.구매입력ToolStripMenuItem.Name = "구매입력ToolStripMenuItem";
            this.구매입력ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.구매입력ToolStripMenuItem.Text = "구매입력";
            // 
            // 판매ToolStripMenuItem
            // 
            this.판매ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.판매조회ToolStripMenuItem,
            this.판매입력ToolStripMenuItem});
            this.판매ToolStripMenuItem.Name = "판매ToolStripMenuItem";
            this.판매ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.판매ToolStripMenuItem.Text = "판매";
            // 
            // 판매조회ToolStripMenuItem
            // 
            this.판매조회ToolStripMenuItem.Name = "판매조회ToolStripMenuItem";
            this.판매조회ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.판매조회ToolStripMenuItem.Text = "판매조회";
            this.판매조회ToolStripMenuItem.Click += new System.EventHandler(this.판매조회ToolStripMenuItem_Click);
            // 
            // 판매입력ToolStripMenuItem
            // 
            this.판매입력ToolStripMenuItem.Name = "판매입력ToolStripMenuItem";
            this.판매입력ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.판매입력ToolStripMenuItem.Text = "판매입력";
            // 
            // 회계관리ToolStripMenuItem
            // 
            this.회계관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.장부조회ToolStripMenuItem,
            this.전표관리ToolStripMenuItem,
            this.장부관리ToolStripMenuItem});
            this.회계관리ToolStripMenuItem.Name = "회계관리ToolStripMenuItem";
            this.회계관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.회계관리ToolStripMenuItem.Text = "회계관리";
            // 
            // 장부조회ToolStripMenuItem
            // 
            this.장부조회ToolStripMenuItem.Name = "장부조회ToolStripMenuItem";
            this.장부조회ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.장부조회ToolStripMenuItem.Text = "매입매출거래";
            // 
            // 전표관리ToolStripMenuItem
            // 
            this.전표관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.전표조회ToolStripMenuItem,
            this.전표인새ㅗToolStripMenuItem});
            this.전표관리ToolStripMenuItem.Name = "전표관리ToolStripMenuItem";
            this.전표관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.전표관리ToolStripMenuItem.Text = "전표 관리";
            // 
            // 전표조회ToolStripMenuItem
            // 
            this.전표조회ToolStripMenuItem.Name = "전표조회ToolStripMenuItem";
            this.전표조회ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.전표조회ToolStripMenuItem.Text = "전표조회";
            // 
            // 전표인새ㅗToolStripMenuItem
            // 
            this.전표인새ㅗToolStripMenuItem.Name = "전표인새ㅗToolStripMenuItem";
            this.전표인새ㅗToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.전표인새ㅗToolStripMenuItem.Text = "전표인쇄";
            // 
            // 장부관리ToolStripMenuItem
            // 
            this.장부관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.매출관리ToolStripMenuItem,
            this.매입관리ToolStripMenuItem});
            this.장부관리ToolStripMenuItem.Name = "장부관리ToolStripMenuItem";
            this.장부관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.장부관리ToolStripMenuItem.Text = "장부 관리";
            // 
            // 매출관리ToolStripMenuItem
            // 
            this.매출관리ToolStripMenuItem.Name = "매출관리ToolStripMenuItem";
            this.매출관리ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.매출관리ToolStripMenuItem.Text = "매출청구서 조회";
            // 
            // 매입관리ToolStripMenuItem
            // 
            this.매입관리ToolStripMenuItem.Name = "매입관리ToolStripMenuItem";
            this.매입관리ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.매입관리ToolStripMenuItem.Text = "매입청구서 조회";
            // 
            // 생산관리ToolStripMenuItem
            // 
            this.생산관리ToolStripMenuItem.Name = "생산관리ToolStripMenuItem";
            this.생산관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.생산관리ToolStripMenuItem.Text = "생산관리";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Panal_Main.ResumeLayout(false);
            this.Panal_Main.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel Panal_Main;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 영업ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_OrdM_inquiry;
        private System.Windows.Forms.ToolStripMenuItem tsm_Accountregistration;
        private System.Windows.Forms.ToolStripMenuItem 물류관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 견적서조회ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 생산계획서조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출하확인서조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재고관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기초등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창고등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자재관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기타이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구매관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구매조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회계관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장부조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전표관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전표조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전표인새ㅗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장부관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매입관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 생산관리ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem bOMToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem 구매조회ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 구매입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 거래처등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOM조회ToolStripMenuItem;
    }
}

