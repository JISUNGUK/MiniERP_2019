namespace MiniERP.View.LogisticsManagement
{
    partial class Frm_ImportList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.importGrid = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.move_date = new System.Windows.Forms.DateTimePicker();
            this.warehouseBtn = new System.Windows.Forms.Button();
            this.warehouseCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.importGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // importGrid
            // 
            this.importGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.importGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.importGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.importGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.importGrid.Location = new System.Drawing.Point(13, 183);
            this.importGrid.Name = "importGrid";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.importGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.importGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.importGrid.RowTemplate.Height = 34;
            this.importGrid.Size = new System.Drawing.Size(1786, 881);
            this.importGrid.TabIndex = 147;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1439, 22);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(179, 44);
            this.btnExport.TabIndex = 146;
            this.btnExport.Text = "Excel로 내보내기";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 142;
            this.label2.Text = "창고코드";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(421, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 44);
            this.btnSearch.TabIndex = 144;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 141;
            this.label1.Text = "이동날짜";
            // 
            // move_date
            // 
            this.move_date.Location = new System.Drawing.Point(116, 126);
            this.move_date.Name = "move_date";
            this.move_date.Size = new System.Drawing.Size(200, 32);
            this.move_date.TabIndex = 140;
            // 
            // warehouseBtn
            // 
            this.warehouseBtn.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.warehouseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.warehouseBtn.Font = new System.Drawing.Font("굴림", 10F);
            this.warehouseBtn.Location = new System.Drawing.Point(339, 29);
            this.warehouseBtn.Margin = new System.Windows.Forms.Padding(5);
            this.warehouseBtn.Name = "warehouseBtn";
            this.warehouseBtn.Size = new System.Drawing.Size(39, 37);
            this.warehouseBtn.TabIndex = 145;
            this.warehouseBtn.UseVisualStyleBackColor = true;
            this.warehouseBtn.Click += new System.EventHandler(this.warehouseBtn_Click_1);
            // 
            // warehouseCode
            // 
            this.warehouseCode.Location = new System.Drawing.Point(116, 29);
            this.warehouseCode.Name = "warehouseCode";
            this.warehouseCode.Size = new System.Drawing.Size(200, 32);
            this.warehouseCode.TabIndex = 143;
            // 
            // Frm_ImportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 1026);
            this.Controls.Add(this.importGrid);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.move_date);
            this.Controls.Add(this.warehouseBtn);
            this.Controls.Add(this.warehouseCode);
            this.Name = "Frm_ImportList";
            this.Text = "입고확인서 출력";
            this.Load += new System.EventHandler(this.Frm_ImportList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView importGrid;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker move_date;
        private System.Windows.Forms.Button warehouseBtn;
        private System.Windows.Forms.TextBox warehouseCode;
    }
}