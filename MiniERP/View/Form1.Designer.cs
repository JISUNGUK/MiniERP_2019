using System;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Panal_Main = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영업ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_OrdM_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Accountregistration = new System.Windows.Forms.ToolStripMenuItem();
            this.사원조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.물류관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.견적서조회ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.생산계획서조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기초등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.품목등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.거래처등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사원등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOM조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창고관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창고조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창고이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구매관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.거래조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.진행중인거래ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회계관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전표관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전표조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전표인새ㅗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.장부관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매입관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.생산관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.견적서분석ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.Panal_Main.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.splitContainer1.Size = new System.Drawing.Size(1470, 1060);
            this.splitContainer1.SplitterDistance = 389;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 1060);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(389, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.BackgroundImage")));
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Panal_Main
            // 
            this.Panal_Main.BackColor = System.Drawing.Color.Gray;
            this.Panal_Main.Controls.Add(this.tabControl1);
            this.Panal_Main.Controls.Add(this.menuStrip1);
            this.Panal_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panal_Main.Location = new System.Drawing.Point(0, 0);
            this.Panal_Main.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Panal_Main.Name = "Panal_Main";
            this.Panal_Main.Size = new System.Drawing.Size(1075, 1060);
            this.Panal_Main.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1075, 1018);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.영업ToolStripMenuItem,
            this.물류관리ToolStripMenuItem,
            this.재고관리ToolStripMenuItem,
            this.구매관리ToolStripMenuItem,
            this.회계관리ToolStripMenuItem,
            this.생산관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1075, 42);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(119, 34);
            this.mainToolStripMenuItem.Text = "MainPage";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 영업ToolStripMenuItem
            // 
            this.영업ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_OrdM_inquiry,
            this.tsm_Accountregistration,
            this.사원조회ToolStripMenuItem});
            this.영업ToolStripMenuItem.Name = "영업ToolStripMenuItem";
            this.영업ToolStripMenuItem.Size = new System.Drawing.Size(109, 34);
            this.영업ToolStripMenuItem.Text = "영업관리";
            // 
            // tsm_OrdM_inquiry
            // 
            this.tsm_OrdM_inquiry.Name = "tsm_OrdM_inquiry";
            this.tsm_OrdM_inquiry.Size = new System.Drawing.Size(216, 34);
            this.tsm_OrdM_inquiry.Text = "주문 조회";
            this.tsm_OrdM_inquiry.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // tsm_Accountregistration
            // 
            this.tsm_Accountregistration.Name = "tsm_Accountregistration";
            this.tsm_Accountregistration.Size = new System.Drawing.Size(216, 34);
            this.tsm_Accountregistration.Text = "거래처 조회";
            this.tsm_Accountregistration.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 사원조회ToolStripMenuItem
            // 
            this.사원조회ToolStripMenuItem.Name = "사원조회ToolStripMenuItem";
            this.사원조회ToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.사원조회ToolStripMenuItem.Text = "사원 조회";
            this.사원조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 물류관리ToolStripMenuItem
            // 
            this.물류관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.견적서조회ToolStripMenuItem1,
            this.생산계획서조회ToolStripMenuItem});
            this.물류관리ToolStripMenuItem.Name = "물류관리ToolStripMenuItem";
            this.물류관리ToolStripMenuItem.Size = new System.Drawing.Size(109, 34);
            this.물류관리ToolStripMenuItem.Text = "물류관리";
            // 
            // 견적서조회ToolStripMenuItem1
            // 
            this.견적서조회ToolStripMenuItem1.Name = "견적서조회ToolStripMenuItem1";
            this.견적서조회ToolStripMenuItem1.Size = new System.Drawing.Size(258, 34);
            this.견적서조회ToolStripMenuItem1.Text = "견적서 조회";
            this.견적서조회ToolStripMenuItem1.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 생산계획서조회ToolStripMenuItem
            // 
            this.생산계획서조회ToolStripMenuItem.Name = "생산계획서조회ToolStripMenuItem";
            this.생산계획서조회ToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.생산계획서조회ToolStripMenuItem.Text = "생산계획서 조회";
            this.생산계획서조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 재고관리ToolStripMenuItem
            // 
            this.재고관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기초등록ToolStripMenuItem,
            this.bOMToolStripMenuItem,
            this.창고관리ToolStripMenuItem});
            this.재고관리ToolStripMenuItem.Name = "재고관리ToolStripMenuItem";
            this.재고관리ToolStripMenuItem.Size = new System.Drawing.Size(109, 34);
            this.재고관리ToolStripMenuItem.Text = "재고관리";
            // 
            // 기초등록ToolStripMenuItem
            // 
            this.기초등록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.품목등록ToolStripMenuItem,
            this.거래처등록ToolStripMenuItem,
            this.사원등록ToolStripMenuItem});
            this.기초등록ToolStripMenuItem.Name = "기초등록ToolStripMenuItem";
            this.기초등록ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.기초등록ToolStripMenuItem.Text = "기초 등록";
            // 
            // 품목등록ToolStripMenuItem
            // 
            this.품목등록ToolStripMenuItem.Name = "품목등록ToolStripMenuItem";
            this.품목등록ToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.품목등록ToolStripMenuItem.Text = "품목 등록";
            this.품목등록ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 거래처등록ToolStripMenuItem
            // 
            this.거래처등록ToolStripMenuItem.Name = "거래처등록ToolStripMenuItem";
            this.거래처등록ToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.거래처등록ToolStripMenuItem.Text = "거래처 등록";
            this.거래처등록ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 사원등록ToolStripMenuItem
            // 
            this.사원등록ToolStripMenuItem.Name = "사원등록ToolStripMenuItem";
            this.사원등록ToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.사원등록ToolStripMenuItem.Text = "사원 등록";
            this.사원등록ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // bOMToolStripMenuItem
            // 
            this.bOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOM조회ToolStripMenuItem});
            this.bOMToolStripMenuItem.Name = "bOMToolStripMenuItem";
            this.bOMToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.bOMToolStripMenuItem.Text = "BOM";
            // 
            // bOM조회ToolStripMenuItem
            // 
            this.bOM조회ToolStripMenuItem.Name = "bOM조회ToolStripMenuItem";
            this.bOM조회ToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.bOM조회ToolStripMenuItem.Text = "BOM 조회";
            this.bOM조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 창고관리ToolStripMenuItem
            // 
            this.창고관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.창고조회ToolStripMenuItem,
            this.창고이동ToolStripMenuItem});
            this.창고관리ToolStripMenuItem.Name = "창고관리ToolStripMenuItem";
            this.창고관리ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.창고관리ToolStripMenuItem.Text = "창고 관리";
            // 
            // 창고조회ToolStripMenuItem
            // 
            this.창고조회ToolStripMenuItem.Name = "창고조회ToolStripMenuItem";
            this.창고조회ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.창고조회ToolStripMenuItem.Text = "창고 조회";
            this.창고조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 창고이동ToolStripMenuItem
            // 
            this.창고이동ToolStripMenuItem.Name = "창고이동ToolStripMenuItem";
            this.창고이동ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.창고이동ToolStripMenuItem.Text = "창고 이동";
            this.창고이동ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 구매관리ToolStripMenuItem
            // 
            this.구매관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.거래조회ToolStripMenuItem,
            this.진행중인거래ToolStripMenuItem});
            this.구매관리ToolStripMenuItem.Name = "구매관리ToolStripMenuItem";
            this.구매관리ToolStripMenuItem.Size = new System.Drawing.Size(159, 34);
            this.구매관리ToolStripMenuItem.Text = "판매/구매관리";
            // 
            // 거래조회ToolStripMenuItem
            // 
            this.거래조회ToolStripMenuItem.Name = "거래조회ToolStripMenuItem";
            this.거래조회ToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.거래조회ToolStripMenuItem.Text = "거래 조회";
            this.거래조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 진행중인거래ToolStripMenuItem
            // 
            this.진행중인거래ToolStripMenuItem.Name = "진행중인거래ToolStripMenuItem";
            this.진행중인거래ToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.진행중인거래ToolStripMenuItem.Text = "진행중인 거래조회";
            this.진행중인거래ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 회계관리ToolStripMenuItem
            // 
            this.회계관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.전표관리ToolStripMenuItem,
            this.장부관리ToolStripMenuItem});
            this.회계관리ToolStripMenuItem.Name = "회계관리ToolStripMenuItem";
            this.회계관리ToolStripMenuItem.Size = new System.Drawing.Size(109, 34);
            this.회계관리ToolStripMenuItem.Text = "회계관리";
            // 
            // 전표관리ToolStripMenuItem
            // 
            this.전표관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.전표조회ToolStripMenuItem,
            this.전표인새ㅗToolStripMenuItem});
            this.전표관리ToolStripMenuItem.Name = "전표관리ToolStripMenuItem";
            this.전표관리ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.전표관리ToolStripMenuItem.Text = "전표 관리";
            // 
            // 전표조회ToolStripMenuItem
            // 
            this.전표조회ToolStripMenuItem.Name = "전표조회ToolStripMenuItem";
            this.전표조회ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.전표조회ToolStripMenuItem.Text = "전표 조회";
            this.전표조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 전표인새ㅗToolStripMenuItem
            // 
            this.전표인새ㅗToolStripMenuItem.Name = "전표인새ㅗToolStripMenuItem";
            this.전표인새ㅗToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.전표인새ㅗToolStripMenuItem.Text = "전표 인쇄";
            this.전표인새ㅗToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 장부관리ToolStripMenuItem
            // 
            this.장부관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.매출관리ToolStripMenuItem,
            this.매입관리ToolStripMenuItem});
            this.장부관리ToolStripMenuItem.Name = "장부관리ToolStripMenuItem";
            this.장부관리ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.장부관리ToolStripMenuItem.Text = "장부 관리";
            // 
            // 매출관리ToolStripMenuItem
            // 
            this.매출관리ToolStripMenuItem.Name = "매출관리ToolStripMenuItem";
            this.매출관리ToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.매출관리ToolStripMenuItem.Text = "매출청구서 조회";
            this.매출관리ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 매입관리ToolStripMenuItem
            // 
            this.매입관리ToolStripMenuItem.Name = "매입관리ToolStripMenuItem";
            this.매입관리ToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.매입관리ToolStripMenuItem.Text = "매입청구서 조회";
            this.매입관리ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvnet);
            // 
            // 생산관리ToolStripMenuItem
            // 
            this.생산관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.견적서분석ToolStripMenuItem});
            this.생산관리ToolStripMenuItem.Name = "생산관리ToolStripMenuItem";
            this.생산관리ToolStripMenuItem.Size = new System.Drawing.Size(109, 34);
            this.생산관리ToolStripMenuItem.Text = "생산관리";
            // 
            // 견적서분석ToolStripMenuItem
            // 
            this.견적서분석ToolStripMenuItem.Name = "견적서분석ToolStripMenuItem";
            this.견적서분석ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.견적서분석ToolStripMenuItem.Text = "견적 조회";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(2032, 1060);
            this.splitContainer2.SplitterDistance = 1470;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2032, 1060);
            this.Controls.Add(this.splitContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniErp_Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {


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
        private System.Windows.Forms.ToolStripMenuItem 재고관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기초등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구매관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회계관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전표관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전표조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전표인새ㅗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장부관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매입관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 생산관리ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem bOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 진행중인거래ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 거래처등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOM조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem 견적서분석ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창고관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창고조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창고이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 거래조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사원등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem 사원조회ToolStripMenuItem;
        private ToolTip toolTip1;
    }
}

