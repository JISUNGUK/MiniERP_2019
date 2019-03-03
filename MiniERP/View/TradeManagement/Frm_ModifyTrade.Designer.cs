namespace MiniERP.View.TradeManagement
{
    partial class Frm_ModifyTrade
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
            this.txt_ClerkName = new System.Windows.Forms.TextBox();
            this.txt_WareCode = new System.Windows.Forms.TextBox();
            this.lab_Warehouse = new System.Windows.Forms.Label();
            this.txt_ClerkCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Warehouse = new System.Windows.Forms.Button();
            this.btn_Clerk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lv_Item = new System.Windows.Forms.ListView();
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_WareName
            // 
            this.txt_WareName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_WareName.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_WareName.Location = new System.Drawing.Point(193, 40);
            this.txt_WareName.Name = "txt_WareName";
            this.txt_WareName.ReadOnly = true;
            this.txt_WareName.Size = new System.Drawing.Size(148, 23);
            this.txt_WareName.TabIndex = 146;
            // 
            // txt_ClerkName
            // 
            this.txt_ClerkName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ClerkName.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_ClerkName.Location = new System.Drawing.Point(193, 12);
            this.txt_ClerkName.Name = "txt_ClerkName";
            this.txt_ClerkName.ReadOnly = true;
            this.txt_ClerkName.Size = new System.Drawing.Size(148, 23);
            this.txt_ClerkName.TabIndex = 145;
            // 
            // txt_WareCode
            // 
            this.txt_WareCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_WareCode.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_WareCode.Location = new System.Drawing.Point(87, 41);
            this.txt_WareCode.Name = "txt_WareCode";
            this.txt_WareCode.ReadOnly = true;
            this.txt_WareCode.Size = new System.Drawing.Size(100, 23);
            this.txt_WareCode.TabIndex = 143;
            // 
            // lab_Warehouse
            // 
            this.lab_Warehouse.AutoSize = true;
            this.lab_Warehouse.Font = new System.Drawing.Font("굴림", 10F);
            this.lab_Warehouse.Location = new System.Drawing.Point(18, 44);
            this.lab_Warehouse.Name = "lab_Warehouse";
            this.lab_Warehouse.Size = new System.Drawing.Size(35, 14);
            this.lab_Warehouse.TabIndex = 142;
            this.lab_Warehouse.Text = "창고";
            // 
            // txt_ClerkCode
            // 
            this.txt_ClerkCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ClerkCode.Font = new System.Drawing.Font("굴림", 10F);
            this.txt_ClerkCode.Location = new System.Drawing.Point(87, 12);
            this.txt_ClerkCode.Name = "txt_ClerkCode";
            this.txt_ClerkCode.ReadOnly = true;
            this.txt_ClerkCode.Size = new System.Drawing.Size(100, 23);
            this.txt_ClerkCode.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 139;
            this.label2.Text = "담당자";
            // 
            // btn_Warehouse
            // 
            this.btn_Warehouse.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.btn_Warehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Warehouse.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Warehouse.Location = new System.Drawing.Point(347, 40);
            this.btn_Warehouse.Name = "btn_Warehouse";
            this.btn_Warehouse.Size = new System.Drawing.Size(25, 25);
            this.btn_Warehouse.TabIndex = 144;
            this.btn_Warehouse.UseVisualStyleBackColor = true;
            this.btn_Warehouse.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Clerk
            // 
            this.btn_Clerk.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.btn_Clerk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clerk.Font = new System.Drawing.Font("굴림", 10F);
            this.btn_Clerk.Location = new System.Drawing.Point(347, 12);
            this.btn_Clerk.Name = "btn_Clerk";
            this.btn_Clerk.Size = new System.Drawing.Size(25, 25);
            this.btn_Clerk.TabIndex = 141;
            this.btn_Clerk.UseVisualStyleBackColor = true;
            this.btn_Clerk.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(18, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 151;
            this.label1.Text = "거래상태";
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(87, 81);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(121, 20);
            this.cmb_status.TabIndex = 152;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(297, 78);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 153;
            this.btn_Update.Text = "수정";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lv_Item
            // 
            this.lv_Item.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code,
            this.name,
            this.count,
            this.fee});
            this.lv_Item.Location = new System.Drawing.Point(21, 134);
            this.lv_Item.Name = "lv_Item";
            this.lv_Item.Size = new System.Drawing.Size(351, 218);
            this.lv_Item.TabIndex = 154;
            this.lv_Item.UseCompatibleStateImageBehavior = false;
            this.lv_Item.View = System.Windows.Forms.View.Details;
            this.lv_Item.SelectedIndexChanged += new System.EventHandler(this.lv_Item_SelectedIndexChanged);
            // 
            // code
            // 
            this.code.Text = "품목코드";
            this.code.Width = 89;
            // 
            // name
            // 
            this.name.Text = "품목이름";
            this.name.Width = 104;
            // 
            // count
            // 
            this.count.Text = "갯수";
            this.count.Width = 70;
            // 
            // fee
            // 
            this.fee.Text = "가격";
            this.fee.Width = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 155;
            this.label3.Text = "주문 품목";
            // 
            // Frm_ModifyTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lv_Item);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_WareName);
            this.Controls.Add(this.txt_ClerkName);
            this.Controls.Add(this.btn_Warehouse);
            this.Controls.Add(this.txt_WareCode);
            this.Controls.Add(this.lab_Warehouse);
            this.Controls.Add(this.btn_Clerk);
            this.Controls.Add(this.txt_ClerkCode);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_ModifyTrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "거래수정";
            this.Load += new System.EventHandler(this.Frm_ModifyTrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_WareName;
        private System.Windows.Forms.TextBox txt_ClerkName;
        private System.Windows.Forms.Button btn_Warehouse;
        private System.Windows.Forms.TextBox txt_WareCode;
        private System.Windows.Forms.Label lab_Warehouse;
        private System.Windows.Forms.Button btn_Clerk;
        private System.Windows.Forms.TextBox txt_ClerkCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ListView lv_Item;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader fee;
        private System.Windows.Forms.Label label3;
    }
}