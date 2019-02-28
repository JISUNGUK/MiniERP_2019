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
            this.exportExcel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnl_serchbox = new System.Windows.Forms.Panel();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.chkFrag = new System.Windows.Forms.CheckBox();
            this.chkMob = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.itemcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ordercode = new System.Windows.Forms.TextBox();
            this.searchPlan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.produceGrid = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnFind = new System.Windows.Forms.Button();
            this.pnl_serchbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // exportExcel
            // 
            this.exportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportExcel.Font = new System.Drawing.Font("굴림", 10F);
            this.exportExcel.Location = new System.Drawing.Point(218, 586);
            this.exportExcel.Name = "exportExcel";
            this.exportExcel.Size = new System.Drawing.Size(140, 23);
            this.exportExcel.TabIndex = 90;
            this.exportExcel.Text = "Excel로 내보내기";
            this.exportExcel.UseVisualStyleBackColor = true;
            this.exportExcel.Click += new System.EventHandler(this.exportExcel_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("굴림", 10F);
            this.button3.Location = new System.Drawing.Point(118, 586);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 89;
            this.button3.Text = "선택삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Font = new System.Drawing.Font("굴림", 10F);
            this.button5.Location = new System.Drawing.Point(12, 586);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 88;
            this.button5.Text = "신규";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pnl_serchbox
            // 
            this.pnl_serchbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_serchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_serchbox.Controls.Add(this.btnFind);
            this.pnl_serchbox.Controls.Add(this.numericUpDown1);
            this.pnl_serchbox.Controls.Add(this.chkCase);
            this.pnl_serchbox.Controls.Add(this.chkFrag);
            this.pnl_serchbox.Controls.Add(this.chkMob);
            this.pnl_serchbox.Controls.Add(this.button7);
            this.pnl_serchbox.Controls.Add(this.button11);
            this.pnl_serchbox.Controls.Add(this.label11);
            this.pnl_serchbox.Controls.Add(this.itemcode);
            this.pnl_serchbox.Controls.Add(this.label8);
            this.pnl_serchbox.Controls.Add(this.ordercode);
            this.pnl_serchbox.Controls.Add(this.searchPlan);
            this.pnl_serchbox.Controls.Add(this.label1);
            this.pnl_serchbox.Controls.Add(this.label5);
            this.pnl_serchbox.Location = new System.Drawing.Point(12, 12);
            this.pnl_serchbox.Name = "pnl_serchbox";
            this.pnl_serchbox.Size = new System.Drawing.Size(795, 150);
            this.pnl_serchbox.TabIndex = 87;
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(289, 112);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(60, 16);
            this.chkCase.TabIndex = 134;
            this.chkCase.Text = "케이스";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // chkFrag
            // 
            this.chkFrag.AutoSize = true;
            this.chkFrag.Location = new System.Drawing.Point(197, 112);
            this.chkFrag.Name = "chkFrag";
            this.chkFrag.Size = new System.Drawing.Size(48, 16);
            this.chkFrag.TabIndex = 133;
            this.chkFrag.Text = "부품";
            this.chkFrag.UseVisualStyleBackColor = true;
            // 
            // chkMob
            // 
            this.chkMob.AutoSize = true;
            this.chkMob.Location = new System.Drawing.Point(105, 112);
            this.chkMob.Name = "chkMob";
            this.chkMob.Size = new System.Drawing.Size(60, 16);
            this.chkMob.TabIndex = 132;
            this.chkMob.Text = "휴대폰";
            this.chkMob.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Font = new System.Drawing.Font("굴림", 10F);
            this.button7.Location = new System.Drawing.Point(334, 59);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 25);
            this.button7.TabIndex = 131;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Font = new System.Drawing.Font("굴림", 10F);
            this.button11.Location = new System.Drawing.Point(334, 14);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(25, 25);
            this.button11.TabIndex = 129;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "규격";
            // 
            // itemcode
            // 
            this.itemcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemcode.Location = new System.Drawing.Point(101, 59);
            this.itemcode.Name = "itemcode";
            this.itemcode.Size = new System.Drawing.Size(209, 21);
            this.itemcode.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "수량";
            // 
            // ordercode
            // 
            this.ordercode.Location = new System.Drawing.Point(105, 14);
            this.ordercode.Name = "ordercode";
            this.ordercode.Size = new System.Drawing.Size(209, 21);
            this.ordercode.TabIndex = 8;
            // 
            // searchPlan
            // 
            this.searchPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPlan.Location = new System.Drawing.Point(373, 16);
            this.searchPlan.Name = "searchPlan";
            this.searchPlan.Size = new System.Drawing.Size(75, 23);
            this.searchPlan.TabIndex = 6;
            this.searchPlan.Text = "검색";
            this.searchPlan.UseVisualStyleBackColor = true;
            this.searchPlan.Click += new System.EventHandler(this.searchPlan_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "품목코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "주문코드";
            // 
            // produceGrid
            // 
            this.produceGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produceGrid.Location = new System.Drawing.Point(12, 164);
            this.produceGrid.Name = "produceGrid";
            this.produceGrid.RowTemplate.Height = 23;
            this.produceGrid.Size = new System.Drawing.Size(795, 416);
            this.produceGrid.TabIndex = 78;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(451, 64);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(252, 21);
            this.numericUpDown1.TabIndex = 135;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(628, 102);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 136;
            this.btnFind.Text = "찾기";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Frm_productionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 621);
            this.Controls.Add(this.exportExcel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pnl_serchbox);
            this.Controls.Add(this.produceGrid);
            this.Name = "Frm_productionList";
            this.Text = "생산계획 조회";
            this.Load += new System.EventHandler(this.Frm_productionList_Load);
            this.Resize += new System.EventHandler(this.Frm_productionList_Resize);
            this.pnl_serchbox.ResumeLayout(false);
            this.pnl_serchbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exportExcel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnl_serchbox;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.CheckBox chkFrag;
        private System.Windows.Forms.CheckBox chkMob;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox itemcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ordercode;
        private System.Windows.Forms.Button searchPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView produceGrid;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}