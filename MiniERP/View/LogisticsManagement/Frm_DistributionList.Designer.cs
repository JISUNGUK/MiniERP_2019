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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lowdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.beforeWarehouse = new System.Windows.Forms.TextBox();
            this.afterWarehouse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemCode = new System.Windows.Forms.TextBox();
            this.distributionGrid = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.highdate = new System.Windows.Forms.DateTimePicker();
            this.statusGruoup = new System.Windows.Forms.GroupBox();
            this.completeRdo = new System.Windows.Forms.RadioButton();
            this.cancelRdo = new System.Windows.Forms.RadioButton();
            this.exportRdo = new System.Windows.Forms.RadioButton();
            this.waitRdo = new System.Windows.Forms.RadioButton();
            this.awButton = new System.Windows.Forms.Button();
            this.bwButton = new System.Windows.Forms.Button();
            this.itemBtn = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.distributionGrid)).BeginInit();
            this.statusGruoup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lowdate
            // 
            this.lowdate.Location = new System.Drawing.Point(85, 37);
            this.lowdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lowdate.Name = "lowdate";
            this.lowdate.Size = new System.Drawing.Size(129, 21);
            this.lowdate.TabIndex = 0;
            this.lowdate.Value = new System.DateTime(2019, 3, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "기간(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "창고";
            // 
            // beforeWarehouse
            // 
            this.beforeWarehouse.Location = new System.Drawing.Point(650, 91);
            this.beforeWarehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.beforeWarehouse.Name = "beforeWarehouse";
            this.beforeWarehouse.Size = new System.Drawing.Size(129, 21);
            this.beforeWarehouse.TabIndex = 5;
            // 
            // afterWarehouse
            // 
            this.afterWarehouse.Location = new System.Drawing.Point(890, 91);
            this.afterWarehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.afterWarehouse.Name = "afterWarehouse";
            this.afterWarehouse.Size = new System.Drawing.Size(129, 21);
            this.afterWarehouse.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(845, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "품목코드";
            // 
            // itemCode
            // 
            this.itemCode.Location = new System.Drawing.Point(85, 88);
            this.itemCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemCode.Name = "itemCode";
            this.itemCode.Size = new System.Drawing.Size(129, 21);
            this.itemCode.TabIndex = 9;
            // 
            // distributionGrid
            // 
            this.distributionGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.distributionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.distributionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.distributionGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.distributionGrid.Location = new System.Drawing.Point(11, 176);
            this.distributionGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.distributionGrid.Name = "distributionGrid";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.distributionGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.distributionGrid.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.distributionGrid.RowTemplate.Height = 34;
            this.distributionGrid.Size = new System.Drawing.Size(1135, 358);
            this.distributionGrid.TabIndex = 134;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1052, 149);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.TabIndex = 136;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "~";
            // 
            // highdate
            // 
            this.highdate.Location = new System.Drawing.Point(294, 37);
            this.highdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.highdate.Name = "highdate";
            this.highdate.Size = new System.Drawing.Size(129, 21);
            this.highdate.TabIndex = 3;
            // 
            // statusGruoup
            // 
            this.statusGruoup.Controls.Add(this.rdoAll);
            this.statusGruoup.Controls.Add(this.completeRdo);
            this.statusGruoup.Controls.Add(this.cancelRdo);
            this.statusGruoup.Controls.Add(this.exportRdo);
            this.statusGruoup.Controls.Add(this.waitRdo);
            this.statusGruoup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusGruoup.Location = new System.Drawing.Point(335, 80);
            this.statusGruoup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusGruoup.Name = "statusGruoup";
            this.statusGruoup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusGruoup.Size = new System.Drawing.Size(201, 91);
            this.statusGruoup.TabIndex = 137;
            this.statusGruoup.TabStop = false;
            this.statusGruoup.Text = "상태";
            // 
            // completeRdo
            // 
            this.completeRdo.AutoSize = true;
            this.completeRdo.Location = new System.Drawing.Point(109, 72);
            this.completeRdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.completeRdo.Name = "completeRdo";
            this.completeRdo.Size = new System.Drawing.Size(47, 16);
            this.completeRdo.TabIndex = 3;
            this.completeRdo.TabStop = true;
            this.completeRdo.Text = "완료";
            this.completeRdo.UseVisualStyleBackColor = true;
            this.completeRdo.CheckedChanged += new System.EventHandler(this.completeRdo_CheckedChanged);
            // 
            // cancelRdo
            // 
            this.cancelRdo.AutoSize = true;
            this.cancelRdo.Location = new System.Drawing.Point(109, 45);
            this.cancelRdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelRdo.Name = "cancelRdo";
            this.cancelRdo.Size = new System.Drawing.Size(47, 16);
            this.cancelRdo.TabIndex = 2;
            this.cancelRdo.TabStop = true;
            this.cancelRdo.Text = "취소";
            this.cancelRdo.UseVisualStyleBackColor = true;
            this.cancelRdo.CheckedChanged += new System.EventHandler(this.cancelRdo_CheckedChanged);
            // 
            // exportRdo
            // 
            this.exportRdo.AutoSize = true;
            this.exportRdo.Location = new System.Drawing.Point(11, 45);
            this.exportRdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exportRdo.Name = "exportRdo";
            this.exportRdo.Size = new System.Drawing.Size(47, 16);
            this.exportRdo.TabIndex = 1;
            this.exportRdo.TabStop = true;
            this.exportRdo.Text = "출고";
            this.exportRdo.UseVisualStyleBackColor = true;
            this.exportRdo.CheckedChanged += new System.EventHandler(this.exportRdo_CheckedChanged);
            // 
            // waitRdo
            // 
            this.waitRdo.AutoSize = true;
            this.waitRdo.Location = new System.Drawing.Point(11, 69);
            this.waitRdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.waitRdo.Name = "waitRdo";
            this.waitRdo.Size = new System.Drawing.Size(47, 16);
            this.waitRdo.TabIndex = 0;
            this.waitRdo.TabStop = true;
            this.waitRdo.Text = "대기";
            this.waitRdo.UseVisualStyleBackColor = true;
            this.waitRdo.CheckedChanged += new System.EventHandler(this.waitRdo_CheckedChanged);
            // 
            // awButton
            // 
            this.awButton.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.awButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.awButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.awButton.Font = new System.Drawing.Font("굴림", 10F);
            this.awButton.Location = new System.Drawing.Point(1022, 90);
            this.awButton.Name = "awButton";
            this.awButton.Size = new System.Drawing.Size(25, 21);
            this.awButton.TabIndex = 133;
            this.awButton.UseVisualStyleBackColor = true;
            this.awButton.Click += new System.EventHandler(this.awButton_Click);
            // 
            // bwButton
            // 
            this.bwButton.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.bwButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bwButton.Font = new System.Drawing.Font("굴림", 10F);
            this.bwButton.Location = new System.Drawing.Point(783, 91);
            this.bwButton.Name = "bwButton";
            this.bwButton.Size = new System.Drawing.Size(25, 21);
            this.bwButton.TabIndex = 132;
            this.bwButton.UseVisualStyleBackColor = true;
            this.bwButton.Click += new System.EventHandler(this.bwButton_Click);
            // 
            // itemBtn
            // 
            this.itemBtn.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.itemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.itemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemBtn.Font = new System.Drawing.Font("굴림", 10F);
            this.itemBtn.Location = new System.Drawing.Point(217, 88);
            this.itemBtn.Name = "itemBtn";
            this.itemBtn.Size = new System.Drawing.Size(25, 21);
            this.itemBtn.TabIndex = 130;
            this.itemBtn.UseVisualStyleBackColor = true;
            this.itemBtn.Click += new System.EventHandler(this.itemBtn_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(8, 545);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 23);
            this.btnNew.TabIndex = 138;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(11, 19);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(47, 16);
            this.rdoAll.TabIndex = 4;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "전체";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // Frm_DistributionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 606);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.statusGruoup);
            this.Controls.Add(this.btnSearch);
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
            this.Controls.Add(this.highdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lowdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_DistributionList";
            this.Text = "물류조회";
            this.Load += new System.EventHandler(this.Frm_DistributionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.distributionGrid)).EndInit();
            this.statusGruoup.ResumeLayout(false);
            this.statusGruoup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker lowdate;
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker highdate;
        private System.Windows.Forms.GroupBox statusGruoup;
        private System.Windows.Forms.RadioButton cancelRdo;
        private System.Windows.Forms.RadioButton exportRdo;
        private System.Windows.Forms.RadioButton waitRdo;
        private System.Windows.Forms.RadioButton completeRdo;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.RadioButton rdoAll;
    }
}