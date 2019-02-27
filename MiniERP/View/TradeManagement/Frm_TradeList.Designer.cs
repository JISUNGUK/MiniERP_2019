namespace MiniERP.View.TradeManagement
{
    partial class Frm_TradeList
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
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_serchbox = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.txt_Business = new System.Windows.Forms.TextBox();
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.max_date = new System.Windows.Forms.DateTimePicker();
            this.low_date = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.gViewTrade = new System.Windows.Forms.DataGridView();
            this.trade_standard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trade_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clerk_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trade_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOutput = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_serchbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewTrade)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "거래 날짜";
            // 
            // pnl_serchbox
            // 
            this.pnl_serchbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_serchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_serchbox.Controls.Add(this.button7);
            this.pnl_serchbox.Controls.Add(this.txt_Business);
            this.pnl_serchbox.Controls.Add(this.txt_Item);
            this.pnl_serchbox.Location = new System.Drawing.Point(17, 39);
            this.pnl_serchbox.Name = "pnl_serchbox";
            this.pnl_serchbox.Size = new System.Drawing.Size(895, 39);
            this.pnl_serchbox.TabIndex = 49;
            this.pnl_serchbox.Visible = false;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("굴림", 10F);
            this.button7.Location = new System.Drawing.Point(798, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 23);
            this.button7.TabIndex = 50;
            this.button7.Text = "검색";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txt_Business
            // 
            this.txt_Business.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_Business.Location = new System.Drawing.Point(244, 8);
            this.txt_Business.Name = "txt_Business";
            this.txt_Business.Size = new System.Drawing.Size(229, 23);
            this.txt_Business.TabIndex = 42;
            // 
            // txt_Item
            // 
            this.txt_Item.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_Item.Location = new System.Drawing.Point(9, 8);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(229, 23);
            this.txt_Item.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 129;
            this.label1.Text = "~";
            // 
            // max_date
            // 
            this.max_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.max_date.Location = new System.Drawing.Point(204, 12);
            this.max_date.Name = "max_date";
            this.max_date.Size = new System.Drawing.Size(100, 21);
            this.max_date.TabIndex = 128;
            // 
            // low_date
            // 
            this.low_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.low_date.Location = new System.Drawing.Point(78, 12);
            this.low_date.Name = "low_date";
            this.low_date.Size = new System.Drawing.Size(100, 21);
            this.low_date.TabIndex = 127;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 10F);
            this.button5.Location = new System.Drawing.Point(155, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(19, 23);
            this.button5.TabIndex = 48;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 10F);
            this.button6.Location = new System.Drawing.Point(17, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(19, 23);
            this.button6.TabIndex = 47;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(42, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 14);
            this.label4.TabIndex = 46;
            this.label4.Text = "페이지 / 페이지";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Font = new System.Drawing.Font("굴림", 10F);
            this.button4.Location = new System.Drawing.Point(221, 583);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "Excel로 내보내기";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("굴림", 10F);
            this.button3.Location = new System.Drawing.Point(119, 583);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "선택삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Save.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Save.Location = new System.Drawing.Point(17, 583);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 38;
            this.btn_Save.Text = "신규";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(310, 11);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 130;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Detail
            // 
            this.btn_Detail.Location = new System.Drawing.Point(391, 11);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(75, 23);
            this.btn_Detail.TabIndex = 131;
            this.btn_Detail.Text = "상세검색";
            this.btn_Detail.UseVisualStyleBackColor = true;
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // gViewTrade
            // 
            this.gViewTrade.AllowUserToAddRows = false;
            this.gViewTrade.AllowUserToDeleteRows = false;
            this.gViewTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gViewTrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewTrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trade_standard,
            this.trade_code,
            this.clerk_name,
            this.business_name,
            this.item_summary,
            this.total_fee,
            this.trade_status,
            this.end_date,
            this.btnOutput});
            this.gViewTrade.Location = new System.Drawing.Point(17, 86);
            this.gViewTrade.Name = "gViewTrade";
            this.gViewTrade.RowHeadersVisible = false;
            this.gViewTrade.RowTemplate.Height = 23;
            this.gViewTrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gViewTrade.Size = new System.Drawing.Size(895, 491);
            this.gViewTrade.TabIndex = 37;
            this.gViewTrade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewTrade_CellClick);
            this.gViewTrade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewTrade_CellDoubleClick);
            // 
            // trade_standard
            // 
            this.trade_standard.HeaderText = "거래구분";
            this.trade_standard.Name = "trade_standard";
            this.trade_standard.ReadOnly = true;
            // 
            // trade_code
            // 
            this.trade_code.HeaderText = "거래번호";
            this.trade_code.Name = "trade_code";
            this.trade_code.ReadOnly = true;
            // 
            // clerk_name
            // 
            this.clerk_name.HeaderText = "담당자";
            this.clerk_name.Name = "clerk_name";
            this.clerk_name.ReadOnly = true;
            // 
            // business_name
            // 
            this.business_name.HeaderText = "거래처명";
            this.business_name.Name = "business_name";
            this.business_name.ReadOnly = true;
            // 
            // item_summary
            // 
            this.item_summary.HeaderText = "품목";
            this.item_summary.Name = "item_summary";
            this.item_summary.ReadOnly = true;
            // 
            // total_fee
            // 
            this.total_fee.HeaderText = "총액";
            this.total_fee.Name = "total_fee";
            this.total_fee.ReadOnly = true;
            // 
            // trade_status
            // 
            this.trade_status.HeaderText = "거래상태";
            this.trade_status.Name = "trade_status";
            this.trade_status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // end_date
            // 
            this.end_date.HeaderText = "종료일";
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            // 
            // btnOutput
            // 
            this.btnOutput.HeaderText = "전표출력";
            this.btnOutput.Name = "btnOutput";
            // 
            // Frm_TradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 618);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.max_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_serchbox);
            this.Controls.Add(this.low_date);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gViewTrade);
            this.Name = "Frm_TradeList";
            this.Text = "거래 조회";
            this.Load += new System.EventHandler(this.Frm_TradeList_Load);
            this.pnl_serchbox.ResumeLayout(false);
            this.pnl_serchbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewTrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_serchbox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Business;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker max_date;
        private System.Windows.Forms.DateTimePicker low_date;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.TextBox txt_Item;
        private System.Windows.Forms.DataGridView gViewTrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn trade_standard;
        private System.Windows.Forms.DataGridViewTextBoxColumn trade_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn clerk_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn trade_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridViewButtonColumn btnOutput;
    }
}