namespace MiniERP.View
{
    partial class Frm_message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_message));
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.additionFile = new System.Windows.Forms.CheckBox();
            this.ServerFileListView = new System.Windows.Forms.ListView();
            this.Row = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComputerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.form_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_RoomName = new System.Windows.Forms.Label();
            this.particiRoom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.filel = new System.Windows.Forms.Label();
            this.sendMsg = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.ChatContent = new System.Windows.Forms.RichTextBox();
            this.rmRoom = new System.Windows.Forms.Button();
            this.mkRoom = new System.Windows.Forms.Button();
            this.roomList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.memberList = new System.Windows.Forms.ListBox();
            this.roomName = new System.Windows.Forms.Label();
            this.filelabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nicknamel = new System.Windows.Forms.Label();
            this.fileImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Refresh.Location = new System.Drawing.Point(316, 683);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(87, 23);
            this.btn_Refresh.TabIndex = 44;
            this.btn_Refresh.Text = "새로고침";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // additionFile
            // 
            this.additionFile.AutoSize = true;
            this.additionFile.Location = new System.Drawing.Point(316, 644);
            this.additionFile.Margin = new System.Windows.Forms.Padding(2);
            this.additionFile.Name = "additionFile";
            this.additionFile.Size = new System.Drawing.Size(96, 16);
            this.additionFile.TabIndex = 43;
            this.additionFile.Text = "파일첨부여부";
            this.additionFile.UseVisualStyleBackColor = true;
            // 
            // ServerFileListView
            // 
            this.ServerFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Row,
            this.ComputerName,
            this.Filename,
            this.form_Size});
            this.ServerFileListView.FullRowSelect = true;
            this.ServerFileListView.GridLines = true;
            this.ServerFileListView.Location = new System.Drawing.Point(44, 717);
            this.ServerFileListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ServerFileListView.MultiSelect = false;
            this.ServerFileListView.Name = "ServerFileListView";
            this.ServerFileListView.Size = new System.Drawing.Size(428, 160);
            this.ServerFileListView.TabIndex = 42;
            this.ServerFileListView.UseCompatibleStateImageBehavior = false;
            this.ServerFileListView.View = System.Windows.Forms.View.Details;
            this.ServerFileListView.DoubleClick += new System.EventHandler(this.ServerFileListView_DoubleClick);
            // 
            // Row
            // 
            this.Row.Text = "열";
            // 
            // ComputerName
            // 
            this.ComputerName.Text = "기기";
            this.ComputerName.Width = 209;
            // 
            // Filename
            // 
            this.Filename.Text = "파일명";
            this.Filename.Width = 248;
            // 
            // form_Size
            // 
            this.form_Size.Text = "용량 (KB)";
            this.form_Size.Width = 124;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 677);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "파일목록";
            // 
            // lbl_RoomName
            // 
            this.lbl_RoomName.AutoSize = true;
            this.lbl_RoomName.Font = new System.Drawing.Font("굴림", 12F);
            this.lbl_RoomName.Location = new System.Drawing.Point(112, 91);
            this.lbl_RoomName.Name = "lbl_RoomName";
            this.lbl_RoomName.Size = new System.Drawing.Size(130, 16);
            this.lbl_RoomName.TabIndex = 39;
            this.lbl_RoomName.Text = "방이름 여기 출력";
            // 
            // particiRoom
            // 
            this.particiRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.particiRoom.Location = new System.Drawing.Point(277, 68);
            this.particiRoom.Name = "particiRoom";
            this.particiRoom.Size = new System.Drawing.Size(75, 23);
            this.particiRoom.TabIndex = 38;
            this.particiRoom.Text = "방참가";
            this.particiRoom.UseVisualStyleBackColor = true;
            this.particiRoom.Click += new System.EventHandler(this.particiRoom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, -288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "사용자이름";
            // 
            // filel
            // 
            this.filel.AutoSize = true;
            this.filel.Location = new System.Drawing.Point(85, 624);
            this.filel.Name = "filel";
            this.filel.Size = new System.Drawing.Size(61, 12);
            this.filel.TabIndex = 34;
            this.filel.Text = "첨부 파일:";
            // 
            // sendMsg
            // 
            this.sendMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMsg.Location = new System.Drawing.Point(317, 598);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(77, 23);
            this.sendMsg.TabIndex = 33;
            this.sendMsg.Text = "전송";
            this.sendMsg.UseVisualStyleBackColor = true;
            this.sendMsg.Click += new System.EventHandler(this.sendMsg_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(44, 600);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(267, 21);
            this.message.TabIndex = 32;
            this.message.KeyUp += new System.Windows.Forms.KeyEventHandler(this.message_KeyUp_1);
            // 
            // ChatContent
            // 
            this.ChatContent.Location = new System.Drawing.Point(43, 206);
            this.ChatContent.Name = "ChatContent";
            this.ChatContent.Size = new System.Drawing.Size(361, 377);
            this.ChatContent.TabIndex = 31;
            this.ChatContent.Text = "";
            // 
            // rmRoom
            // 
            this.rmRoom.Enabled = false;
            this.rmRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmRoom.Location = new System.Drawing.Point(181, 68);
            this.rmRoom.Name = "rmRoom";
            this.rmRoom.Size = new System.Drawing.Size(90, 23);
            this.rmRoom.TabIndex = 30;
            this.rmRoom.Text = "방제거";
            this.rmRoom.UseVisualStyleBackColor = true;
            this.rmRoom.Visible = false;
            this.rmRoom.Click += new System.EventHandler(this.rmRoom_Click);
            // 
            // mkRoom
            // 
            this.mkRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mkRoom.Location = new System.Drawing.Point(108, 68);
            this.mkRoom.Name = "mkRoom";
            this.mkRoom.Size = new System.Drawing.Size(67, 23);
            this.mkRoom.TabIndex = 29;
            this.mkRoom.Text = "방생성";
            this.mkRoom.UseVisualStyleBackColor = true;
            this.mkRoom.Click += new System.EventHandler(this.mkRoom_Click);
            // 
            // roomList
            // 
            this.roomList.FormattingEnabled = true;
            this.roomList.Location = new System.Drawing.Point(110, 42);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(237, 20);
            this.roomList.TabIndex = 28;
            this.roomList.SelectedIndexChanged += new System.EventHandler(this.roomList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, -261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "방 목록";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, -179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "사용자목록";
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.ItemHeight = 12;
            this.memberList.Location = new System.Drawing.Point(110, 124);
            this.memberList.Name = "memberList";
            this.memberList.ScrollAlwaysVisible = true;
            this.memberList.Size = new System.Drawing.Size(127, 76);
            this.memberList.TabIndex = 25;
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Font = new System.Drawing.Font("굴림", 12F);
            this.roomName.Location = new System.Drawing.Point(41, 91);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(61, 16);
            this.roomName.TabIndex = 24;
            this.roomName.Text = "방 이름";
            // 
            // filelabel1
            // 
            this.filelabel1.AutoSize = true;
            this.filelabel1.Location = new System.Drawing.Point(152, 624);
            this.filelabel1.Name = "filelabel1";
            this.filelabel1.Size = new System.Drawing.Size(0, 12);
            this.filelabel1.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 54;
            this.label6.Text = "사용자이름";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 49;
            this.label7.Text = "방 목록";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 48;
            this.label8.Text = "사용자목록";
            // 
            // nicknamel
            // 
            this.nicknamel.AutoSize = true;
            this.nicknamel.Location = new System.Drawing.Point(108, 15);
            this.nicknamel.Name = "nicknamel";
            this.nicknamel.Size = new System.Drawing.Size(38, 12);
            this.nicknamel.TabIndex = 55;
            this.nicknamel.Text = "label5";
            // 
            // fileImage
            // 
            this.fileImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileImage.Location = new System.Drawing.Point(44, 621);
            this.fileImage.Name = "fileImage";
            this.fileImage.Size = new System.Drawing.Size(39, 39);
            this.fileImage.TabIndex = 40;
            this.fileImage.TabStop = false;
            // 
            // Frm_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(493, 604);
            this.Controls.Add(this.nicknamel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.filelabel1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.additionFile);
            this.Controls.Add(this.ServerFileListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileImage);
            this.Controls.Add(this.lbl_RoomName);
            this.Controls.Add(this.particiRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filel);
            this.Controls.Add(this.sendMsg);
            this.Controls.Add(this.message);
            this.Controls.Add(this.ChatContent);
            this.Controls.Add(this.rmRoom);
            this.Controls.Add(this.mkRoom);
            this.Controls.Add(this.roomList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.roomName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_message";
            this.Text = "메시지";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_message_FormClosing);
            this.Load += new System.EventHandler(this.Frm_message_Load);
            this.Resize += new System.EventHandler(this.Frm_message_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.fileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.CheckBox additionFile;
        private System.Windows.Forms.ListView ServerFileListView;
        private System.Windows.Forms.ColumnHeader Row;
        private System.Windows.Forms.ColumnHeader ComputerName;
        private System.Windows.Forms.ColumnHeader Filename;
        private System.Windows.Forms.ColumnHeader form_Size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox fileImage;
        private System.Windows.Forms.Label lbl_RoomName;
        private System.Windows.Forms.Button particiRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label filel;
        private System.Windows.Forms.Button sendMsg;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.RichTextBox ChatContent;
        private System.Windows.Forms.Button rmRoom;
        private System.Windows.Forms.Button mkRoom;
        private System.Windows.Forms.ComboBox roomList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox memberList;
        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.Label filelabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nicknamel;
    }
}