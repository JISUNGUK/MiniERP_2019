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
            this.button4 = new System.Windows.Forms.Button();
            this.pnl_serchbox = new System.Windows.Forms.Panel();
            this.orderBtn = new System.Windows.Forms.Button();
            this.ordercode = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sampleOrder = new System.Windows.Forms.DataGridView();
            this.pnl_serchbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Font = new System.Drawing.Font("굴림", 10F);
            this.button4.Location = new System.Drawing.Point(654, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 103;
            this.button4.Text = "Excel로 내보내기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnl_serchbox
            // 
            this.pnl_serchbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_serchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_serchbox.Controls.Add(this.button4);
            this.pnl_serchbox.Controls.Add(this.orderBtn);
            this.pnl_serchbox.Controls.Add(this.ordercode);
            this.pnl_serchbox.Controls.Add(this.btn_search);
            this.pnl_serchbox.Controls.Add(this.label5);
            this.pnl_serchbox.Location = new System.Drawing.Point(12, 2);
            this.pnl_serchbox.Name = "pnl_serchbox";
            this.pnl_serchbox.Size = new System.Drawing.Size(817, 36);
            this.pnl_serchbox.TabIndex = 100;
            // 
            // orderBtn
            // 
            this.orderBtn.BackgroundImage = global::MiniERP.Properties.Resources.SerchIcon;
            this.orderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.orderBtn.Font = new System.Drawing.Font("굴림", 10F);
            this.orderBtn.Location = new System.Drawing.Point(320, 9);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(25, 21);
            this.orderBtn.TabIndex = 129;
            this.orderBtn.UseVisualStyleBackColor = true;
            // 
            // ordercode
            // 
            this.ordercode.Location = new System.Drawing.Point(105, 9);
            this.ordercode.Name = "ordercode";
            this.ordercode.Size = new System.Drawing.Size(209, 21);
            this.ordercode.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(391, 9);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "주문번호";
            // 
            // sampleOrder
            // 
            this.sampleOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sampleOrder.Location = new System.Drawing.Point(12, 41);
            this.sampleOrder.Name = "sampleOrder";
            this.sampleOrder.RowTemplate.Height = 23;
            this.sampleOrder.Size = new System.Drawing.Size(817, 266);
            this.sampleOrder.TabIndex = 91;
            // 
            // Frm_EstimateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(841, 341);
            this.Controls.Add(this.pnl_serchbox);
            this.Controls.Add(this.sampleOrder);
            this.Name = "Frm_EstimateList";
            this.Text = "견적서 조회";
            this.Resize += new System.EventHandler(this.Frm_EstimateList_Resize);
            this.pnl_serchbox.ResumeLayout(false);
            this.pnl_serchbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnl_serchbox;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.TextBox ordercode;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView sampleOrder;
    }
}