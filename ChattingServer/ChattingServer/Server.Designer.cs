namespace ChattingServer
{
    partial class Server
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
            this.ServerPortValue = new System.Windows.Forms.TextBox();
            this.ServerPort = new System.Windows.Forms.Label();
            this.StartServer = new System.Windows.Forms.Button();
            this.ServerStatus = new System.Windows.Forms.StatusStrip();
            this.ServerStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ServerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerIPValue
            // 
            this.ServerIPValue.AutoSize = true;
            this.ServerIPValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIPValue.Location = new System.Drawing.Point(158, 22);
            this.ServerIPValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ServerIPValue.Name = "ServerIPValue";
            this.ServerIPValue.Size = new System.Drawing.Size(143, 31);
            this.ServerIPValue.TabIndex = 6;
            this.ServerIPValue.Text = "[Server IP]";
            // 
            // ServerIP
            // 
            this.ServerIP.AutoSize = true;
            this.ServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIP.Location = new System.Drawing.Point(15, 22);
            this.ServerIP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(135, 31);
            this.ServerIP.TabIndex = 5;
            this.ServerIP.Text = "Server IP:";
            // 
            // Logger
            // 
            this.Logger.BackColor = System.Drawing.Color.White;
            this.Logger.Location = new System.Drawing.Point(2, 105);
            this.Logger.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Logger.Multiline = true;
            this.Logger.Name = "Logger";
            this.Logger.ReadOnly = true;
            this.Logger.Size = new System.Drawing.Size(795, 241);
            this.Logger.TabIndex = 11;
            // 
            // ServerPortValue
            // 
            this.ServerPortValue.Location = new System.Drawing.Point(476, 26);
            this.ServerPortValue.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ServerPortValue.MaxLength = 5;
            this.ServerPortValue.Name = "ServerPortValue";
            this.ServerPortValue.Size = new System.Drawing.Size(132, 32);
            this.ServerPortValue.TabIndex = 14;
            this.ServerPortValue.Text = "8081";
            // 
            // ServerPort
            // 
            this.ServerPort.AutoSize = true;
            this.ServerPort.Location = new System.Drawing.Point(350, 34);
            this.ServerPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(113, 21);
            this.ServerPort.TabIndex = 13;
            this.ServerPort.Text = "Server Port:";
            // 
            // StartServer
            // 
            this.StartServer.Location = new System.Drawing.Point(641, 21);
            this.StartServer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(138, 37);
            this.StartServer.TabIndex = 12;
            this.StartServer.Text = "Start Server";
            this.StartServer.UseVisualStyleBackColor = true;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // ServerStatus
            // 
            this.ServerStatus.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.ServerStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerStatusMessage});
            this.ServerStatus.Location = new System.Drawing.Point(0, 415);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.ServerStatus.Size = new System.Drawing.Size(800, 35);
            this.ServerStatus.SizingGrip = false;
            this.ServerStatus.TabIndex = 15;
            // 
            // ServerStatusMessage
            // 
            this.ServerStatusMessage.Name = "ServerStatusMessage";
            this.ServerStatusMessage.Size = new System.Drawing.Size(82, 30);
            this.ServerStatusMessage.Text = "[Status]";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.ServerPortValue);
            this.Controls.Add(this.ServerPort);
            this.Controls.Add(this.StartServer);
            this.Controls.Add(this.Logger);
            this.Controls.Add(this.ServerIPValue);
            this.Controls.Add(this.ServerIP);
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
        private System.Windows.Forms.TextBox ServerPortValue;
        private System.Windows.Forms.Label ServerPort;
        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.StatusStrip ServerStatus;
        private System.Windows.Forms.ToolStripStatusLabel ServerStatusMessage;
    }
}

