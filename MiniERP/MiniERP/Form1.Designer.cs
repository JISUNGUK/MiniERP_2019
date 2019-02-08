namespace MiniERP
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
            this.panel_MesMap = new System.Windows.Forms.Panel();

            this.Panal_Main = new System.Windows.Forms.Panel();
            this.panel_Mdi = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.영업ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_OrdM_inquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Accountregistration = new System.Windows.Forms.ToolStripMenuItem();
            this.판매조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.물류관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.견적서조회ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.생산계획서조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출하확인서조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기초등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.품목등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창고등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.품목별단가조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자재관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구매관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구매조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
<<<<<<< HEAD
            this.Panal_Main.SuspendLayout();
            this.menuStrip1.SuspendLayout();
=======
>>>>>>> c74be342948238250c9bfeb4e5213f23bf00dd23
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
            this.splitContainer1.Panel1.Controls.Add(this.panel_MesMap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Panal_Main);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel_MesMap
            // 
            this.panel_MesMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MesMap.Location = new System.Drawing.Point(0, 0);
            this.panel_MesMap.Name = "panel_MesMap";
            this.panel_MesMap.Size = new System.Drawing.Size(421, 681);
            this.panel_MesMap.TabIndex = 0;
            // 
            // Panal_Main
            // 
            this.Panal_Main.BackColor = System.Drawing.Color.Gray;
            this.Panal_Main.Controls.Add(this.panel_Mdi);
            this.Panal_Main.Controls.Add(this.menuStrip1);
            this.Panal_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panal_Main.Location = new System.Drawing.Point(0, 0);
            this.Panal_Main.Name = "Panal_Main";
            this.Panal_Main.Size = new System.Drawing.Size(839, 681);
            this.Panal_Main.TabIndex = 0;
            // 
            // panel_Mdi
            // 
            this.panel_Mdi.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel_Mdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Mdi.Location = new System.Drawing.Point(0, 24);
            this.panel_Mdi.Name = "panel_Mdi";
            this.panel_Mdi.Size = new System.Drawing.Size(839, 657);
            this.panel_Mdi.TabIndex = 1;
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 영업ToolStripMenuItem
            // 
            this.영업ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_OrdM_inquiry,
            this.tsm_Accountregistration,
            this.판매조회ToolStripMenuItem});
            this.영업ToolStripMenuItem.Name = "영업ToolStripMenuItem";
            this.영업ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.영업ToolStripMenuItem.Text = "영업관리";
            // 
            // tsm_OrdM_inquiry
            // 
            this.tsm_OrdM_inquiry.Name = "tsm_OrdM_inquiry";
            this.tsm_OrdM_inquiry.Size = new System.Drawing.Size(180, 22);
            this.tsm_OrdM_inquiry.Text = "주문 조회";
            this.tsm_OrdM_inquiry.Click += new System.EventHandler(this.tsm_OrdM_inquiry_Click);
            // 
            // tsm_Accountregistration
            // 
