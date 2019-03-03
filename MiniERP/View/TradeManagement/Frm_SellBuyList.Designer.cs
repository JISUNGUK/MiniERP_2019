namespace MiniERP.View.TradeManagement
{
    partial class Frm_SellBuyList
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.gViewTrade = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clerk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_buy = new System.Windows.Forms.RadioButton();
            this.rdo_sell = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gViewTrade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Font = new System.Drawing.Font("굴림", 10F);
            this.button4.Location = new System.Drawing.Point(227, 583);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Excel로 내보내기";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("굴림", 10F);
            this.button3.Location = new System.Drawing.Point(125, 583);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "선택삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Insert.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Insert.Location = new System.Drawing.Point(23, 583);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 25;
            this.btn_Insert.Text = "신규";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // gViewTrade
            // 
            this.gViewTrade.AllowUserToAddRows = false;
            this.gViewTrade.AllowUserToDeleteRows = false;
            this.gViewTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gViewTrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gViewTrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewTrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.clerk,
            this.business,
            this.summary,
            this.totalfee,
            this.status,
            this.warehouse});
            this.gViewTrade.Location = new System.Drawing.Point(23, 74);
            this.gViewTrade.Name = "gViewTrade";
            this.gViewTrade.RowHeadersVisible = false;
            this.gViewTrade.RowTemplate.Height = 23;
            this.gViewTrade.Size = new System.Drawing.Size(788, 503);
            this.gViewTrade.TabIndex = 24;
            this.gViewTrade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewTrade_CellDoubleClick);
            // 
            // code
            // 
            this.code.HeaderText = "주문번호";
            this.code.Name = "code";
            // 
            // clerk
            // 
            this.clerk.HeaderText = "담당자";
            this.clerk.Name = "clerk";
            // 
            // business
            // 
            this.business.HeaderText = "거래처";
            this.business.Name = "business";
            // 
            // summary
            // 
            this.summary.HeaderText = "품목";
            this.summary.Name = "summary";
            // 
            // totalfee
            // 
            this.totalfee.HeaderText = "금액";
            this.totalfee.Name = "totalfee";
            // 
            // status
            // 
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            // 
            // warehouse
            // 
            this.warehouse.HeaderText = "출고창고";
            this.warehouse.Name = "warehouse";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_buy);
            this.groupBox1.Controls.Add(this.rdo_sell);
            this.groupBox1.Location = new System.Drawing.Point(23, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 35);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // rdo_buy
            // 
            this.rdo_buy.AutoSize = true;
            this.rdo_buy.Location = new System.Drawing.Point(65, 13);
            this.rdo_buy.Name = "rdo_buy";
            this.rdo_buy.Size = new System.Drawing.Size(47, 16);
            this.rdo_buy.TabIndex = 1;
            this.rdo_buy.Text = "구매";
            this.rdo_buy.UseVisualStyleBackColor = true;
            this.rdo_buy.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdo_sell
            // 
            this.rdo_sell.AutoSize = true;
            this.rdo_sell.Checked = true;
            this.rdo_sell.Location = new System.Drawing.Point(6, 13);
            this.rdo_sell.Name = "rdo_sell";
            this.rdo_sell.Size = new System.Drawing.Size(47, 16);
            this.rdo_sell.TabIndex = 0;
            this.rdo_sell.TabStop = true;
            this.rdo_sell.Text = "판매";
            this.rdo_sell.UseVisualStyleBackColor = true;
            this.rdo_sell.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // Frm_SellBuyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.gViewTrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_SellBuyList";
            this.Text = "판매/구매조회";
            this.Load += new System.EventHandler(this.Frm_SellBuyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gViewTrade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DataGridView gViewTrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_buy;
        private System.Windows.Forms.RadioButton rdo_sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn clerk;
        private System.Windows.Forms.DataGridViewTextBoxColumn business;
        private System.Windows.Forms.DataGridViewTextBoxColumn summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse;
    }
}