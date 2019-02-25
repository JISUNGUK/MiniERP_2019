using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using ChattingServer.FTPbase;
using System.Collections;
using ChattingServer;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.IO;
using ChattingServer.Server;

namespace ChattingServer
{
    public partial class ServerForm : Form
    {
       // public static Hashtable clientList = new Hashtable();
       // public static List<ChattingElement> chattingList = new List<ChattingElement>();
        public static Hashtable machineList = new Hashtable();//머신들의 이름과 IP를 저장
        //private string ipaddress = "192.168.0.6";
        public static int chattcount = 0;//사원들이 들어왔었는지 유무,,( 폼을 끝낼때 없으면 채팅방을 안 내보냄)

        public ServerForm()
        {
            InitializeComponent();
            ServerIPValue.Text = MachineInfo.GetJustIP();
        }

        private void StartServer_Click(object sender, EventArgs e)
        {
           
            Thread thread = new Thread(new ThreadStart(EstablishRemote));
            thread.Start();
            Thread threadMessage = new Thread(new ThreadStart(StartMessage));
            threadMessage.Start();
            Thread threadMachine = new Thread(new ThreadStart(StartMachine));
            threadMachine.Start();
            StartServer.Enabled = false;
            ServerStatusMessage.Text = "FTP서버 시작...";
        }
        /// <summary>
        /// It Establishs the remote object through the network
        /// </summary>
        private void EstablishRemote()
        {
            SoapServerFormatterSinkProvider soap = new SoapServerFormatterSinkProvider();
            BinaryServerFormatterSinkProvider binary = new BinaryServerFormatterSinkProvider();
            soap.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            binary.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;

            soap.Next = binary;

            Hashtable table = new Hashtable();
            table.Add("port", 8081);

            TcpChannel channel = new TcpChannel(table, null, soap);

            FTPServer.Logger = Logger;

            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.ApplicationName = "FTPServerAPP";
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(FTPServer), "ftpserver.svr", WellKnownObjectMode.Singleton);

            try
            {
                Logger.Text += Environment.NewLine + "***** TCP채널이 생성되었습니다... *****" + Environment.NewLine;
            }
            catch (InvalidOperationException)
            {

                
            }

        }

        /// <summary>
        /// It handles the ServerPortValue textbox's Keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerPortValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

     

        /// <summary>
        /// It handles the formclosing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까 ? ", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }



        }

        private void StartMessage()
        {

            try
            {
                ChatServer chatserver = new ChatServer();
                chatserver.StartMessage();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
         
        }

        private void StartMachine()
        {
            try
            {
                MachineServer machineServer = new MachineServer();
                machineServer.StartMessage();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }

        }

        private void Server_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하십니까 ? ", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;                                              
            }
            else
            {
            if(chattcount>0)
                exportChatting_Click(null,null);

            e.Cancel = false; // 폼 닫음  
                closeBackground(@"taskkill /im ChattingServer.exe /f");

                this.Dispose();
            }
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
        private void closeBackground(string command)
        {
            ProcessStartInfo cmd = new ProcessStartInfo();
            Process process = new Process();
            cmd.FileName = @"cmd";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.CreateNoWindow = true;
            cmd.UseShellExecute = false;
            cmd.RedirectStandardInput = true;
            cmd.RedirectStandardInput = true;
            cmd.RedirectStandardError = false;

            process.EnableRaisingEvents = false;
            process.StartInfo = cmd;
            process.Start();
            process.StandardInput.Write(command + Environment.NewLine);
            process.StandardInput.Close();
        }

        private void exportChatting_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
           DialogResult dr= savefile.ShowDialog();
            if (dr != DialogResult.OK)
                return;
            else
            {
              FileStream fs = new FileStream(savefile.FileName, FileMode.Create, FileAccess.Write);
                foreach (var item in ChatServer.chattingList)
                {
                    byte[] roomNameByte = Encoding.Default.GetBytes("{방명:"+item.RoomName + "\n");
                    fs.Write(roomNameByte, 0, roomNameByte.Length);
                    fs.Flush();
                    byte[] messageByte = Encoding.Default.GetBytes("[메시지 본문:\n" + item.MessageBody+"]}\n");
                    fs.Write(messageByte,0, messageByte.Length);
                    fs.Flush();
                }
                fs.Close();
            }
            savefile.Dispose();
        }
    }
}
