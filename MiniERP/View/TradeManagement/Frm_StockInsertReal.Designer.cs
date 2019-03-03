namespace MiniERP.View.TradeManagement
{
    partial class Frm_StockInsertReal
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
            this.txt_WareName = new System.Windows.Forms.TextBox();
            this.txt_WareCode = new System.Windows.Forms.TextBox();
            this.lab_Warehouse = new System.Windows.Forms.Label();
            this.btn_Warehouse = new System.Windows.Forms.Button();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.txt_ItemCode = new System.Windows.Forms.TextBox();
            this.btn_Item = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_count = new System.Windows.Forms.NumericUpDown();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_WareName
            // 
            this.txt_WareName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_WareName.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_WareName.Location = new System.Drawing.Point(190, 11);
            this.txt_WareName.Name = "txt_WareName";
            this.txt_WareName.ReadOnly = true;
            this.txt_WareName.Size = new System.Drawing.Size(148, 23);
            this.txt_WareName.TabIndex = 142;
            // 
            // txt_WareCode
            // 
            this.txt_WareCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_WareCode.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_WareCode.Location = new System.Drawing.Point(84, 12);
            this.txt_WareCode.Name = "txt_WareCode";
            this.txt_WareCode.ReadOnly = true;
            this.txt_WareCode.Size = new System.Drawing.Size(100, 23);
            this.txt_WareCode.TabIndex = 140;
            // 
            // lab_Warehouse
            // 
            this.lab_Warehouse.AutoSize = true;
            this.lab_Warehouse.Font = new System.Drawing.Font("굴림", 10F);
            this.lab_Warehouse.Location = new System.Drawing.Point(15, 15);
            this.lab_Warehouse.Name = "lab_Warehouse";
            this.lab_Warehouse.Size = new System.Drawing.Size(63, 14);
            this.lab_Warehouse.TabIndex = 139;
            this.lab_Warehouse.Text = "저장창고";
            // 
            // btn_Warehouse
            // 
            this.btn_Warehouse.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.btn_Warehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Warehouse.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Warehouse.Location = new System.Drawing.Point(344, 11);
            this.btn_Warehouse.Name = "btn_Warehouse";
            this.btn_Warehouse.Size = new System.Drawing.Size(25, 25);
            this.btn_Warehouse.TabIndex = 141;
            this.btn_Warehouse.UseVisualStyleBackColor = true;
            this.btn_Warehouse.Click += new System.EventHandler(this.btn_Text_Click);
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ItemName.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_ItemName.Location = new System.Drawing.Point(190, 41);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.ReadOnly = true;
            this.txt_ItemName.Size = new System.Drawing.Size(148, 23);
            this.txt_ItemName.TabIndex = 146;
            // 
            // txt_ItemCode
            // 
            this.txt_ItemCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ItemCode.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_ItemCode.Location = new System.Drawing.Point(84, 41);
            this.txt_ItemCode.Name = "txt_ItemCode";
            this.txt_ItemCode.ReadOnly = true;
            this.txt_ItemCode.Size = new System.Drawing.Size(100, 23);
            this.txt_ItemCode.TabIndex = 145;
            // 
            // btn_Item
            // 
            this.btn_Item.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.btn_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Item.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Item.Location = new System.Drawing.Point(344, 41);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(25, 25);
            this.btn_Item.TabIndex = 144;
            this.btn_Item.UseVisualStyleBackColor = true;
            this.btn_Item.Click += new System.EventHandler(this.btn_Text_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(43, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 143;
            this.label3.Text = "품목";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(43, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 147;
            this.label1.Text = "개수";
            // 
            // num_count
            // 
            this.num_count.Location = new System.Drawing.Point(84, 70);
            this.num_count.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.num_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_count.Name = "num_count";
            this.num_count.Size = new System.Drawing.Size(100, 21);
            this.num_count.TabIndex = 148;
            this.num_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(294, 72);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 149;
            this.btn_Save.Text = "추가";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Frm_StockInsertReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 104);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.num_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.txt_ItemCode);
            this.Controls.Add(this.btn_Item);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_WareName);
            this.Controls.Add(this.btn_Warehouse);
            this.Controls.Add(this.txt_WareCode);
            this.Controls.Add(this.lab_Warehouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_StockInsertReal";
            this.Text = "재고 추가";
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_WareName;
        private System.Windows.Forms.Button btn_Warehouse;
        private System.Windows.Forms.TextBox txt_WareCode;
        private System.Windows.Forms.Label lab_Warehouse;
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.TextBox txt_ItemCode;
        private System.Windows.Forms.Button btn_Item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_count;
        private System.Windows.Forms.Button btn_Save;
    }
}