namespace ChattingServer
{
    partial class ServerForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServerIPValue = new System.Windows.Forms.Label();
            this.ServerIP = new System.Windows.Forms.Label();
            this.Logger = new System.Windows.Forms.TextBox();
            this.StartServer = new System.Windows.Forms.Button();
            this.ServerStatus = new System.Windows.Forms.StatusStrip();
            this.ServerStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.exportChatting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ServerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerIPValue
            // 
            this.ServerIPValue.AutoSize = true;
            this.ServerIPValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIPValue.Location = new System.Drawing.Point(101, 13);
            this.ServerIPValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerIPValue.Name = "ServerIPValue";
            this.ServerIPValue.Size = new System.Drawing.Size(76, 18);
            this.ServerIPValue.TabIndex = 6;
            this.ServerIPValue.Text = "[Server IP]";
            // 
            // ServerIP
            // 
            this.ServerIP.AutoSize = true;
            this.ServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIP.Location = new System.Drawing.Point(10, 13);
            this.ServerIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(72, 18);
            this.ServerIP.TabIndex = 5;
            this.ServerIP.Text = "Server IP:";
            // 
            // Logger
            // 
            this.Logger.BackColor = System.Drawing.Color.White;
            this.Logger.Location = new System.Drawing.Point(1, 60);
            this.Logger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Logger.Multiline = true;
            this.Logger.Name = "Logger";
            this.Logger.ReadOnly = true;
            this.Logger.Size = new System.Drawing.Size(507, 139);
            this.Logger.TabIndex = 11;
            // 
            // StartServer
            // 
            this.StartServer.Location = new System.Drawing.Point(408, 12);
            this.StartServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(88, 21);
            this.StartServer.TabIndex = 12;
            this.StartServer.Text = "서버시작";
            this.StartServer.UseVisualStyleBackColor = true;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // ServerStatus
            // 
            this.ServerStatus.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.ServerStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerStatusMessage});
            this.ServerStatus.Location = new System.Drawing.Point(0, 257);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.ServerStatus.Size = new System.Drawing.Size(527, 22);
            this.ServerStatus.SizingGrip = false;
            this.ServerStatus.TabIndex = 15;
            // 
            // ServerStatusMessage
            // 
            this.ServerStatusMessage.Name = "ServerStatusMessage";
            this.ServerStatusMessage.Size = new System.Drawing.Size(48, 17);
            this.ServerStatusMessage.Text = "[Status]";
            // 
            // exportChatting
            // 
            this.exportChatting.Location = new System.Drawing.Point(1, 225);
            this.exportChatting.Name = "exportChatting";
            this.exportChatting.Size = new System.Drawing.Size(96, 23);
            this.exportChatting.TabIndex = 16;
            this.exportChatting.Text = "채팅내보내기";
            this.exportChatting.UseVisualStyleBackColor = true;
            this.exportChatting.Click += new System.EventHandler(this.exportChatting_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "기계명령";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "작업내보내기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "모니터링";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 279);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exportChatting);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.StartServer);
            this.Controls.Add(this.Logger);
            this.Controls.Add(this.ServerIPValue);
            this.Controls.Add(this.ServerIP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Server";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing_1);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ServerStatus.ResumeLayout(false);
            this.ServerStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerIPValue;
        private System.Windows.Forms.Label ServerIP;
        private System.Windows.Forms.TextBox Logger;
        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.StatusStrip ServerStatus;
        private System.Windows.Forms.ToolStripStatusLabel ServerStatusMessage;
        private System.Windows.Forms.Button exportChatting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

