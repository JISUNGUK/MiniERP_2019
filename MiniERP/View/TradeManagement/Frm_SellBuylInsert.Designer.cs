namespace MiniERP.View.TradeManagement
{
    partial class Frm_SellBuyInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SellBuyInsert));
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gView_Order = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Cleaner = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ClerkCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_Clerk = new System.Windows.Forms.Button();
            this.btn_Business = new System.Windows.Forms.Button();
            this.btn_Warehouse = new System.Windows.Forms.Button();
            this.txt_WareCode = new System.Windows.Forms.TextBox();
            this.lab_Warehouse = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdo_Sell = new System.Windows.Forms.RadioButton();
            this.rdo_Buy = new System.Windows.Forms.RadioButton();
            this.btn_ItemAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ItemDelete = new System.Windows.Forms.Button();
            this.txt_ClerkName = new System.Windows.Forms.TextBox();
            this.txt_WareName = new System.Windows.Forms.TextBox();
            this.txt_BusinessName = new System.Windows.Forms.TextBox();
            this.txt_BusinessCode = new System.Windows.Forms.TextBox();
            this.lab_TotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gView_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 30);
            this.button4.TabIndex = 109;
            this.button4.Text = "등록";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(694, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 23);
            this.button5.TabIndex = 106;
            this.button5.Text = "??";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(26, -63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 124;
            this.label4.Text = "구매입력";
            // 
            // gView_Order
            // 
            this.gView_Order.AllowUserToAddRows = false;
            this.gView_Order.AllowUserToDeleteRows = false;
            this.gView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gView_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.totalFee});
            this.gView_Order.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gView_Order.Location = new System.Drawing.Point(21, 107);
            this.gView_Order.Name = "gView_Order";
            this.gView_Order.RowHeadersVisible = false;
            this.gView_Order.RowTemplate.Height = 23;
            this.gView_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gView_Order.Size = new System.Drawing.Size(749, 263);
            this.gView_Order.TabIndex = 123;
            this.gView_Order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gView_Order_CellClick);
            this.gView_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gView_Order_CellContentClick);
            this.gView_Order.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gView_Order_RowsAdded);
            this.gView_Order.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gView_Order_RowsRemoved);
            // 
            // Select
            // 
            this.Select.HeaderText = "선택";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "품목코드";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "품목명";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "규격";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "박스/롤/Carton";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "수량";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "단가";
            this.Column7.Name = "Column7";
            // 
            // totalFee
            // 
            this.totalFee.HeaderText = "총액";
            this.totalFee.Name = "totalFee";
            // 
            // btn_Cleaner
            // 
            this.btn_Cleaner.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Cleaner.Location = new System.Drawing.Point(120, 386);
            this.btn_Cleaner.Name = "btn_Cleaner";
            this.btn_Cleaner.Size = new System.Drawing.Size(75, 23);
            this.btn_Cleaner.TabIndex = 122;
            this.btn_Cleaner.Text = "다시작성";
            this.btn_Cleaner.UseVisualStyleBackColor = true;
            this.btn_Cleaner.Click += new System.EventHandler(this.btn_Cleaner_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Save.Location = new System.Drawing.Point(21, 386);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 121;
            this.btn_Save.Text = "저장";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(408, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 118;
            this.label3.Text = "거래처";
            // 
            // txt_ClerkCode
            // 
            this.txt_ClerkCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ClerkCode.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_ClerkCode.Location = new System.Drawing.Point(95, 13);
            this.txt_ClerkCode.Name = "txt_ClerkCode";
            this.txt_ClerkCode.ReadOnly = true;
            this.txt_ClerkCode.Size = new System.Drawing.Size(100, 23);
            this.txt_ClerkCode.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 115;
            this.label2.Text = "담당자";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("굴림", 10F);
            this.textBox3.Location = new System.Drawing.Point(507, -31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(268, 23);
            this.textBox3.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(390, -28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 112;
            this.label5.Text = "거래처";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("굴림", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(107, -35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 23);
            this.dateTimePicker1.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F);
            this.label6.Location = new System.Drawing.Point(26, -28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 110;
            this.label6.Text = "일자";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("굴림", 10F);
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(471, -37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 30);
            this.button7.TabIndex = 114;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn_Clerk
            // 
            this.btn_Clerk.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.btn_Clerk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clerk.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Clerk.Location = new System.Drawing.Point(355, 13);
            this.btn_Clerk.Name = "btn_Clerk";
            this.btn_Clerk.Size = new System.Drawing.Size(25, 25);
            this.btn_Clerk.TabIndex = 125;
            this.btn_Clerk.UseVisualStyleBackColor = true;
            this.btn_Clerk.Click += new System.EventHandler(this.btn_Text_Click);
            // 
            // btn_Business
            // 
            this.btn_Business.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.btn_Business.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Business.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Business.Location = new System.Drawing.Point(744, 13);
            this.btn_Business.Name = "btn_Business";
            this.btn_Business.Size = new System.Drawing.Size(25, 25);
            this.btn_Business.TabIndex = 126;
            this.btn_Business.UseVisualStyleBackColor = true;
            this.btn_Business.Click += new System.EventHandler(this.btn_Text_Click);
            // 
            // btn_Warehouse
            // 
            this.btn_Warehouse.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.btn_Warehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Warehouse.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Warehouse.Location = new System.Drawing.Point(355, 41);
            this.btn_Warehouse.Name = "btn_Warehouse";
            this.btn_Warehouse.Size = new System.Drawing.Size(25, 25);
            this.btn_Warehouse.TabIndex = 129;
            this.btn_Warehouse.UseVisualStyleBackColor = true;
            this.btn_Warehouse.Click += new System.EventHandler(this.btn_Text_Click);
            // 
            // txt_WareCode
            // 
            this.txt_WareCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_WareCode.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_WareCode.Location = new System.Drawing.Point(95, 42);
            this.txt_WareCode.Name = "txt_WareCode";
            this.txt_WareCode.ReadOnly = true;
            this.txt_WareCode.Size = new System.Drawing.Size(100, 23);
            this.txt_WareCode.TabIndex = 128;
            // 
            // lab_Warehouse
            // 
            this.lab_Warehouse.AutoSize = true;
            this.lab_Warehouse.Font = new System.Drawing.Font("굴림", 10F);
            this.lab_Warehouse.Location = new System.Drawing.Point(26, 45);
            this.lab_Warehouse.Name = "lab_Warehouse";
            this.lab_Warehouse.Size = new System.Drawing.Size(63, 14);
            this.lab_Warehouse.TabIndex = 127;
            this.lab_Warehouse.Text = "입고창고";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10F);
            this.label7.Location = new System.Drawing.Point(408, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 130;
            this.label7.Text = "거래구분";
            // 
            // rdo_Sell
            // 
            this.rdo_Sell.AutoSize = true;
            this.rdo_Sell.Checked = true;
            this.rdo_Sell.Location = new System.Drawing.Point(488, 48);
            this.rdo_Sell.Name = "rdo_Sell";
            this.rdo_Sell.Size = new System.Drawing.Size(47, 16);
            this.rdo_Sell.TabIndex = 132;
            this.rdo_Sell.TabStop = true;
            this.rdo_Sell.Text = "판매";
            this.rdo_Sell.UseVisualStyleBackColor = true;
            this.rdo_Sell.CheckedChanged += new System.EventHandler(this.rdo_Sell_CheckedChanged);
            // 
            // rdo_Buy
            // 
            this.rdo_Buy.AutoSize = true;
            this.rdo_Buy.Location = new System.Drawing.Point(556, 48);
            this.rdo_Buy.Name = "rdo_Buy";
            this.rdo_Buy.Size = new System.Drawing.Size(47, 16);
            this.rdo_Buy.TabIndex = 133;
            this.rdo_Buy.Text = "구매";
            this.rdo_Buy.UseVisualStyleBackColor = true;
            this.rdo_Buy.CheckedChanged += new System.EventHandler(this.rdo_Buy_CheckedChanged);
            // 
            // btn_ItemAdd
            // 
            this.btn_ItemAdd.Location = new System.Drawing.Point(613, 78);
            this.btn_ItemAdd.Name = "btn_ItemAdd";
            this.btn_ItemAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_ItemAdd.TabIndex = 134;
            this.btn_ItemAdd.Text = "품목추가";
            this.btn_ItemAdd.UseVisualStyleBackColor = true;
            this.btn_ItemAdd.Click += new System.EventHandler(this.btn_ItemAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(590, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 135;
            this.label8.Text = "총가격 : ";
            // 
            // btn_ItemDelete
            // 
            this.btn_ItemDelete.Location = new System.Drawing.Point(694, 78);
            this.btn_ItemDelete.Name = "btn_ItemDelete";
            this.btn_ItemDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_ItemDelete.TabIndex = 136;
            this.btn_ItemDelete.Text = "품목삭제";
            this.btn_ItemDelete.UseVisualStyleBackColor = true;
            this.btn_ItemDelete.Click += new System.EventHandler(this.btn_ItemDelete_Click);
            // 
            // txt_ClerkName
            // 
            this.txt_ClerkName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ClerkName.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_ClerkName.Location = new System.Drawing.Point(201, 13);
            this.txt_ClerkName.Name = "txt_ClerkName";
            this.txt_ClerkName.ReadOnly = true;
            this.txt_ClerkName.Size = new System.Drawing.Size(148, 23);
            this.txt_ClerkName.TabIndex = 137;
            // 
            // txt_WareName
            // 
            this.txt_WareName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_WareName.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_WareName.Location = new System.Drawing.Point(201, 41);
            this.txt_WareName.Name = "txt_WareName";
            this.txt_WareName.ReadOnly = true;
            this.txt_WareName.Size = new System.Drawing.Size(148, 23);
            this.txt_WareName.TabIndex = 138;
            // 
            // txt_BusinessName
            // 
            this.txt_BusinessName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_BusinessName.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_BusinessName.Location = new System.Drawing.Point(592, 13);
            this.txt_BusinessName.Name = "txt_BusinessName";
            this.txt_BusinessName.ReadOnly = true;
            this.txt_BusinessName.Size = new System.Drawing.Size(146, 23);
            this.txt_BusinessName.TabIndex = 140;
            // 
            // txt_BusinessCode
            // 
            this.txt_BusinessCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_BusinessCode.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_BusinessCode.Location = new System.Drawing.Point(486, 13);
            this.txt_BusinessCode.Name = "txt_BusinessCode";
            this.txt_BusinessCode.ReadOnly = true;
            this.txt_BusinessCode.Size = new System.Drawing.Size(100, 23);
            this.txt_BusinessCode.TabIndex = 139;
            // 
            // lab_TotalPrice
            // 
            this.lab_TotalPrice.AutoSize = true;
            this.lab_TotalPrice.Location = new System.Drawing.Point(649, 386);
            this.lab_TotalPrice.Name = "lab_TotalPrice";
            this.lab_TotalPrice.Size = new System.Drawing.Size(29, 12);
            this.lab_TotalPrice.TabIndex = 141;
            this.lab_TotalPrice.Text = "공백";
            // 
            // Frm_SellBuyInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.lab_TotalPrice);
            this.Controls.Add(this.txt_BusinessName);
            this.Controls.Add(this.txt_BusinessCode);
            this.Controls.Add(this.txt_WareName);
            this.Controls.Add(this.txt_ClerkName);
            this.Controls.Add(this.btn_ItemDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_ItemAdd);
            this.Controls.Add(this.rdo_Buy);
            this.Controls.Add(this.rdo_Sell);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Warehouse);
            this.Controls.Add(this.txt_WareCode);
            this.Controls.Add(this.lab_Warehouse);
            this.Controls.Add(this.btn_Business);
            this.Controls.Add(this.btn_Clerk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gView_Order);
            this.Controls.Add(this.btn_Cleaner);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ClerkCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SellBuyInsert";
            this.Text = "주문 등록";
            ((System.ComponentModel.ISupportInitialize)(this.gView_Order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gView_Order;
        private System.Windows.Forms.Button btn_Cleaner;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ClerkCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Clerk;
        private System.Windows.Forms.Button btn_Business;
        private System.Windows.Forms.Button btn_Warehouse;
        private System.Windows.Forms.TextBox txt_WareCode;
        private System.Windows.Forms.Label lab_Warehouse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdo_Sell;
        private System.Windows.Forms.RadioButton rdo_Buy;
        private System.Windows.Forms.Button btn_ItemAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ItemDelete;
        private System.Windows.Forms.TextBox txt_ClerkName;
        private System.Windows.Forms.TextBox txt_WareName;
        private System.Windows.Forms.TextBox txt_BusinessName;
        private System.Windows.Forms.TextBox txt_BusinessCode;
        private System.Windows.Forms.Label lab_TotalPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFee;
    }
}