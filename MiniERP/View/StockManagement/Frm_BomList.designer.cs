namespace MiniERP.View.StockManagement
{
    partial class Frm_BomList
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPartCode = new System.Windows.Forms.TextBox();
            this.pnl_serchbox = new System.Windows.Forms.Panel();
            this.btnItemSearch = new System.Windows.Forms.Button();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.btnPartSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCodeOrName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_serchbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Font = new System.Drawing.Font("굴림", 10F);
            this.btnDelete.Location = new System.Drawing.Point(114, 585);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 108;
            this.btnDelete.Text = "선택삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.Font = new System.Drawing.Font("굴림", 10F);
            this.btnInsert.Location = new System.Drawing.Point(12, 585);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 107;
            this.btnInsert.Text = "신규";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("굴림", 10F);
            this.btnSelect.Location = new System.Drawing.Point(712, 63);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(82, 23);
            this.btnSelect.TabIndex = 91;
            this.btnSelect.Text = "검색";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(413, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 82;
            this.label5.Text = "파트번호";
            // 
            // txtPartCode
            // 
            this.txtPartCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartCode.Location = new System.Drawing.Point(494, 27);
            this.txtPartCode.Name = "txtPartCode";
            this.txtPartCode.ReadOnly = true;
            this.txtPartCode.Size = new System.Drawing.Size(181, 21);
            this.txtPartCode.TabIndex = 87;
            // 
            // pnl_serchbox
            // 
            this.pnl_serchbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_serchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_serchbox.Controls.Add(this.btnItemSearch);
            this.pnl_serchbox.Controls.Add(this.txtItemCode);
            this.pnl_serchbox.Controls.Add(this.btnSelect);
            this.pnl_serchbox.Controls.Add(this.label5);
            this.pnl_serchbox.Controls.Add(this.btnPartSearch);
            this.pnl_serchbox.Controls.Add(this.txtPartCode);
            this.pnl_serchbox.Controls.Add(this.label6);
            this.pnl_serchbox.Location = new System.Drawing.Point(12, 44);
            this.pnl_serchbox.Name = "pnl_serchbox";
            this.pnl_serchbox.Size = new System.Drawing.Size(799, 91);
            this.pnl_serchbox.TabIndex = 106;
            this.pnl_serchbox.Visible = false;
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemSearch.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.btnItemSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnItemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnItemSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnItemSearch.Location = new System.Drawing.Point(356, 24);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(22, 23);
            this.btnItemSearch.TabIndex = 97;
            this.btnItemSearch.UseVisualStyleBackColor = true;
            this.btnItemSearch.Click += new System.EventHandler(this.btnItemSearch_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemCode.Location = new System.Drawing.Point(114, 26);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(236, 21);
            this.txtItemCode.TabIndex = 96;
            // 
            // btnPartSearch
            // 
            this.btnPartSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPartSearch.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.btnPartSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPartSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPartSearch.Location = new System.Drawing.Point(688, 26);
            this.btnPartSearch.Name = "btnPartSearch";
            this.btnPartSearch.Size = new System.Drawing.Size(22, 23);
            this.btnPartSearch.TabIndex = 90;
            this.btnPartSearch.UseVisualStyleBackColor = true;
            this.btnPartSearch.Click += new System.EventHandler(this.btnPartSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(21, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "품목번호";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("굴림", 10F);
            this.btnSearch.Location = new System.Drawing.Point(423, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 23);
            this.btnSearch.TabIndex = 105;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCodeOrName
            // 
            this.txtCodeOrName.Font = new System.Drawing.Font("굴림", 10F);
            this.txtCodeOrName.Location = new System.Drawing.Point(12, 12);
            this.txtCodeOrName.Name = "txtCodeOrName";
            this.txtCodeOrName.Size = new System.Drawing.Size(405, 23);
            this.txtCodeOrName.TabIndex = 104;
            this.txtCodeOrName.Text = "BOM 번호 및 품목명을 입력하세요.";
            this.txtCodeOrName.Click += new System.EventHandler(this.txtCodeOrName_Click);
            this.txtCodeOrName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodeOrName_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(799, 506);
            this.dataGridView1.TabIndex = 103;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "품목코드";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "품목이름";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "조회";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Frm_BomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 618);
            this.Controls.Add(this.pnl_serchbox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCodeOrName);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_BomList";
            this.Text = "BOM 조회";
            this.Load += new System.EventHandler(this.Frm_BomList_Load);
            this.Click += new System.EventHandler(this.Frm_BomList_Click);
            this.pnl_serchbox.ResumeLayout(false);
            this.pnl_serchbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPartSearch;
        private System.Windows.Forms.TextBox txtPartCode;
        private System.Windows.Forms.Panel pnl_serchbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCodeOrName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnItemSearch;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}