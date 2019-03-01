namespace MiniERP.View.LogisticsManagement
{
    partial class Frm_productionList
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
            this.produceGrid = new System.Windows.Forms.DataGridView();
            this.exportExcel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.itemcount = new System.Windows.Forms.NumericUpDown();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.chkFrag = new System.Windows.Forms.CheckBox();
            this.chkMob = new System.Windows.Forms.CheckBox();
            this.itemSearch = new System.Windows.Forms.Button();
            this.orderSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.itemcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ordercode = new System.Windows.Forms.TextBox();
            this.searchPlan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcount)).BeginInit();
            this.SuspendLayout();
            // 
            // produceGrid
            // 
            this.produceGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produceGrid.Location = new System.Drawing.Point(19, 287);
            this.produceGrid.Margin = new System.Windows.Forms.Padding(5);
            this.produceGrid.Name = "produceGrid";
            this.produceGrid.RowTemplate.Height = 23;
            this.produceGrid.Size = new System.Drawing.Size(1773, 667);
            this.produceGrid.TabIndex = 78;
            // 
            // exportExcel
            // 
            this.exportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportExcel.Font = new System.Drawing.Font("굴림", 10F);
            this.exportExcel.Location = new System.Drawing.Point(1129, 38);
            this.exportExcel.Margin = new System.Windows.Forms.Padding(5);
            this.exportExcel.Name = "exportExcel";
            this.exportExcel.Size = new System.Drawing.Size(220, 40);
            this.exportExcel.TabIndex = 144;
            this.exportExcel.Text = "Excel로 내보내기";
            this.exportExcel.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(1231, 125);
            this.btnFind.Margin = new System.Windows.Forms.Padding(5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(118, 40);
            this.btnFind.TabIndex = 151;
            this.btnFind.Text = "찾기";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // itemcount
            // 
            this.itemcount.Location = new System.Drawing.Point(769, 125);
            this.itemcount.Margin = new System.Windows.Forms.Padding(5);
            this.itemcount.Name = "itemcount";
            this.itemcount.Size = new System.Drawing.Size(396, 32);
            this.itemcount.TabIndex = 150;
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(486, 206);
            this.chkCase.Margin = new System.Windows.Forms.Padding(5);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(99, 25);
            this.chkCase.TabIndex = 149;
            this.chkCase.Text = "케이스";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // chkFrag
            // 
            this.chkFrag.AutoSize = true;
            this.chkFrag.Location = new System.Drawing.Point(342, 206);
            this.chkFrag.Margin = new System.Windows.Forms.Padding(5);
            this.chkFrag.Name = "chkFrag";
            this.chkFrag.Size = new System.Drawing.Size(78, 25);
            this.chkFrag.TabIndex = 148;
            this.chkFrag.Text = "부품";
            this.chkFrag.UseVisualStyleBackColor = true;
            // 
            // chkMob
            // 
            this.chkMob.AutoSize = true;
            this.chkMob.Location = new System.Drawing.Point(197, 206);
            this.chkMob.Margin = new System.Windows.Forms.Padding(5);
            this.chkMob.Name = "chkMob";
            this.chkMob.Size = new System.Drawing.Size(99, 25);
            this.chkMob.TabIndex = 147;
            this.chkMob.Text = "휴대폰";
            this.chkMob.UseVisualStyleBackColor = true;
            // 
            // itemSearch
            // 
            this.itemSearch.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.itemSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.itemSearch.Font = new System.Drawing.Font("굴림", 10F);
            this.itemSearch.Location = new System.Drawing.Point(557, 113);
            this.itemSearch.Margin = new System.Windows.Forms.Padding(5);
            this.itemSearch.Name = "itemSearch";
            this.itemSearch.Size = new System.Drawing.Size(39, 44);
            this.itemSearch.TabIndex = 146;
            this.itemSearch.UseVisualStyleBackColor = true;
            // 
            // orderSearch
            // 
            this.orderSearch.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.orderSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.orderSearch.Font = new System.Drawing.Font("굴림", 10F);
            this.orderSearch.Location = new System.Drawing.Point(557, 34);
            this.orderSearch.Margin = new System.Windows.Forms.Padding(5);
            this.orderSearch.Name = "orderSearch";
            this.orderSearch.Size = new System.Drawing.Size(39, 44);
            this.orderSearch.TabIndex = 145;
            this.orderSearch.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 143;
            this.label11.Text = "규격";
            // 
            // itemcode
            // 
            this.itemcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemcode.Location = new System.Drawing.Point(197, 110);
            this.itemcode.Margin = new System.Windows.Forms.Padding(5);
            this.itemcode.Name = "itemcode";
            this.itemcode.Size = new System.Drawing.Size(320, 32);
            this.itemcode.TabIndex = 142;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 141;
            this.label8.Text = "수량";
            // 
            // ordercode
            // 
            this.ordercode.Location = new System.Drawing.Point(197, 34);
            this.ordercode.Margin = new System.Windows.Forms.Padding(5);
            this.ordercode.Name = "ordercode";
            this.ordercode.Size = new System.Drawing.Size(326, 32);
            this.ordercode.TabIndex = 140;
            // 
            // searchPlan
            // 
            this.searchPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPlan.Location = new System.Drawing.Point(675, 34);
            this.searchPlan.Margin = new System.Windows.Forms.Padding(5);
            this.searchPlan.Name = "searchPlan";
            this.searchPlan.Size = new System.Drawing.Size(118, 40);
            this.searchPlan.TabIndex = 139;
            this.searchPlan.Text = "검색";
            this.searchPlan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 138;
            this.label1.Text = "품목코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 137;
            this.label5.Text = "주문코드";
            // 
            // Frm_productionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 1026);
            this.Controls.Add(this.exportExcel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.itemcount);
            this.Controls.Add(this.chkCase);
            this.Controls.Add(this.chkFrag);
            this.Controls.Add(this.chkMob);
            this.Controls.Add(this.itemSearch);
            this.Controls.Add(this.orderSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.itemcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ordercode);
            this.Controls.Add(this.searchPlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.produceGrid);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_productionList";
            this.Text = "생산계획 조회";
            this.Load += new System.EventHandler(this.Frm_productionList_Load);
            this.Resize += new System.EventHandler(this.Frm_productionList_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.produceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView produceGrid;
        private System.Windows.Forms.Button exportExcel;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.NumericUpDown itemcount;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.CheckBox chkFrag;
        private System.Windows.Forms.CheckBox chkMob;
        private System.Windows.Forms.Button itemSearch;
        private System.Windows.Forms.Button orderSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox itemcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ordercode;
        private System.Windows.Forms.Button searchPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}