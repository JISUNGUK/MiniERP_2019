namespace MiniERP.View
{
    partial class Machine_Info_Change
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Ip = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.radio_Name = new System.Windows.Forms.RadioButton();
            this.radio_Ip = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "머신 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "접속 Ip";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(91, 10);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 21);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Ip
            // 
            this.txt_Ip.Location = new System.Drawing.Point(91, 52);
            this.txt_Ip.Name = "txt_Ip";
            this.txt_Ip.Size = new System.Drawing.Size(100, 21);
            this.txt_Ip.TabIndex = 3;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(273, 50);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(77, 23);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "수정";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // radio_Name
            // 
            this.radio_Name.AutoSize = true;
            this.radio_Name.Checked = true;
            this.radio_Name.Location = new System.Drawing.Point(198, 13);
            this.radio_Name.Name = "radio_Name";
            this.radio_Name.Size = new System.Drawing.Size(14, 13);
            this.radio_Name.TabIndex = 5;
            this.radio_Name.TabStop = true;
            this.radio_Name.UseVisualStyleBackColor = true;
            this.radio_Name.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio_Ip
            // 
            this.radio_Ip.AutoSize = true;
            this.radio_Ip.Location = new System.Drawing.Point(198, 55);
            this.radio_Ip.Name = "radio_Ip";
            this.radio_Ip.Size = new System.Drawing.Size(14, 13);
            this.radio_Ip.TabIndex = 6;
            this.radio_Ip.TabStop = true;
            this.radio_Ip.UseVisualStyleBackColor = true;
            this.radio_Ip.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Machine_Info_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 92);
            this.Controls.Add(this.radio_Ip);
            this.Controls.Add(this.radio_Name);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_Ip);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Machine_Info_Change";
            this.Text = "Machine_Info_Change";
            this.Load += new System.EventHandler(this.Machine_Info_Change_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Ip;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.RadioButton radio_Name;
        private System.Windows.Forms.RadioButton radio_Ip;
    }
}