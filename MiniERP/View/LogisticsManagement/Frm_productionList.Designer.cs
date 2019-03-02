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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.produceGrid = new System.Windows.Forms.DataGridView();
            this.exportExcel = new System.Windows.Forms.Button();
            this.orderSearch = new System.Windows.Forms.Button();
            this.ordercode = new System.Windows.Forms.TextBox();
            this.searchPlan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // produceGrid
            // 
            this.produceGrid.AllowUserToAddRows = false;
            this.produceGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.produceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produceGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.produceGrid.Location = new System.Drawing.Point(24, 88);
            this.produceGrid.Margin = new System.Windows.Forms.Padding(5);
            this.produceGrid.Name = "produceGrid";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.produceGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.produceGrid.RowTemplate.Height = 23;
            this.produceGrid.Size = new System.Drawing.Size(1773, 880);
            this.produceGrid.TabIndex = 78;
            // 
            // exportExcel
            // 
            this.exportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportExcel.Font = new System.Drawing.Font("굴림", 10F);
            this.exportExcel.Location = new System.Drawing.Point(1393, 38);
            this.exportExcel.Margin = new System.Windows.Forms.Padding(5);
            this.exportExcel.Name = "exportExcel";
            this.exportExcel.Size = new System.Drawing.Size(220, 40);
            this.exportExcel.TabIndex = 144;
            this.exportExcel.Text = "Excel로 내보내기";
            this.exportExcel.UseVisualStyleBackColor = true;
            this.exportExcel.Click += new System.EventHandler(this.exportExcel_Click);
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
            this.orderSearch.Click += new System.EventHandler(this.orderSearch_Click);
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
            this.searchPlan.Location = new System.Drawing.Point(627, 34);
            this.searchPlan.Margin = new System.Windows.Forms.Padding(5);
            this.searchPlan.Name = "searchPlan";
            this.searchPlan.Size = new System.Drawing.Size(118, 40);
            this.searchPlan.TabIndex = 139;
            this.searchPlan.Text = "검색";
            this.searchPlan.UseVisualStyleBackColor = true;
            this.searchPlan.Click += new System.EventHandler(this.searchPlan_Click);
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
            this.Controls.Add(this.orderSearch);
            this.Controls.Add(this.ordercode);
            this.Controls.Add(this.searchPlan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.produceGrid);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_productionList";
            this.Text = "생산계획 조회";
            ((System.ComponentModel.ISupportInitialize)(this.produceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView produceGrid;
        private System.Windows.Forms.Button exportExcel;
        private System.Windows.Forms.Button orderSearch;
        private System.Windows.Forms.TextBox ordercode;
        private System.Windows.Forms.Button searchPlan;
        private System.Windows.Forms.Label label5;
    }
}