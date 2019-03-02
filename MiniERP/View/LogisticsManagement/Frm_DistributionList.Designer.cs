namespace MiniERP.View.LogisticsManagement
{
    partial class Frm_DistributionList
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.beforeWarehouse = new System.Windows.Forms.TextBox();
            this.afterWarehouse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemCode = new System.Windows.Forms.TextBox();
            this.distributionGrid = new System.Windows.Forms.DataGridView();
            this.awButton = new System.Windows.Forms.Button();
            this.bwButton = new System.Windows.Forms.Button();
            this.itemBtn = new System.Windows.Forms.Button();
            this.exportExcel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.distributionGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "기간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(905, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "창고";
            // 
            // beforeWarehouse
            // 
            this.beforeWarehouse.Location = new System.Drawing.Point(1022, 160);
            this.beforeWarehouse.Name = "beforeWarehouse";
            this.beforeWarehouse.Size = new System.Drawing.Size(200, 32);
            this.beforeWarehouse.TabIndex = 5;
            // 
            // afterWarehouse
            // 
            this.afterWarehouse.Location = new System.Drawing.Point(1398, 160);
            this.afterWarehouse.Name = "afterWarehouse";
            this.afterWarehouse.Size = new System.Drawing.Size(200, 32);
            this.afterWarehouse.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1328, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "품목코드";
            // 
            // itemCode
            // 
            this.itemCode.Location = new System.Drawing.Point(133, 154);
            this.itemCode.Name = "itemCode";
            this.itemCode.Size = new System.Drawing.Size(200, 32);
            this.itemCode.TabIndex = 9;
            // 
            // distributionGrid
            // 
            this.distributionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distributionGrid.Location = new System.Drawing.Point(16, 372);
            this.distributionGrid.Name = "distributionGrid";
            this.distributionGrid.RowTemplate.Height = 34;
            this.distributionGrid.Size = new System.Drawing.Size(1783, 691);
            this.distributionGrid.TabIndex = 134;
            // 
            // awButton
            // 
            this.awButton.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.awButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.awButton.Font = new System.Drawing.Font("굴림", 10F);
            this.awButton.Location = new System.Drawing.Point(1606, 157);
            this.awButton.Margin = new System.Windows.Forms.Padding(5);
            this.awButton.Name = "awButton";
            this.awButton.Size = new System.Drawing.Size(39, 37);
            this.awButton.TabIndex = 133;
            this.awButton.UseVisualStyleBackColor = true;
            this.awButton.Click += new System.EventHandler(this.awButton_Click);
            // 
            // bwButton
            // 
            this.bwButton.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.bwButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bwButton.Font = new System.Drawing.Font("굴림", 10F);
            this.bwButton.Location = new System.Drawing.Point(1230, 160);
            this.bwButton.Margin = new System.Windows.Forms.Padding(5);
            this.bwButton.Name = "bwButton";
            this.bwButton.Size = new System.Drawing.Size(39, 37);
            this.bwButton.TabIndex = 132;
            this.bwButton.UseVisualStyleBackColor = true;
            this.bwButton.Click += new System.EventHandler(this.bwButton_Click);
            // 
            // itemBtn
            // 
            this.itemBtn.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.itemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.itemBtn.Font = new System.Drawing.Font("굴림", 10F);
            this.itemBtn.Location = new System.Drawing.Point(341, 154);
            this.itemBtn.Margin = new System.Windows.Forms.Padding(5);
            this.itemBtn.Name = "itemBtn";
            this.itemBtn.Size = new System.Drawing.Size(39, 37);
            this.itemBtn.TabIndex = 130;
            this.itemBtn.UseVisualStyleBackColor = true;
            this.itemBtn.Click += new System.EventHandler(this.itemBtn_Click);
            // 
            // exportExcel
            // 
            this.exportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportExcel.Font = new System.Drawing.Font("굴림", 10F);
            this.exportExcel.Location = new System.Drawing.Point(1425, 72);
            this.exportExcel.Margin = new System.Windows.Forms.Padding(5);
            this.exportExcel.Name = "exportExcel";
            this.exportExcel.Size = new System.Drawing.Size(220, 40);
            this.exportExcel.TabIndex = 135;
            this.exportExcel.Text = "Excel로 내보내기";
            this.exportExcel.UseVisualStyleBackColor = true;
            this.exportExcel.Click += new System.EventHandler(this.exportExcel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1501, 292);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 40);
            this.btnSearch.TabIndex = 136;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(462, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(526, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 141);
            this.groupBox1.TabIndex = 137;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상태";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "대기";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "출고";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(172, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 25);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "취소";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(172, 79);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 25);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "완료";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Frm_DistributionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 1091);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.exportExcel);
            this.Controls.Add(this.distributionGrid);
            this.Controls.Add(this.awButton);
            this.Controls.Add(this.bwButton);
            this.Controls.Add(this.itemBtn);
            this.Controls.Add(this.itemCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.afterWarehouse);
            this.Controls.Add(this.beforeWarehouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_DistributionList";
            this.Text = "물류조회";
            ((System.ComponentModel.ISupportInitialize)(this.distributionGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox beforeWarehouse;
        private System.Windows.Forms.TextBox afterWarehouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemCode;
        private System.Windows.Forms.Button itemBtn;
        private System.Windows.Forms.Button bwButton;
        private System.Windows.Forms.Button awButton;
        private System.Windows.Forms.DataGridView distributionGrid;
        private System.Windows.Forms.Button exportExcel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}