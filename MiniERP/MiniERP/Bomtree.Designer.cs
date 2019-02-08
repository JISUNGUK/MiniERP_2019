namespace MiniERP
{
    partial class Bomtree
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
            this.treeBom = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeBom
            // 
            this.treeBom.Location = new System.Drawing.Point(46, 24);
            this.treeBom.Name = "treeBom";
            this.treeBom.Size = new System.Drawing.Size(288, 401);
            this.treeBom.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(454, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 203);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // itemname
            // 
            this.itemname.AutoSize = true;
            this.itemname.Location = new System.Drawing.Point(454, 24);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(45, 12);
            this.itemname.TabIndex = 2;
            this.itemname.Text = "품목명:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 3;
            // 
            // Bomtree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeBom);
            this.Name = "Bomtree";
            this.Text = "Bomtree";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeBom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label itemname;
        private System.Windows.Forms.TextBox textBox1;
    }
}