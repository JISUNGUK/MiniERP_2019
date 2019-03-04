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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.produceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produceGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.produceGrid.Location = new System.Drawing.Point(15, 50);
            this.produceGrid.Name = "produceGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.produceGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.produceGrid.RowTemplate.Height = 23;
            this.produceGrid.Size = new System.Drawing.Size(1128, 503);
            this.produceGrid.TabIndex = 78;
            this.produceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produceGrid_CellContentClick);
            // 
            // exportExcel
            // 
            this.exportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportExcel.Font = new System.Drawing.Font("굴림", 10F);
            this.exportExcel.Location = new System.Drawing.Point(886, 22);
            this.exportExcel.Name = "exportExcel";
            this.exportExcel.Size = new System.Drawing.Size(140, 23);
            this.exportExcel.TabIndex = 144;
            this.exportExcel.Text = "Excel로 내보내기";
            this.exportExcel.UseVisualStyleBackColor = true;
            this.exportExcel.Click += new System.EventHandler(this.exportExcel_Click);
            // 
            // orderSearch
            // 
            this.orderSearch.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.orderSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.orderSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderSearch.Font = new System.Drawing.Font("굴림", 10F);
            this.orderSearch.Location = new System.Drawing.Point(354, 19);
            this.orderSearch.Name = "orderSearch";
            this.orderSearch.Size = new System.Drawing.Size(25, 25);
            this.orderSearch.TabIndex = 145;
            this.orderSearch.UseVisualStyleBackColor = true;
            this.orderSearch.Click += new System.EventHandler(this.orderSearch_Click);
            // 
            // ordercode
            // 
            this.ordercode.Location = new System.Drawing.Point(125, 19);
            this.ordercode.Name = "ordercode";
            this.ordercode.Size = new System.Drawing.Size(209, 21);
            this.ordercode.TabIndex = 140;
            // 
            // searchPlan
            // 
            this.searchPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPlan.Location = new System.Drawing.Point(399, 19);
            this.searchPlan.Name = "searchPlan";
            this.searchPlan.Size = new System.Drawing.Size(75, 23);
            this.searchPlan.TabIndex = 139;
            this.searchPlan.Text = "검색";
            this.searchPlan.UseVisualStyleBackColor = true;
            this.searchPlan.Click += new System.EventHandler(this.searchPlan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 137;
            this.label5.Text = "주문코드";
            // 
            // Frm_productionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 586);
            this.Controls.Add(this.exportExcel);
            this.Controls.Add(this.orderSearch);
            this.Controls.Add(this.ordercode);
            this.Controls.Add(this.searchPlan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.produceGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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