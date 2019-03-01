namespace MiniERP.View
{
    partial class Frm_MakeRoom
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
            this.roomName = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.TextBox();
            this.roomList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.makeRoom = new System.Windows.Forms.Button();
            this.memberList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Location = new System.Drawing.Point(20, 54);
            this.roomName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(80, 21);
            this.roomName.TabIndex = 0;
            this.roomName.Text = "방 이름";
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(102, 54);
            this.room.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(309, 32);
            this.room.TabIndex = 1;
            // 
            // roomList
            // 
            this.roomList.FormattingEnabled = true;
            this.roomList.ItemHeight = 21;
            this.roomList.Location = new System.Drawing.Point(24, 144);
            this.roomList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roomList.Name = "roomList";
            this.roomList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.roomList.Size = new System.Drawing.Size(199, 277);
            this.roomList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "방 목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "참가자 목록";
            // 
            // makeRoom
            // 
            this.makeRoom.Location = new System.Drawing.Point(182, 478);
            this.makeRoom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.makeRoom.Name = "makeRoom";
            this.makeRoom.Size = new System.Drawing.Size(118, 40);
            this.makeRoom.TabIndex = 6;
            this.makeRoom.Text = "방 만들기";
            this.makeRoom.UseVisualStyleBackColor = true;
            this.makeRoom.Click += new System.EventHandler(this.makeRoom_Click);
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(258, 144);
            this.memberList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(218, 274);
            this.memberList.TabIndex = 5;
            // 
            // Frm_MakeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 539);
            this.Controls.Add(this.makeRoom);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomList);
            this.Controls.Add(this.room);
            this.Controls.Add(this.roomName);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_MakeRoom";
            this.Text = "방을 만듭니다                              ";
            this.Load += new System.EventHandler(this.Frm_MakeRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomName;

        private System.Windows.Forms.TextBox room;

        private System.Windows.Forms.ListBox roomList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button makeRoom;
        private System.Windows.Forms.CheckedListBox memberList;
    }
}