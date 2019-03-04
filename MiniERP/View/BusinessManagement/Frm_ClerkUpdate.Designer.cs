namespace MiniERP.View.BusinessManagement
{
    partial class Frm_ClerkUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "사원코드";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("굴림", 10F);
            this.lblCode.Location = new System.Drawing.Point(114, 9);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 14);
            this.lblCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "사원명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "직급";
            // 
            // cmbJob
            // 
            this.cmbJob.Font = new System.Drawing.Font("굴림", 10F);
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Items.AddRange(new object[] {
            "사원",
            "대리",
            "팀장",
            "과장",
            "사장",
            "PM"});
            this.cmbJob.Location = new System.Drawing.Point(117, 104);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(195, 21);
            this.cmbJob.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("굴림", 10F);
            this.txtName.Location = new System.Drawing.Point(117, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 23);
            this.txtName.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("굴림", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(59, 154);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("굴림", 10F);
            this.btnClose.Location = new System.Drawing.Point(192, 154);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Frm_ClerkUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 189);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbJob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_ClerkUpdate";
            this.Text = "사원정보 수정";
            this.Load += new System.EventHandler(this.Frm_ClerkUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
    }
}