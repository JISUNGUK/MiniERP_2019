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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.roomName = new System.Windows.Forms.Label();
            this.memberList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomList = new System.Windows.Forms.ComboBox();
            this.mkRoom = new System.Windows.Forms.Button();
            this.rmRoom = new System.Windows.Forms.Button();
            this.ChatContent = new System.Windows.Forms.RichTextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.sendMsg = new System.Windows.Forms.Button();
            this.imageButton = new System.Windows.Forms.Button();
            this.imageLabel = new System.Windows.Forms.Label();
            this.nicname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.access = new System.Windows.Forms.Button();
            this.particiRoom = new System.Windows.Forms.Button();
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
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1116, 681);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 681);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(319, 25);
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
            this.Panal_Main.Name = "Panal_Main";
            this.Panal_Main.Size = new System.Drawing.Size(793, 681);
            this.Panal_Main.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 657);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
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
            this.기초등록ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
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
            this.자재관리ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.자재관리ToolStripMenuItem.Text = "자재 관리";
            // 
            // 기타이동ToolStripMenuItem
            // 
            this.기타이동ToolStripMenuItem.Name = "기타이동ToolStripMenuItem";
            this.기타이동ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.기타이동ToolStripMenuItem.Text = "기타 이동";
            // 
            // bOMToolStripMenuItem
            // 
            this.bOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOM조회ToolStripMenuItem});
            this.bOMToolStripMenuItem.Name = "bOMToolStripMenuItem";
            this.bOMToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.bOMToolStripMenuItem.Text = "BOM";
            // 
            // bOM조회ToolStripMenuItem
            // 
            this.bOM조회ToolStripMenuItem.Name = "bOM조회ToolStripMenuItem";
            this.bOM조회ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
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
            this.구매조회ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
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
            this.판매ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
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
            this.장부관리ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
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
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.particiRoom);
            this.splitContainer2.Panel2.Controls.Add(this.access);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.nicname);
            this.splitContainer2.Panel2.Controls.Add(this.imageLabel);
            this.splitContainer2.Panel2.Controls.Add(this.imageButton);
            this.splitContainer2.Panel2.Controls.Add(this.sendMsg);
            this.splitContainer2.Panel2.Controls.Add(this.message);
            this.splitContainer2.Panel2.Controls.Add(this.ChatContent);
            this.splitContainer2.Panel2.Controls.Add(this.rmRoom);
            this.splitContainer2.Panel2.Controls.Add(this.mkRoom);
            this.splitContainer2.Panel2.Controls.Add(this.roomList);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.memberList);
            this.splitContainer2.Panel2.Controls.Add(this.roomName);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1461, 681);
            this.splitContainer2.SplitterDistance = 1116;
            this.splitContainer2.TabIndex = 3;
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Location = new System.Drawing.Point(11, 142);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(49, 12);
            this.roomName.TabIndex = 0;
            this.roomName.Text = "방 이름:";
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.ItemHeight = 12;
            this.memberList.Location = new System.Drawing.Point(101, 37);
            this.memberList.Name = "memberList";
            this.memberList.ScrollAlwaysVisible = true;
            this.memberList.Size = new System.Drawing.Size(237, 76);
            this.memberList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "사용자목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "방목록";
            // 
            // roomList
            // 
            this.roomList.FormattingEnabled = true;
            this.roomList.Location = new System.Drawing.Point(101, 119);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(237, 20);
            this.roomList.TabIndex = 4;
            // 
            // mkRoom
            // 
            this.mkRoom.Location = new System.Drawing.Point(13, 169);
            this.mkRoom.Name = "mkRoom";
            this.mkRoom.Size = new System.Drawing.Size(63, 23);
            this.mkRoom.TabIndex = 5;
            this.mkRoom.Text = "방생성";
            this.mkRoom.UseVisualStyleBackColor = true;
            this.mkRoom.Click += new System.EventHandler(this.mkRoom_Click);
            // 
            // rmRoom
            // 
            this.rmRoom.Enabled = false;
            this.rmRoom.Location = new System.Drawing.Point(264, 169);
            this.rmRoom.Name = "rmRoom";
            this.rmRoom.Size = new System.Drawing.Size(65, 23);
            this.rmRoom.TabIndex = 6;
            this.rmRoom.Text = "방제거";
            this.rmRoom.UseVisualStyleBackColor = true;
            this.rmRoom.Visible = false;
            // 
            // ChatContent
            // 
            this.ChatContent.Location = new System.Drawing.Point(13, 198);
            this.ChatContent.Name = "ChatContent";
            this.ChatContent.Size = new System.Drawing.Size(316, 365);
            this.ChatContent.TabIndex = 7;
            this.ChatContent.Text = "";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(13, 584);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(231, 21);
            this.message.TabIndex = 8;
            this.message.KeyUp += new System.Windows.Forms.KeyEventHandler(this.message_KeyUp);
            // 
            // sendMsg
            // 
            this.sendMsg.Location = new System.Drawing.Point(250, 582);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(87, 23);
            this.sendMsg.TabIndex = 9;
            this.sendMsg.Text = "전송";
            this.sendMsg.UseVisualStyleBackColor = true;
            this.sendMsg.Click += new System.EventHandler(this.sendMsg_Click);
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(250, 625);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(87, 23);
            this.imageButton.TabIndex = 10;
            this.imageButton.Text = "이미지 첨부";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(11, 625);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(73, 12);
            this.imageLabel.TabIndex = 11;
            this.imageLabel.Text = "첨부 이미지:";
            this.imageLabel.Click += new System.EventHandler(this.imageLabel_Click);
            // 
            // nicname
            // 
            this.nicname.Location = new System.Drawing.Point(101, 4);
            this.nicname.Name = "nicname";
            this.nicname.Size = new System.Drawing.Size(148, 21);
            this.nicname.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "사용자이름";
            // 
            // access
            // 
            this.access.Location = new System.Drawing.Point(274, 2);
            this.access.Name = "access";
            this.access.Size = new System.Drawing.Size(63, 23);
            this.access.TabIndex = 14;
            this.access.Text = "접속";
            this.access.UseVisualStyleBackColor = true;
            this.access.Click += new System.EventHandler(this.access_Click);
            // 
            // particiRoom
            // 
            this.particiRoom.Location = new System.Drawing.Point(264, 142);
            this.particiRoom.Name = "particiRoom";
            this.particiRoom.Size = new System.Drawing.Size(63, 23);
            this.particiRoom.TabIndex = 15;
            this.particiRoom.Text = "방참가";
            this.particiRoom.UseVisualStyleBackColor = true;
            this.particiRoom.Click += new System.EventHandler(this.particiRoom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 681);
            this.Controls.Add(this.splitContainer2);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem 구매조회ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 구매입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 거래처등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOM조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Button sendMsg;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.RichTextBox ChatContent;
        private System.Windows.Forms.Button rmRoom;
        private System.Windows.Forms.Button mkRoom;
        private System.Windows.Forms.ComboBox roomList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox memberList;
        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.Button access;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nicname;
        private System.Windows.Forms.Button particiRoom;
    }
}

