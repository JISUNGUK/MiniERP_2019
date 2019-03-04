namespace MiniERP.View.BusinessManagement
{
    partial class Frm_OrderList
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_KeyWord = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_totalFee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(344, 461);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Search.Location = new System.Drawing.Point(423, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(82, 23);
            this.btn_Search.TabIndex = 84;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_KeyWord
            // 
            this.txt_KeyWord.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_KeyWord.Location = new System.Drawing.Point(12, 12);
            this.txt_KeyWord.Name = "txt_KeyWord";
            this.txt_KeyWord.Size = new System.Drawing.Size(405, 23);
            this.txt_KeyWord.TabIndex = 83;
            this.txt_KeyWord.Text = "거래처명으로 검색";
            this.txt_KeyWord.Click += new System.EventHandler(this.txt_KeyWord_Click);
            this.txt_KeyWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyWord_KeyDown);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(362, 74);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(778, 426);
            this.dataGridView2.TabIndex = 103;
            // 
            // lbl_totalFee
            // 
            this.lbl_totalFee.AutoSize = true;
            this.lbl_totalFee.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_totalFee.Location = new System.Drawing.Point(975, 503);
            this.lbl_totalFee.Name = "lbl_totalFee";
            this.lbl_totalFee.Size = new System.Drawing.Size(0, 19);
            this.lbl_totalFee.TabIndex = 104;
            // 
            // Frm_OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 571);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_totalFee);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_KeyWord);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_OrderList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "주문서 조회";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Frm_OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_KeyWord;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_totalFee;
    }
}