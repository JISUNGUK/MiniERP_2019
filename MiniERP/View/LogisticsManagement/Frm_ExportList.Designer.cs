namespace MiniERP.View.LogisticsManagement
{
    partial class Frm_ExportList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exportGrid = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.move_date = new System.Windows.Forms.DateTimePicker();
            this.warehouseBtn = new System.Windows.Forms.Button();
            this.warehouseCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // exportGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exportGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.exportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.exportGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.exportGrid.Location = new System.Drawing.Point(12, 183);
            this.exportGrid.Name = "exportGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exportGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.exportGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.exportGrid.RowTemplate.Height = 34;
            this.exportGrid.Size = new System.Drawing.Size(1786, 881);
            this.exportGrid.TabIndex = 139;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1439, 22);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(179, 44);
            this.btnExport.TabIndex = 153;
            this.btnExport.Text = "Excel로 내보내기";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 149;
            this.label2.Text = "창고코드";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1439, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(179, 44);
            this.btnSearch.TabIndex = 151;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 148;
            this.label1.Text = "이동날짜";
            // 
            // move_date
            // 
            this.move_date.Location = new System.Drawing.Point(117, 120);
            this.move_date.Name = "move_date";
            this.move_date.Size = new System.Drawing.Size(200, 32);
            this.move_date.TabIndex = 147;
            // 
            // warehouseBtn
            // 
            this.warehouseBtn.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.warehouseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.warehouseBtn.Font = new System.Drawing.Font("굴림", 10F);
            this.warehouseBtn.Location = new System.Drawing.Point(340, 23);
            this.warehouseBtn.Margin = new System.Windows.Forms.Padding(5);
            this.warehouseBtn.Name = "warehouseBtn";
            this.warehouseBtn.Size = new System.Drawing.Size(39, 37);
            this.warehouseBtn.TabIndex = 152;
            this.warehouseBtn.UseVisualStyleBackColor = true;
            this.warehouseBtn.Click += new System.EventHandler(this.warehouseBtn_Click);
            // 
            // warehouseCode
            // 
            this.warehouseCode.Location = new System.Drawing.Point(117, 23);
            this.warehouseCode.Name = "warehouseCode";
            this.warehouseCode.Size = new System.Drawing.Size(200, 32);
            this.warehouseCode.TabIndex = 150;
            // 
            // Frm_ExportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 1026);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.move_date);
            this.Controls.Add(this.warehouseBtn);
            this.Controls.Add(this.warehouseCode);
            this.Controls.Add(this.exportGrid);
            this.Name = "Frm_ExportList";
            this.Text = "출고확인서 조회";
            this.Load += new System.EventHandler(this.Frm_ExportList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView exportGrid;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker move_date;
        private System.Windows.Forms.Button warehouseBtn;
        private System.Windows.Forms.TextBox warehouseCode;
    }
}