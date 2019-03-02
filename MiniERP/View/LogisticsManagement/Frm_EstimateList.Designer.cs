﻿namespace MiniERP.View.LogisticsManagement
{
    partial class Frm_EstimateList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sampleOrder = new System.Windows.Forms.DataGridView();
            this.exportExcel = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.orderedCode = new System.Windows.Forms.TextBox();
            this.itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_written_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sampleOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleOrder
            // 
            this.sampleOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sampleOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.sampleOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sampleOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemcode,
            this.itemName,
            this.count,
            this.standard,
            this.item_written_fee,
            this.unit});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sampleOrder.DefaultCellStyle = dataGridViewCellStyle6;
            this.sampleOrder.Location = new System.Drawing.Point(19, 72);
            this.sampleOrder.Margin = new System.Windows.Forms.Padding(5);
            this.sampleOrder.Name = "sampleOrder";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sampleOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sampleOrder.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.sampleOrder.RowTemplate.Height = 23;
            this.sampleOrder.Size = new System.Drawing.Size(1773, 895);
            this.sampleOrder.TabIndex = 91;
            // 
            // exportExcel
            // 
            this.exportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportExcel.Font = new System.Drawing.Font("굴림", 10F);
            this.exportExcel.Location = new System.Drawing.Point(1406, 14);
            this.exportExcel.Margin = new System.Windows.Forms.Padding(5);
            this.exportExcel.Name = "exportExcel";
            this.exportExcel.Size = new System.Drawing.Size(220, 40);
            this.exportExcel.TabIndex = 132;
            this.exportExcel.Text = "Excel로 내보내기";
            this.exportExcel.UseVisualStyleBackColor = true;
            this.exportExcel.Click += new System.EventHandler(this.exportExcel_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.orderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.orderBtn.Font = new System.Drawing.Font("굴림", 10F);
            this.orderBtn.Location = new System.Drawing.Point(502, 20);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(5);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(39, 37);
            this.orderBtn.TabIndex = 133;
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click_1);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(571, 20);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(118, 40);
            this.btn_search.TabIndex = 131;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 130;
            this.label5.Text = "주문번호";
            // 
            // orderedCode
            // 
            this.orderedCode.Location = new System.Drawing.Point(158, 24);
            this.orderedCode.Name = "orderedCode";
            this.orderedCode.Size = new System.Drawing.Size(297, 32);
            this.orderedCode.TabIndex = 134;
            // 
            // itemcode
            // 
            this.itemcode.HeaderText = "품목코드";
            this.itemcode.Name = "itemcode";
            // 
            // itemName
            // 
            this.itemName.HeaderText = "품목명";
            this.itemName.Name = "itemName";
            // 
            // count
            // 
            this.count.HeaderText = "수량";
            this.count.Name = "count";
            // 
            // standard
            // 
            this.standard.HeaderText = "규격";
            this.standard.Name = "standard";
            // 
            // item_written_fee
            // 
            this.item_written_fee.HeaderText = "단가";
            this.item_written_fee.Name = "item_written_fee";
            // 
            // unit
            // 
            this.unit.HeaderText = "단위";
            this.unit.Name = "unit";
            // 
            // Frm_EstimateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1811, 1026);
            this.Controls.Add(this.orderedCode);
            this.Controls.Add(this.exportExcel);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sampleOrder);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_EstimateList";
            this.Text = "견적서 조회";
            this.Resize += new System.EventHandler(this.Frm_EstimateList_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.sampleOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView sampleOrder;
        private System.Windows.Forms.Button exportExcel;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderedCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn standard;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_written_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
    }
}