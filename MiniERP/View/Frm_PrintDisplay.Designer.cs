namespace MiniERP.View
{
    partial class Frm_PrintDisplay
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.first_panel = new System.Windows.Forms.Panel();
            this.combo_Count = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.first_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Search);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Search);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.first_panel);
            this.splitContainer1.Size = new System.Drawing.Size(658, 450);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(211, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(12, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(193, 21);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(274, 397);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // first_panel
            // 
            this.first_panel.Controls.Add(this.combo_Count);
            this.first_panel.Controls.Add(this.label1);
            this.first_panel.Controls.Add(this.pictureBox1);
            this.first_panel.Controls.Add(this.btn_Print);
            this.first_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.first_panel.Location = new System.Drawing.Point(0, 0);
            this.first_panel.Name = "first_panel";
            this.first_panel.Size = new System.Drawing.Size(357, 450);
            this.first_panel.TabIndex = 3;
            // 
            // combo_Count
            // 
            this.combo_Count.FormattingEnabled = true;
            this.combo_Count.Location = new System.Drawing.Point(66, 169);
            this.combo_Count.Name = "combo_Count";
            this.combo_Count.Size = new System.Drawing.Size(70, 20);
            this.combo_Count.TabIndex = 3;
            this.combo_Count.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "이미지 더블클릭시 출력합니다.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(18, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(142, 167);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 1;
            this.btn_Print.Text = "출력";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "이미지|*.png";
            this.saveFileDialog1.Title = "저장";
            // 
            // Frm_PrintDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_PrintDisplay";
            this.Text = "Frm_PrintDisplay";
            this.Load += new System.EventHandler(this.Frm_PrintDisplay_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.first_panel.ResumeLayout(false);
            this.first_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel first_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.ComboBox combo_Count;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}