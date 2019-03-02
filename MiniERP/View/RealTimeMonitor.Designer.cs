namespace MiniERP.View
{
    partial class RealTimeMonitor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.pc5 = new System.Windows.Forms.PictureBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.pc4 = new System.Windows.Forms.PictureBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.check_pc1 = new System.Windows.Forms.CheckBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reBoot = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_inputCountRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Log);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1168, 211);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 20;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(665, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(491, 102);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txt_Log
            // 
            this.txt_Log.Enabled = false;
            this.txt_Log.Location = new System.Drawing.Point(665, 12);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(491, 21);
            this.txt_Log.TabIndex = 0;
            this.txt_Log.TextChanged += new System.EventHandler(this.txt_Log_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.pc5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.pc4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.pc3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.pc2);
            this.panel1.Controls.Add(this.check_pc1);
            this.panel1.Controls.Add(this.pc1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 130);
            this.panel1.TabIndex = 31;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(532, 106);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(56, 16);
            this.checkBox5.TabIndex = 39;
            this.checkBox5.Text = "[pc5]";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.check_pc1_CheckedChanged);
            // 
            // pc5
            // 
            this.pc5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pc5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pc5.Enabled = false;
            this.pc5.Image = global::MiniERP.Properties.Resources.icon_client;
            this.pc5.Location = new System.Drawing.Point(532, 10);
            this.pc5.Name = "pc5";
            this.pc5.Size = new System.Drawing.Size(94, 89);
            this.pc5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc5.TabIndex = 38;
            this.pc5.TabStop = false;
            this.pc5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_pc1_MouseClick);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(406, 106);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(56, 16);
            this.checkBox4.TabIndex = 37;
            this.checkBox4.Text = "[pc4]";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.check_pc1_CheckedChanged);
            // 
            // pc4
            // 
            this.pc4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pc4.Enabled = false;
            this.pc4.Image = global::MiniERP.Properties.Resources.icon_client;
            this.pc4.Location = new System.Drawing.Point(406, 10);
            this.pc4.Name = "pc4";
            this.pc4.Size = new System.Drawing.Size(94, 89);
            this.pc4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc4.TabIndex = 36;
            this.pc4.TabStop = false;
            this.pc4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_pc1_MouseClick);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(288, 105);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 16);
            this.checkBox3.TabIndex = 35;
            this.checkBox3.Text = "[pc3]";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.check_pc1_CheckedChanged);
            // 
            // pc3
            // 
            this.pc3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pc3.Enabled = false;
            this.pc3.Image = global::MiniERP.Properties.Resources.icon_client;
            this.pc3.Location = new System.Drawing.Point(288, 9);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(94, 89);
            this.pc3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc3.TabIndex = 34;
            this.pc3.TabStop = false;
            this.pc3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_pc1_MouseClick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(162, 105);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(56, 16);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "[pc2]";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.check_pc1_CheckedChanged);
            // 
            // pc2
            // 
            this.pc2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pc2.Enabled = false;
            this.pc2.Image = global::MiniERP.Properties.Resources.icon_client;
            this.pc2.Location = new System.Drawing.Point(162, 10);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(94, 89);
            this.pc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc2.TabIndex = 32;
            this.pc2.TabStop = false;
            this.pc2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_pc1_MouseClick);
            // 
            // check_pc1
            // 
            this.check_pc1.AutoSize = true;
            this.check_pc1.Enabled = false;
            this.check_pc1.Location = new System.Drawing.Point(34, 105);
            this.check_pc1.Name = "check_pc1";
            this.check_pc1.Size = new System.Drawing.Size(56, 16);
            this.check_pc1.TabIndex = 31;
            this.check_pc1.Text = "[pc1]";
            this.check_pc1.UseVisualStyleBackColor = true;
            this.check_pc1.CheckedChanged += new System.EventHandler(this.check_pc1_CheckedChanged);
            // 
            // pc1
            // 
            this.pc1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pc1.Enabled = false;
            this.pc1.Image = global::MiniERP.Properties.Resources.icon_client;
            this.pc1.Location = new System.Drawing.Point(34, 9);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(94, 89);
            this.pc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc1.TabIndex = 30;
            this.pc1.TabStop = false;
            this.pc1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_pc1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reBoot);
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.btn_inputCountRequest);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 44);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // btn_reBoot
            // 
            this.btn_reBoot.Location = new System.Drawing.Point(274, 15);
            this.btn_reBoot.Name = "btn_reBoot";
            this.btn_reBoot.Size = new System.Drawing.Size(113, 23);
            this.btn_reBoot.TabIndex = 2;
            this.btn_reBoot.Text = "재부팅";
            this.btn_reBoot.UseVisualStyleBackColor = true;
            this.btn_reBoot.Click += new System.EventHandler(this.btn_inputCountRequest_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(146, 15);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(113, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "종료";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_inputCountRequest_Click);
            // 
            // btn_inputCountRequest
            // 
            this.btn_inputCountRequest.Location = new System.Drawing.Point(6, 15);
            this.btn_inputCountRequest.Name = "btn_inputCountRequest";
            this.btn_inputCountRequest.Size = new System.Drawing.Size(113, 23);
            this.btn_inputCountRequest.TabIndex = 0;
            this.btn_inputCountRequest.Text = "투입 자재 개수";
            this.btn_inputCountRequest.UseVisualStyleBackColor = true;
            this.btn_inputCountRequest.Click += new System.EventHandler(this.btn_inputCountRequest_Click);
            // 
            // RealTimeMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 211);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RealTimeMonitor";
            this.Text = "RealTimeMonitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RealTimeMonitor_FormClosing);
            this.Load += new System.EventHandler(this.RealTimeMonitor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reBoot;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_inputCountRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.PictureBox pc5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.PictureBox pc4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.CheckBox check_pc1;
        private System.Windows.Forms.PictureBox pc1;
    }
}