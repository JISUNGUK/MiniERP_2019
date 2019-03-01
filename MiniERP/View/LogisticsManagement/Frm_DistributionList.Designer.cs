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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.beforeWarehouse = new System.Windows.Forms.TextBox();
            this.afterWarehouse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusTabs = new System.Windows.Forms.TabControl();
            this.status = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.distributionGrid = new System.Windows.Forms.DataGridView();
            this.awButton = new System.Windows.Forms.Button();
            this.bwButton = new System.Windows.Forms.Button();
            this.itemBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.statusTabs.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distributionGrid)).BeginInit();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 131;
            this.label6.Text = "상태";
            // 
            // statusTabs
            // 
            this.statusTabs.Controls.Add(this.status);
            this.statusTabs.Controls.Add(this.tabPage2);
            this.statusTabs.Controls.Add(this.tabPage3);
            this.statusTabs.Controls.Add(this.tabPage4);
            this.statusTabs.Location = new System.Drawing.Point(540, 157);
            this.statusTabs.Name = "statusTabs";
            this.statusTabs.SelectedIndex = 0;
            this.statusTabs.Size = new System.Drawing.Size(322, 209);
            this.statusTabs.TabIndex = 1;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(4, 31);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(3);
            this.status.Size = new System.Drawing.Size(314, 174);
            this.status.TabIndex = 0;
            this.status.Text = "구매";
            this.status.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(314, 174);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "판매";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(314, 174);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "물류";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(314, 174);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "출고";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(7, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 151);
            this.listBox1.TabIndex = 0;
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
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Font = new System.Drawing.Font("굴림", 10F);
            this.button4.Location = new System.Drawing.Point(1425, 72);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 40);
            this.button4.TabIndex = 135;
            this.button4.Text = "Excel로 내보내기";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1230, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 40);
            this.btnSearch.TabIndex = 136;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Frm_DistributionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 1091);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.distributionGrid);
            this.Controls.Add(this.awButton);
            this.Controls.Add(this.bwButton);
            this.Controls.Add(this.statusTabs);
            this.Controls.Add(this.label6);
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
            this.statusTabs.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distributionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox beforeWarehouse;
        private System.Windows.Forms.TextBox afterWarehouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemCode;
        private System.Windows.Forms.Button itemBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl statusTabs;
        private System.Windows.Forms.TabPage status;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bwButton;
        private System.Windows.Forms.Button awButton;
        private System.Windows.Forms.DataGridView distributionGrid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSearch;
    }
}