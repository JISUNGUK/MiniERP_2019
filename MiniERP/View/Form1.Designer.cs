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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영업ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_OrdM_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Accountregistration = new System.Windows.Forms.ToolStripMenuItem();
            this.사원조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.물류관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.견적서조회ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.생산계획서조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.입고확인서조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출고확인서조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.물류조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기초등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.품목등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.거래처등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사원등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창고등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOM조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창고관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창고조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창고이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.출력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.품목ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.생산관리ToolStripMenuItem,
            this.출력ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1835, 42);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(119, 34);
            this.mainToolStripMenuItem.Text = "MainPage";
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
            this.tsm_OrdM_inquiry.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // tsm_Accountregistration
            // 
            this.tsm_Accountregistration.Name = "tsm_Accountregistration";
            this.tsm_Accountregistration.Size = new System.Drawing.Size(216, 34);
            this.tsm_Accountregistration.Text = "거래처 조회";
            this.tsm_Accountregistration.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 사원조회ToolStripMenuItem
            // 
            this.사원조회ToolStripMenuItem.Name = "사원조회ToolStripMenuItem";
            this.사원조회ToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.사원조회ToolStripMenuItem.Text = "사원 조회";
            this.사원조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 물류관리ToolStripMenuItem
            // 
            this.물류관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.견적서조회ToolStripMenuItem1,
            this.생산계획서조회ToolStripMenuItem,
            this.입고확인서조회ToolStripMenuItem,
            this.출고확인서조회ToolStripMenuItem,
            this.물류조회ToolStripMenuItem});
            this.물류관리ToolStripMenuItem.Name = "물류관리ToolStripMenuItem";
            this.물류관리ToolStripMenuItem.Size = new System.Drawing.Size(109, 34);
            this.물류관리ToolStripMenuItem.Text = "물류관리";
            // 
            // 견적서조회ToolStripMenuItem1
            // 
            this.견적서조회ToolStripMenuItem1.Name = "견적서조회ToolStripMenuItem1";
            this.견적서조회ToolStripMenuItem1.Size = new System.Drawing.Size(288, 34);
            this.견적서조회ToolStripMenuItem1.Text = "견적서 조회";
            this.견적서조회ToolStripMenuItem1.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 생산계획서조회ToolStripMenuItem
            // 
            this.생산계획서조회ToolStripMenuItem.Name = "생산계획서조회ToolStripMenuItem";
            this.생산계획서조회ToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.생산계획서조회ToolStripMenuItem.Text = "생산계획서 조회";
            this.생산계획서조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 입고확인서조회ToolStripMenuItem
            // 
            this.입고확인서조회ToolStripMenuItem.Name = "입고확인서조회ToolStripMenuItem";
            this.입고확인서조회ToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.입고확인서조회ToolStripMenuItem.Text = "입고확인서 조회";
            this.입고확인서조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 출고확인서조회ToolStripMenuItem
            // 
            this.출고확인서조회ToolStripMenuItem.Name = "출고확인서조회ToolStripMenuItem";
            this.출고확인서조회ToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.출고확인서조회ToolStripMenuItem.Text = "출고확인서 조회";
            this.출고확인서조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 물류조회ToolStripMenuItem
            // 
            this.물류조회ToolStripMenuItem.Name = "물류조회ToolStripMenuItem";
            this.물류조회ToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.물류조회ToolStripMenuItem.Text = "물류 조회";
            this.물류조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 재고관리ToolStripMenuItem
            // 
            this.재고관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기초등록ToolStripMenuItem,
            this.bOMToolStripMenuItem,
            this.창고관리ToolStripMenuItem,
            this.재고ToolStripMenuItem});
            this.재고관리ToolStripMenuItem.Name = "재고관리ToolStripMenuItem";
            this.재고관리ToolStripMenuItem.Size = new System.Drawing.Size(109, 34);
            this.재고관리ToolStripMenuItem.Text = "재고관리";
            // 
            // 기초등록ToolStripMenuItem
            // 
            this.기초등록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.품목등록ToolStripMenuItem,
            this.거래처등록ToolStripMenuItem,
            this.사원등록ToolStripMenuItem,
            this.창고등록ToolStripMenuItem});
            this.기초등록ToolStripMenuItem.Name = "기초등록ToolStripMenuItem";
            this.기초등록ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.기초등록ToolStripMenuItem.Text = "기초 등록";
            // 
            // 품목등록ToolStripMenuItem
            // 
            this.품목등록ToolStripMenuItem.Name = "품목등록ToolStripMenuItem";
            this.품목등록ToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.품목등록ToolStripMenuItem.Text = "품목 등록";
            this.품목등록ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 거래처등록ToolStripMenuItem
            // 
            this.거래처등록ToolStripMenuItem.Name = "거래처등록ToolStripMenuItem";
            this.거래처등록ToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.거래처등록ToolStripMenuItem.Text = "거래처 등록";
            this.거래처등록ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 사원등록ToolStripMenuItem
            // 
            this.사원등록ToolStripMenuItem.Name = "사원등록ToolStripMenuItem";
            this.사원등록ToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.사원등록ToolStripMenuItem.Text = "사원 등록";
            this.사원등록ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 창고등록ToolStripMenuItem
            // 
            this.창고등록ToolStripMenuItem.Name = "창고등록ToolStripMenuItem";
            this.창고등록ToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.창고등록ToolStripMenuItem.Text = "창고 등록";
            this.창고등록ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
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
            this.bOM조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
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
            this.창고조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 창고이동ToolStripMenuItem
            // 
            this.창고이동ToolStripMenuItem.Name = "창고이동ToolStripMenuItem";
            this.창고이동ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.창고이동ToolStripMenuItem.Text = "창고 이동";
            this.창고이동ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 재고ToolStripMenuItem
            // 
            this.재고ToolStripMenuItem.Name = "재고ToolStripMenuItem";
            this.재고ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.재고ToolStripMenuItem.Text = "재고 조회";
            this.재고ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
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
            this.거래조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 진행중인거래ToolStripMenuItem
            // 
            this.진행중인거래ToolStripMenuItem.Name = "진행중인거래ToolStripMenuItem";
            this.진행중인거래ToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.진행중인거래ToolStripMenuItem.Text = "진행중인 거래조회";
            this.진행중인거래ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
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
            this.전표조회ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 전표인새ㅗToolStripMenuItem
            // 
            this.전표인새ㅗToolStripMenuItem.Name = "전표인새ㅗToolStripMenuItem";
            this.전표인새ㅗToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.전표인새ㅗToolStripMenuItem.Text = "전표 인쇄";
            this.전표인새ㅗToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
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
            this.매출관리ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 매입관리ToolStripMenuItem
            // 
            this.매입관리ToolStripMenuItem.Name = "매입관리ToolStripMenuItem";
            this.매입관리ToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.매입관리ToolStripMenuItem.Text = "매입청구서 조회";
            this.매입관리ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
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
            this.견적서분석ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 출력ToolStripMenuItem
            // 
            this.출력ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.품목ToolStripMenuItem});
            this.출력ToolStripMenuItem.Name = "출력ToolStripMenuItem";
            this.출력ToolStripMenuItem.Size = new System.Drawing.Size(67, 34);
            this.출력ToolStripMenuItem.Text = "출력";
            // 
            // 품목ToolStripMenuItem
            // 
            this.품목ToolStripMenuItem.Name = "품목ToolStripMenuItem";
            this.품목ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.품목ToolStripMenuItem.Text = "품목 출력";
            this.품목ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(236, 281);
            this.toolStripContainer1.Location = new System.Drawing.Point(1006, 696);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(236, 306);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1835, 1090);
            this.tabControl1.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1835, 1140);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1835, 1140);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MiniErp_Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

