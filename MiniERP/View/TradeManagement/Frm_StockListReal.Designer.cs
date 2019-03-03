namespace MiniERP.View.TradeManagement
{
    partial class Frm_StockListReal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StockListReal));
            this.gVIewStock = new System.Windows.Forms.DataGridView();
            this.warehouse_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_standard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_serch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txt_WareName = new System.Windows.Forms.TextBox();
            this.btn_Warehouse = new System.Windows.Forms.Button();
            this.txt_WareCode = new System.Windows.Forms.TextBox();
            this.lab_Warehouse = new System.Windows.Forms.Label();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.txt_ItemCode = new System.Windows.Forms.TextBox();
            this.btn_Item = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gVIewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // gVIewStock
            // 
            this.gVIewStock.AllowUserToAddRows = false;
            this.gVIewStock.AllowUserToDeleteRows = false;
            this.gVIewStock.AllowUserToResizeRows = false;
            resources.ApplyResources(this.gVIewStock, "gVIewStock");
            this.gVIewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVIewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehouse_code,
            this.warehouse_name,
            this.item_code,
            this.item_name,
            this.item_standard,
            this.item_count});
            this.gVIewStock.MultiSelect = false;
            this.gVIewStock.Name = "gVIewStock";
            this.gVIewStock.ReadOnly = true;
            this.gVIewStock.RowHeadersVisible = false;
            this.gVIewStock.RowTemplate.Height = 23;
            this.gVIewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // warehouse_code
            // 
            resources.ApplyResources(this.warehouse_code, "warehouse_code");
            this.warehouse_code.Name = "warehouse_code";
            this.warehouse_code.ReadOnly = true;
            // 
            // warehouse_name
            // 
            resources.ApplyResources(this.warehouse_name, "warehouse_name");
            this.warehouse_name.Name = "warehouse_name";
            this.warehouse_name.ReadOnly = true;
            // 
            // item_code
            // 
            resources.ApplyResources(this.item_code, "item_code");
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            // 
            // item_name
            // 
            resources.ApplyResources(this.item_name, "item_name");
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            // 
            // item_standard
            // 
            resources.ApplyResources(this.item_standard, "item_standard");
            this.item_standard.Name = "item_standard";
            this.item_standard.ReadOnly = true;
            // 
            // item_count
            // 
            resources.ApplyResources(this.item_count, "item_count");
            this.item_count.Name = "item_count";
            this.item_count.ReadOnly = true;
            // 
            // btn_serch
            // 
            resources.ApplyResources(this.btn_serch, "btn_serch");
            this.btn_serch.Name = "btn_serch";
            this.btn_serch.UseVisualStyleBackColor = true;
            this.btn_serch.Click += new System.EventHandler(this.btn_serch_Click);
            // 
            // btnInsert
            // 
            resources.ApplyResources(this.btnInsert, "btnInsert");
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txt_WareName
            // 
            this.txt_WareName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.txt_WareName, "txt_WareName");
            this.txt_WareName.Name = "txt_WareName";
            this.txt_WareName.ReadOnly = true;
            // 
            // btn_Warehouse
            // 
            this.btn_Warehouse.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            resources.ApplyResources(this.btn_Warehouse, "btn_Warehouse");
            this.btn_Warehouse.Name = "btn_Warehouse";
            this.btn_Warehouse.UseVisualStyleBackColor = true;
            this.btn_Warehouse.Click += new System.EventHandler(this.btn_Text_Click);
            // 
            // txt_WareCode
            // 
            this.txt_WareCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.txt_WareCode, "txt_WareCode");
            this.txt_WareCode.Name = "txt_WareCode";
            this.txt_WareCode.ReadOnly = true;
            // 
            // lab_Warehouse
            // 
            resources.ApplyResources(this.lab_Warehouse, "lab_Warehouse");
            this.lab_Warehouse.Name = "lab_Warehouse";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.txt_ItemName, "txt_ItemName");
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.ReadOnly = true;
            // 
            // txt_ItemCode
            // 
            this.txt_ItemCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.txt_ItemCode, "txt_ItemCode");
            this.txt_ItemCode.Name = "txt_ItemCode";
            this.txt_ItemCode.ReadOnly = true;
            // 
            // btn_Item
            // 
            this.btn_Item.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            resources.ApplyResources(this.btn_Item, "btn_Item");
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.UseVisualStyleBackColor = true;
            this.btn_Item.Click += new System.EventHandler(this.btn_Text_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Frm_StockListReal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.txt_ItemCode);
            this.Controls.Add(this.btn_Item);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_WareName);
            this.Controls.Add(this.btn_Warehouse);
            this.Controls.Add(this.txt_WareCode);
            this.Controls.Add(this.lab_Warehouse);
            this.Controls.Add(this.gVIewStock);
            this.Controls.Add(this.btn_serch);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_StockListReal";
            ((System.ComponentModel.ISupportInitialize)(this.gVIewStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gVIewStock;
        private System.Windows.Forms.Button btn_serch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txt_WareName;
        private System.Windows.Forms.Button btn_Warehouse;
        private System.Windows.Forms.TextBox txt_WareCode;
        private System.Windows.Forms.Label lab_Warehouse;
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.TextBox txt_ItemCode;
        private System.Windows.Forms.Button btn_Item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_standard;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_count;
    }
}