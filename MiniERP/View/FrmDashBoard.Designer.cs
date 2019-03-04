namespace MiniERP.View
{
    partial class FrmDashBoard
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
            this.components = new System.ComponentModel.Container();
            this.split = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_ToDay = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.panel_TradeList = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // split
            // 
            this.split.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 0);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.panel1);
            this.split.Size = new System.Drawing.Size(1266, 618);
            this.split.SplitterDistance = 375;
            this.split.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 616);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(373, 616);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Controls.Add(this.lbl_ToDay);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 25);
            this.panel2.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Refresh.Location = new System.Drawing.Point(259, 0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "새로고침";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_ToDay
            // 
            this.lbl_ToDay.AutoSize = true;
            this.lbl_ToDay.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbl_ToDay.Location = new System.Drawing.Point(10, 3);
            this.lbl_ToDay.Name = "lbl_ToDay";
            this.lbl_ToDay.Size = new System.Drawing.Size(109, 17);
            this.lbl_ToDay.TabIndex = 0;
            this.lbl_ToDay.Text = "2019 / 2 / 12";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel_TradeList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 587);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lbl_Time);
            this.panel5.Location = new System.Drawing.Point(0, 553);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(384, 35);
            this.panel5.TabIndex = 4;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(22, 12);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(69, 12);
            this.lbl_Time.TabIndex = 0;
            this.lbl_Time.Text = "현재 시간 : ";
            // 
            // panel_TradeList
            // 
            this.panel_TradeList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_TradeList.Location = new System.Drawing.Point(0, 0);
            this.panel_TradeList.Name = "panel_TradeList";
            this.panel_TradeList.Size = new System.Drawing.Size(370, 564);
            this.panel_TradeList.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 618);
            this.Controls.Add(this.split);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmDashBoard";
            this.Text = "FrmDashBoard";
            this.Load += new System.EventHandler(this.FrmDashBoard_Load);
            this.split.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ToDay;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_TradeList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Refresh;
    }
}