#endregion
        private System.Windows.Forms.Timer timer1;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainToolStripMenuItem;
        private ToolStripMenuItem 영업ToolStripMenuItem;
        private ToolStripMenuItem tsm_OrdM_inquiry;
        private ToolStripMenuItem tsm_Accountregistration;
        private ToolStripMenuItem 사원조회ToolStripMenuItem;
        private ToolStripMenuItem 물류관리ToolStripMenuItem;
        private ToolStripMenuItem 견적서조회ToolStripMenuItem1;
        private ToolStripMenuItem 생산계획서조회ToolStripMenuItem;
        private ToolStripMenuItem 재고관리ToolStripMenuItem;
        private ToolStripMenuItem 기초등록ToolStripMenuItem;
        private ToolStripMenuItem 품목등록ToolStripMenuItem;
        private ToolStripMenuItem 거래처등록ToolStripMenuItem;
        private ToolStripMenuItem 사원등록ToolStripMenuItem;
        private ToolStripMenuItem 창고등록ToolStripMenuItem;
        private ToolStripMenuItem bOMToolStripMenuItem;
        private ToolStripMenuItem bOM조회ToolStripMenuItem;
        private ToolStripMenuItem 창고관리ToolStripMenuItem;
        private ToolStripMenuItem 창고조회ToolStripMenuItem;
        private ToolStripMenuItem 창고이동ToolStripMenuItem;
        private ToolStripMenuItem 구매관리ToolStripMenuItem;
        private ToolStripMenuItem 거래조회ToolStripMenuItem;
        private ToolStripMenuItem 진행중인거래ToolStripMenuItem;
        private ToolStripMenuItem 회계관리ToolStripMenuItem;
        private ToolStripMenuItem 전표관리ToolStripMenuItem;
        private ToolStripMenuItem 전표조회ToolStripMenuItem;
        private ToolStripMenuItem 전표인새ㅗToolStripMenuItem;
        private ToolStripMenuItem 장부관리ToolStripMenuItem;
        private ToolStripMenuItem 매출관리ToolStripMenuItem;
        private ToolStripMenuItem 매입관리ToolStripMenuItem;
        private ToolStripMenuItem 생산관리ToolStripMenuItem;
        private ToolStripMenuItem 견적서분석ToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private TabControl tabControl1;
        private SplitContainer splitContainer1;
        private ToolStripMenuItem 입고확인서조회ToolStripMenuItem;
        private ToolStripMenuItem 출력ToolStripMenuItem;
        private ToolStripMenuItem 품목ToolStripMenuItem;
        private ToolStripMenuItem 재고ToolStripMenuItem;
        private ToolStripMenuItem 물류조회ToolStripMenuItem;
        private ToolStripMenuItem 출고확인서조회ToolStripMenuItem;
    }
}

