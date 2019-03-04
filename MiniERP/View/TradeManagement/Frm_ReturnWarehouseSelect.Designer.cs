namespace MiniERP.View.TradeManagement
{
    partial class Frm_ReturnWarehouseSelect
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
            this.cmb_Warehouse = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "입고창고 선택: ";
            // 
            // cmb_Warehouse
            // 
            this.cmb_Warehouse.FormattingEnabled = true;
            this.cmb_Warehouse.Location = new System.Drawing.Point(99, 6);
            this.cmb_Warehouse.Name = "cmb_Warehouse";
            this.cmb_Warehouse.Size = new System.Drawing.Size(121, 20);
            this.cmb_Warehouse.TabIndex = 1;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(14, 41);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(94, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "반품";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_ReturnWarehouseSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 75);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cmb_Warehouse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ReturnWarehouseSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_ReturnWarehouseSelect";
            this.Load += new System.EventHandler(this.Frm_ReturnWarehouseSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Warehouse;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button button2;
    }
}