namespace MiniERP.View.LogisticsManagement
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
            this.sampleOrder = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.orderedCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sampleOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleOrder
            // 
            this.sampleOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sampleOrder.Location = new System.Drawing.Point(19, 72);
            this.sampleOrder.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sampleOrder.Name = "sampleOrder";
            this.sampleOrder.RowTemplate.Height = 23;
            this.sampleOrder.Size = new System.Drawing.Size(1773, 895);
            this.sampleOrder.TabIndex = 91;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Font = new System.Drawing.Font("굴림", 10F);
            this.button4.Location = new System.Drawing.Point(1405, 16);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 40);
            this.button4.TabIndex = 132;
            this.button4.Text = "Excel로 내보내기";
            this.button4.UseVisualStyleBackColor = true;
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
            // Frm_EstimateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1811, 1026);
            this.Controls.Add(this.orderedCode);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sampleOrder);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_EstimateList";
            this.Text = "견적서 조회";
            this.Resize += new System.EventHandler(this.Frm_EstimateList_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.sampleOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView sampleOrder;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderedCode;
    }
}