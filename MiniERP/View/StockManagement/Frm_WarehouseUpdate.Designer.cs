namespace MiniERP.View.StockManagement
{
    partial class Frm_WarehouseUpdate
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rdoWarehouse = new System.Windows.Forms.RadioButton();
            this.rdoFactory = new System.Windows.Forms.RadioButton();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "창고(공장)코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "창고(공장)명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "구분";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("굴림", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(64, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rdoWarehouse
            // 
            this.rdoWarehouse.AutoSize = true;
            this.rdoWarehouse.Font = new System.Drawing.Font("굴림", 10F);
            this.rdoWarehouse.Location = new System.Drawing.Point(151, 91);
            this.rdoWarehouse.Name = "rdoWarehouse";
            this.rdoWarehouse.Size = new System.Drawing.Size(53, 18);
            this.rdoWarehouse.TabIndex = 4;
            this.rdoWarehouse.TabStop = true;
            this.rdoWarehouse.Text = "창고";
            this.rdoWarehouse.UseVisualStyleBackColor = true;
            // 
            // rdoFactory
            // 
            this.rdoFactory.AutoSize = true;
            this.rdoFactory.Font = new System.Drawing.Font("굴림", 10F);
            this.rdoFactory.Location = new System.Drawing.Point(244, 92);
            this.rdoFactory.Name = "rdoFactory";
            this.rdoFactory.Size = new System.Drawing.Size(53, 18);
            this.rdoFactory.TabIndex = 5;
            this.rdoFactory.TabStop = true;
            this.rdoFactory.Text = "공장";
            this.rdoFactory.UseVisualStyleBackColor = true;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("굴림", 10F);
            this.lblCode.Location = new System.Drawing.Point(148, 9);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 14);
            this.lblCode.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("굴림", 10F);
            this.txtName.Location = new System.Drawing.Point(151, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 23);
            this.txtName.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("굴림", 10F);
            this.btnClose.Location = new System.Drawing.Point(186, 133);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Frm_WarehouseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 168);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.rdoFactory);
            this.Controls.Add(this.rdoWarehouse);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_WarehouseUpdate";
            this.Text = "창고 수정";
            this.Load += new System.EventHandler(this.Frm_WarehouseUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rdoWarehouse;
        private System.Windows.Forms.RadioButton rdoFactory;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClose;
    }
}