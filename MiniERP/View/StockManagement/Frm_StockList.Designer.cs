﻿namespace MiniERP.View.StockManagement
{
    partial class Frm_StockList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_serch = new System.Windows.Forms.Button();
            this.txtCodeOrName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnl_serchbox = new System.Windows.Forms.Panel();
            this.rdoFactory = new System.Windows.Forms.RadioButton();
            this.rdoWarehouse = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.btnSearchWarehouse = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_serchbox.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(799, 526);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // btn_serch
            // 
            this.btn_serch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_serch.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_serch.Location = new System.Drawing.Point(423, 7);
            this.btn_serch.Name = "btn_serch";
            this.btn_serch.Size = new System.Drawing.Size(82, 23);
            this.btn_serch.TabIndex = 9;
            this.btn_serch.Text = "검색";
            this.btn_serch.UseVisualStyleBackColor = true;
            this.btn_serch.Click += new System.EventHandler(this.btn_serch_Click);
            // 
            // txtCodeOrName
            // 
            this.txtCodeOrName.Font = new System.Drawing.Font("굴림", 10F);
            this.txtCodeOrName.Location = new System.Drawing.Point(12, 7);
            this.txtCodeOrName.Name = "txtCodeOrName";
            this.txtCodeOrName.Size = new System.Drawing.Size(405, 23);
            this.txtCodeOrName.TabIndex = 8;
            this.txtCodeOrName.Text = "창고명을 입력하세요.";
            this.txtCodeOrName.Click += new System.EventHandler(this.txtCodeOrName_Click);
            this.txtCodeOrName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodeOrName_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 10F);
            this.btnDelete.Location = new System.Drawing.Point(114, 583);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "선택삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("굴림", 10F);
            this.btnInsert.Location = new System.Drawing.Point(12, 583);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "신규";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // pnl_serchbox
            // 
            this.pnl_serchbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_serchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_serchbox.Controls.Add(this.rdoFactory);
            this.pnl_serchbox.Controls.Add(this.rdoWarehouse);
            this.pnl_serchbox.Controls.Add(this.rdoAll);
            this.pnl_serchbox.Controls.Add(this.btnSearchWarehouse);
            this.pnl_serchbox.Controls.Add(this.txtName);
            this.pnl_serchbox.Controls.Add(this.txtCode);
            this.pnl_serchbox.Controls.Add(this.btnSelect);
            this.pnl_serchbox.Controls.Add(this.label4);
            this.pnl_serchbox.Controls.Add(this.label3);
            this.pnl_serchbox.Controls.Add(this.label2);
            this.pnl_serchbox.Controls.Add(this.label1);
            this.pnl_serchbox.Location = new System.Drawing.Point(12, 36);
            this.pnl_serchbox.Name = "pnl_serchbox";
            this.pnl_serchbox.Size = new System.Drawing.Size(799, 102);
            this.pnl_serchbox.TabIndex = 14;
            this.pnl_serchbox.Visible = false;
            // 
            // rdoFactory
            // 
            this.rdoFactory.AutoSize = true;
            this.rdoFactory.Location = new System.Drawing.Point(251, 60);
            this.rdoFactory.Name = "rdoFactory";
            this.rdoFactory.Size = new System.Drawing.Size(47, 16);
            this.rdoFactory.TabIndex = 12;
            this.rdoFactory.TabStop = true;
            this.rdoFactory.Text = "공장";
            this.rdoFactory.UseVisualStyleBackColor = true;
            // 
            // rdoWarehouse
            // 
            this.rdoWarehouse.AutoSize = true;
            this.rdoWarehouse.Location = new System.Drawing.Point(171, 60);
            this.rdoWarehouse.Name = "rdoWarehouse";
            this.rdoWarehouse.Size = new System.Drawing.Size(47, 16);
            this.rdoWarehouse.TabIndex = 11;
            this.rdoWarehouse.TabStop = true;
            this.rdoWarehouse.Text = "창고";
            this.rdoWarehouse.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(91, 60);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(47, 16);
            this.rdoAll.TabIndex = 10;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "전체";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // btnSearchWarehouse
            // 
            this.btnSearchWarehouse.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.btnSearchWarehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchWarehouse.Location = new System.Drawing.Point(315, 23);
            this.btnSearchWarehouse.Name = "btnSearchWarehouse";
            this.btnSearchWarehouse.Size = new System.Drawing.Size(25, 25);
            this.btnSearchWarehouse.TabIndex = 9;
            this.btnSearchWarehouse.UseVisualStyleBackColor = true;
            this.btnSearchWarehouse.Click += new System.EventHandler(this.btnSearchWarehouse_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(455, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 21);
            this.txtName.TabIndex = 8;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(91, 26);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(218, 21);
            this.txtCode.TabIndex = 7;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(721, 76);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "검색";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "구분";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "창고명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "창고코드";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "검색 기능";
            // 
            // Frm_StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 618);
            this.Controls.Add(this.pnl_serchbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_serch);
            this.Controls.Add(this.txtCodeOrName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_StockList";
            this.Text = "창고 조회";
            this.Load += new System.EventHandler(this.Frm_StockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_serchbox.ResumeLayout(false);
            this.pnl_serchbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_serch;
        private System.Windows.Forms.TextBox txtCodeOrName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel pnl_serchbox;
        private System.Windows.Forms.Button btnSearchWarehouse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoFactory;
        private System.Windows.Forms.RadioButton rdoWarehouse;
        private System.Windows.Forms.RadioButton rdoAll;
    }
}