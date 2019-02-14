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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashBoard));
            this.split = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_hideL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_hideR = new System.Windows.Forms.Button();
            this.toDoList4 = new MiniERP.View.ToDoList();
            this.toDoList3 = new MiniERP.View.ToDoList();
            this.toDoList2 = new MiniERP.View.ToDoList();
            this.toDoList1 = new MiniERP.View.ToDoList();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.btn_hideR);
            this.split.Size = new System.Drawing.Size(823, 618);
            this.split.SplitterDistance = 256;
            this.split.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 616);
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
            this.splitContainer1.Size = new System.Drawing.Size(254, 616);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_hideL);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 25);
            this.panel2.TabIndex = 0;
            // 
            // btn_hideL
            // 
            this.btn_hideL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_hideL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hideL.BackgroundImage")));
            this.btn_hideL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hideL.Location = new System.Drawing.Point(229, 1);
            this.btn_hideL.Name = "btn_hideL";
            this.btn_hideL.Size = new System.Drawing.Size(20, 20);
            this.btn_hideL.TabIndex = 2;
            this.btn_hideL.UseVisualStyleBackColor = true;
            this.btn_hideL.Click += new System.EventHandler(this.Hide_btn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "2019 / 2 / 12";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 587);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.toDoList4);
            this.panel4.Controls.Add(this.toDoList3);
            this.panel4.Controls.Add(this.toDoList2);
            this.panel4.Controls.Add(this.toDoList1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 587);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(-2, 546);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(254, 35);
            this.panel5.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(222, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(84, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "2 / 10";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(3, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_hideR
            // 
            this.btn_hideR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hideR.BackgroundImage")));
            this.btn_hideR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hideR.Location = new System.Drawing.Point(3, 2);
            this.btn_hideR.Name = "btn_hideR";
            this.btn_hideR.Size = new System.Drawing.Size(20, 20);
            this.btn_hideR.TabIndex = 3;
            this.btn_hideR.UseVisualStyleBackColor = true;
            this.btn_hideR.Visible = false;
            this.btn_hideR.Click += new System.EventHandler(this.Hide_btn);
            // 
            // toDoList4
            // 
            this.toDoList4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toDoList4.BackColor = System.Drawing.Color.White;
            this.toDoList4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toDoList4.Location = new System.Drawing.Point(2, 163);
            this.toDoList4.Name = "toDoList4";
            this.toDoList4.Size = new System.Drawing.Size(190, 38);
            this.toDoList4.TabIndex = 3;
            // 
            // toDoList3
            // 
            this.toDoList3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toDoList3.BackColor = System.Drawing.Color.White;
            this.toDoList3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toDoList3.Location = new System.Drawing.Point(2, 110);
            this.toDoList3.Name = "toDoList3";
            this.toDoList3.Size = new System.Drawing.Size(190, 38);
            this.toDoList3.TabIndex = 2;
            // 
            // toDoList2
            // 
            this.toDoList2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toDoList2.BackColor = System.Drawing.Color.White;
            this.toDoList2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toDoList2.Location = new System.Drawing.Point(3, 56);
            this.toDoList2.Name = "toDoList2";
            this.toDoList2.Size = new System.Drawing.Size(190, 38);
            this.toDoList2.TabIndex = 1;
            // 
            // toDoList1
            // 
            this.toDoList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toDoList1.BackColor = System.Drawing.Color.White;
            this.toDoList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toDoList1.Location = new System.Drawing.Point(3, 2);
            this.toDoList1.Name = "toDoList1";
            this.toDoList1.Size = new System.Drawing.Size(190, 38);
            this.toDoList1.TabIndex = 0;
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 618);
            this.Controls.Add(this.split);
            this.Name = "FrmDashBoard";
            this.Text = "FrmDashBoard";
            this.Load += new System.EventHandler(this.FrmDashBoard_Load);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
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
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_hideL;
        private System.Windows.Forms.Panel panel4;
        private ToDoList toDoList1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private ToDoList toDoList4;
        private ToDoList toDoList3;
        private ToDoList toDoList2;
        private System.Windows.Forms.Button btn_hideR;
    }
}