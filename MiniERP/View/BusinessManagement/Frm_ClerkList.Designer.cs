namespace MiniERP.View.BusinessManagement
{
    partial class Frm_ClerkList
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
            this.pnl_serchbox = new System.Windows.Forms.Panel();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.btnSearchClerk = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn_ClerkInsert = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.txtCodeOrName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_serchbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_serchbox
            // 
            this.pnl_serchbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_serchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_serchbox.Controls.Add(this.cmbJob);
            this.pnl_serchbox.Controls.Add(this.btnSearchClerk);
            this.pnl_serchbox.Controls.Add(this.txtName);
            this.pnl_serchbox.Controls.Add(this.label1);
            this.pnl_serchbox.Controls.Add(this.btnSelect);
            this.pnl_serchbox.Controls.Add(this.label6);
            this.pnl_serchbox.Location = new System.Drawing.Point(12, 40);
            this.pnl_serchbox.Name = "pnl_serchbox";
            this.pnl_serchbox.Size = new System.Drawing.Size(799, 62);
            this.pnl_serchbox.TabIndex = 119;
            this.pnl_serchbox.Visible = false;
            // 
            // cmbJob
            // 
            this.cmbJob.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Items.AddRange(new object[] {
            "사원",
            "대리",
            "팀장",
            "과장",
            "장군"});
            this.cmbJob.Location = new System.Drawing.Point(462, 21);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(229, 20);
            this.cmbJob.TabIndex = 98;
            // 
            // btnSearchClerk
            // 
            this.btnSearchClerk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearchClerk.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.btnSearchClerk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchClerk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchClerk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchClerk.Location = new System.Drawing.Point(202, 21);
            this.btnSearchClerk.Name = "btnSearchClerk";
            this.btnSearchClerk.Size = new System.Drawing.Size(22, 23);
            this.btnSearchClerk.TabIndex = 97;
            this.btnSearchClerk.UseVisualStyleBackColor = true;
            this.btnSearchClerk.Click += new System.EventHandler(this.btnSearchClerk_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtName.Location = new System.Drawing.Point(106, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(81, 21);
            this.txtName.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(391, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 94;
            this.label1.Text = "직       급";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSelect.Font = new System.Drawing.Font("굴림", 10F);
            this.btnSelect.Location = new System.Drawing.Point(697, 21);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(82, 23);
            this.btnSelect.TabIndex = 91;
            this.btnSelect.Text = "검색";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(35, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "사원 이름";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Font = new System.Drawing.Font("굴림", 10F);
            this.btnDelete.Location = new System.Drawing.Point(114, 572);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 121;
            this.btnDelete.Text = "선택삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_ClerkInsert
            // 
            this.btn_ClerkInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ClerkInsert.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_ClerkInsert.Location = new System.Drawing.Point(12, 572);
            this.btn_ClerkInsert.Name = "btn_ClerkInsert";
            this.btn_ClerkInsert.Size = new System.Drawing.Size(75, 23);
            this.btn_ClerkInsert.TabIndex = 120;
            this.btn_ClerkInsert.Text = "신규";
            this.btn_ClerkInsert.UseVisualStyleBackColor = true;
            this.btn_ClerkInsert.Click += new System.EventHandler(this.btn_ClerkInsert_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("굴림", 10F);
            this.button9.Location = new System.Drawing.Point(423, 11);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 23);
            this.button9.TabIndex = 118;
            this.button9.Text = "검색";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // txtCodeOrName
            // 
            this.txtCodeOrName.Font = new System.Drawing.Font("굴림", 10F);
            this.txtCodeOrName.Location = new System.Drawing.Point(12, 11);
            this.txtCodeOrName.Name = "txtCodeOrName";
            this.txtCodeOrName.Size = new System.Drawing.Size(405, 23);
            this.txtCodeOrName.TabIndex = 117;
            this.txtCodeOrName.Text = "사원이름을 입력하세요.";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(799, 487);
            this.dataGridView1.TabIndex = 116;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Frm_ClerkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 607);
            this.Controls.Add(this.pnl_serchbox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_ClerkInsert);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.txtCodeOrName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_ClerkList";
            this.Text = "사원 조회";
            this.Load += new System.EventHandler(this.Frm_ClerkList_Load);
            this.pnl_serchbox.ResumeLayout(false);
            this.pnl_serchbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_serchbox;
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.Button btnSearchClerk;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn_ClerkInsert;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtCodeOrName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}