<<<<<<< HEAD
            this.tsm_Accountregistration.Name = "tsm_Accountregistration";
            this.tsm_Accountregistration.Size = new System.Drawing.Size(180, 22);
            this.tsm_Accountregistration.Text = "거래처 등록";
            // 
            // 판매조회ToolStripMenuItem
            // 
            this.판매조회ToolStripMenuItem.Name = "판매조회ToolStripMenuItem";
            this.판매조회ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.판매조회ToolStripMenuItem.Text = "판매조회";
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
            this.견적서조회ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.견적서조회ToolStripMenuItem1.Text = "견적서 조회";
            this.견적서조회ToolStripMenuItem1.Click += new System.EventHandler(this.견적서조회ToolStripMenuItem1_Click);
            // 
            // 생산계획서조회ToolStripMenuItem
            // 
            this.생산계획서조회ToolStripMenuItem.Name = "생산계획서조회ToolStripMenuItem";
            this.생산계획서조회ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.생산계획서조회ToolStripMenuItem.Text = "생산 계획서 조회";
            // 
            // 출하확인서조회ToolStripMenuItem
            // 
            this.출하확인서조회ToolStripMenuItem.Name = "출하확인서조회ToolStripMenuItem";
            this.출하확인서조회ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.출하확인서조회ToolStripMenuItem.Text = "출하 확인서 조회";
            // 
            // 재고관리ToolStripMenuItem
            // 
            this.재고관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기초등록ToolStripMenuItem,
            this.자재관리ToolStripMenuItem,
            this.기타이동ToolStripMenuItem});
            this.재고관리ToolStripMenuItem.Name = "재고관리ToolStripMenuItem";
            this.재고관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.재고관리ToolStripMenuItem.Text = "재고관리";
            // 
            // 기초등록ToolStripMenuItem
            // 
            this.기초등록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.품목등록ToolStripMenuItem,
            this.창고등록ToolStripMenuItem,
            this.품목별단가조회ToolStripMenuItem});
            this.기초등록ToolStripMenuItem.Name = "기초등록ToolStripMenuItem";
            this.기초등록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.기초등록ToolStripMenuItem.Text = "기초등록";
            // 
            // 품목등록ToolStripMenuItem
            // 
            this.품목등록ToolStripMenuItem.Name = "품목등록ToolStripMenuItem";
            this.품목등록ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.품목등록ToolStripMenuItem.Text = "품목 등록";
            // 
            // 창고등록ToolStripMenuItem
            // 
            this.창고등록ToolStripMenuItem.Name = "창고등록ToolStripMenuItem";
            this.창고등록ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.창고등록ToolStripMenuItem.Text = "창고 등록";
            // 
            // 품목별단가조회ToolStripMenuItem
            // 
            this.품목별단가조회ToolStripMenuItem.Name = "품목별단가조회ToolStripMenuItem";
            this.품목별단가조회ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.품목별단가조회ToolStripMenuItem.Text = "품목별 단가 조회";
            // 
            // 자재관리ToolStripMenuItem
            // 
            this.자재관리ToolStripMenuItem.Name = "자재관리ToolStripMenuItem";
            this.자재관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.자재관리ToolStripMenuItem.Text = "자재관리";
            // 
            // 기타이동ToolStripMenuItem
            // 
            this.기타이동ToolStripMenuItem.Name = "기타이동ToolStripMenuItem";
            this.기타이동ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.기타이동ToolStripMenuItem.Text = "기타이동";
            // 
            // 구매관리ToolStripMenuItem
            // 
            this.구매관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.구매조회ToolStripMenuItem});
            this.구매관리ToolStripMenuItem.Name = "구매관리ToolStripMenuItem";
            this.구매관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.구매관리ToolStripMenuItem.Text = "구매관리";
            // 
            // 구매조회ToolStripMenuItem
            // 
            this.구매조회ToolStripMenuItem.Name = "구매조회ToolStripMenuItem";
            this.구매조회ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.구매조회ToolStripMenuItem.Text = "구매조회";
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
            this.장부조회ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.장부조회ToolStripMenuItem.Text = "매입매출거래";
            // 
            // 전표관리ToolStripMenuItem
            // 
            this.전표관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.전표조회ToolStripMenuItem,
            this.전표인새ㅗToolStripMenuItem});
            this.전표관리ToolStripMenuItem.Name = "전표관리ToolStripMenuItem";
            this.전표관리ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.전표관리ToolStripMenuItem.Text = "전표관리";
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
            this.장부관리ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.장부관리ToolStripMenuItem.Text = "장부관리";
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
=======
            this.panel_MesMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MesMap.Location = new System.Drawing.Point(0, 0);
            this.panel_MesMap.Name = "panel_MesMap";
            this.panel_MesMap.Size = new System.Drawing.Size(244, 503);
            this.panel_MesMap.TabIndex = 1;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPage3);
            this.tabMenu.Controls.Add(this.tabPage4);
            this.tabMenu.Controls.Add(this.Bom);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(485, 503);
            this.tabMenu.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.btn_Enroll);
            this.tabPage3.Controls.Add(this.menu_1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(477, 477);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "재고 I";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(362, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 25);
            this.button5.TabIndex = 5;
            this.button5.Text = "기타 이동";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_Enroll_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(273, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 25);
            this.button4.TabIndex = 4;
            this.button4.Text = "생산";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_Enroll_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "구매 관리";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Enroll_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "영업 관리";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Enroll_Click);
            // 
            // btn_Enroll
            // 
            this.btn_Enroll.Location = new System.Drawing.Point(6, 6);
            this.btn_Enroll.Name = "btn_Enroll";
            this.btn_Enroll.Size = new System.Drawing.Size(83, 25);
            this.btn_Enroll.TabIndex = 1;
            this.btn_Enroll.Text = "기초등록";
            this.btn_Enroll.UseVisualStyleBackColor = true;
            this.btn_Enroll.Click += new System.EventHandler(this.btn_Enroll_Click);
            // 
            // menu_1
            // 
            this.menu_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_1.Location = new System.Drawing.Point(3, 3);
            this.menu_1.Name = "menu_1";
            this.menu_1.Size = new System.Drawing.Size(471, 31);
            this.menu_1.TabIndex = 0;
            this.menu_1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.menu_2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(477, 477);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "재고 II";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 25);
            this.button6.TabIndex = 2;
            this.button6.Text = "A/S 관리";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // menu_2
            // 
            this.menu_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_2.Location = new System.Drawing.Point(3, 3);
            this.menu_2.Name = "menu_2";
            this.menu_2.Size = new System.Drawing.Size(471, 31);
            this.menu_2.TabIndex = 1;
            this.menu_2.TabStop = false;
            // 
            // panel_Enroll
            // 
            this.panel_Enroll.Controls.Add(this.button11);
            this.panel_Enroll.Controls.Add(this.button10);
            this.panel_Enroll.Controls.Add(this.button9);
            this.panel_Enroll.Controls.Add(this.button8);
            this.panel_Enroll.Controls.Add(this.button7);
            this.panel_Enroll.Controls.Add(this.button1);
            this.panel_Enroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Enroll.Location = new System.Drawing.Point(0, 0);
            this.panel_Enroll.Name = "panel_Enroll";
            this.panel_Enroll.Size = new System.Drawing.Size(226, 503);
            this.panel_Enroll.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(3, 300);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(223, 28);
            this.button11.TabIndex = 5;
            this.button11.Text = "A/S등록";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 258);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(223, 28);
            this.button10.TabIndex = 4;
            this.button10.Text = "사원(담당) 등록";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 216);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(223, 28);
            this.button9.TabIndex = 3;
            this.button9.Text = "품목별 단가";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 174);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(223, 28);
            this.button8.TabIndex = 2;
            this.button8.Text = "품목 등록";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(223, 28);
            this.button7.TabIndex = 1;
            this.button7.Text = "창고 등록";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "거래처 등록";
            this.button1.UseVisualStyleBackColor = true;

            this.Bom.Controls.Add(this.splitContainer1);
            this.Bom.Location = new System.Drawing.Point(4, 22);
            this.Bom.Name = "Bom";
            this.Bom.Size = new System.Drawing.Size(477, 477);
            this.Bom.TabIndex = 2;
            this.Bom.Text = "BOM";
            this.Bom.UseVisualStyleBackColor = true;
            // 
            // BomGridview
            // 
            this.BomGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BomGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BomGridview.Location = new System.Drawing.Point(0, 0);
            this.BomGridview.Name = "BomGridview";
            this.BomGridview.RowTemplate.Height = 23;
            this.BomGridview.Size = new System.Drawing.Size(473, 406);
            this.BomGridview.TabIndex = 0;
            this.BomGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BomGridview_CellClick);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(395, 5);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 8;
            this.export.Text = "증명서출력";
            this.export.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(254, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 7;
            this.button12.Text = "삭제";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(129, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 6;
            this.button13.Text = "수정";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(24, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 5;
            this.button14.Text = "등록";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Allchecked);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.search);
            this.splitContainer1.Panel1.Controls.Add(this.button14);
            this.splitContainer1.Panel1.Controls.Add(this.export);
            this.splitContainer1.Panel1.Controls.Add(this.button13);
            this.splitContainer1.Panel1.Controls.Add(this.button12);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BomGridview);
            this.splitContainer1.Size = new System.Drawing.Size(473, 474);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 9;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(395, 34);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 10;
            this.search.Text = "검색";
            this.search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 21);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "상품명";
            // 
            // Allchecked
            // 
            this.Allchecked.AutoSize = true;
            this.Allchecked.Location = new System.Drawing.Point(24, 34);
            this.Allchecked.Name = "Allchecked";
            this.Allchecked.Size = new System.Drawing.Size(72, 16);
            this.Allchecked.TabIndex = 13;
            this.Allchecked.Text = "제품전체";
            this.Allchecked.UseVisualStyleBackColor = true;
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
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Panal_Main.ResumeLayout(false);
            this.Panal_Main.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
=======
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel_Enroll.ResumeLayout(false);
            this.Bom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BomGridview)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
>>>>>>> c74be342948238250c9bfeb4e5213f23bf00dd23
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel Panal_Main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 회계관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장부조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전표관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재고관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기초등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창고등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 물류관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 영업ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_OrdM_inquiry;
        private System.Windows.Forms.ToolStripMenuItem tsm_Accountregistration;
        private System.Windows.Forms.ToolStripMenuItem 견적서조회ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 생산계획서조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출하확인서조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목별단가조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자재관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기타이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전표조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전표인새ㅗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장부관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매입관리ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_MesMap;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStripMenuItem 구매관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 생산관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구매조회ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Mdi;
=======
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Splitter menu_1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Splitter menu_2;
        private System.Windows.Forms.Button btn_Enroll;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_Enroll;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Bom;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox Allchecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridView BomGridview;
>>>>>>> c74be342948238250c9bfeb4e5213f23bf00dd23
    }
}

