﻿namespace ChattingServer
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
            this.ServerIP.Size = new System.Drawing.Size(55, 18);
            this.ServerIP.TabIndex = 5;
            this.ServerIP.Text = "서버 IP:";
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
            this.StartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartServer.Location = new System.Drawing.Point(374, 13);
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
            this.ServerStatus.Location = new System.Drawing.Point(0, 212);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.ServerStatus.Size = new System.Drawing.Size(587, 22);
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
            this.exportChatting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportChatting.Location = new System.Drawing.Point(477, 13);
            this.exportChatting.Name = "exportChatting";
            this.exportChatting.Size = new System.Drawing.Size(96, 23);
            this.exportChatting.TabIndex = 16;
            this.exportChatting.Text = "채팅내보내기";
            this.exportChatting.UseVisualStyleBackColor = true;
            this.exportChatting.Click += new System.EventHandler(this.exportChatting_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 234);
            this.Controls.Add(this.exportChatting);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.StartServer);
            this.Controls.Add(this.Logger);
            this.Controls.Add(this.ServerIPValue);
            this.Controls.Add(this.ServerIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServerForm";
            this.Text = "ERP서버";
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
    }
}

