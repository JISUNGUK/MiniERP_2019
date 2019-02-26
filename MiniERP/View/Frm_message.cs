using ChattingServer.FTPbase;
using MiniERP.Model.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View
{
    public partial class Frm_message : Form
    {

        public Frm_message()
        {
            InitializeComponent();
        }

        //메시지 구현 필요 변수 부분  
        public string[] bannWord = { "//", "[", "]", "접속종료합니다", "접속인원:", "만든 방명:", "$$$$", "방에 참가했습니다", "방정보:", "방에 메시지를 보냅니다", ":방의 주인은?", "방을 삭제합니다", "인원:" };
        TcpClient client = new TcpClient();

        private Hashtable clientList = new Hashtable();//방과 해당 방의 메시지 내용을 저장
        private NetworkStream network = default(NetworkStream);//기본값 할당(해당 객체의 기본값 참조형은 null)
        private string currentfileName;
        string readData = "";
        private string nickname;
        private string serverip = "192.168.0.6";
        Frm_MakeRoom makeRoom;//방속성 정하는 창
        private Form1 form;

        Hashtable roomtable;//방이름과 방의 메시지내용으로 구성
        private string ownedRoom = "";

        private MessageDAO messagedao;
        private string windowstate;

        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        /// <summary>
        /// 접속할 서버객체
        /// </summary>
        private IFTPServer Server = null;

        public string OwnedRoom { get => ownedRoom; set => ownedRoom = value; }
        public MessageDAO Messagedao { get => messagedao; set => messagedao = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public NetworkStream Network { get => network; set => network = value; }
        public string Windowstate { get => windowstate; set => windowstate = value; }
        public Form1 Form { get => form; set => form = value; }

        internal DialogResult logIn;          //  로그인 체커부


        //메시지 구현부분 by 종완

        /// <summary>
        /// 서버에서 받고 전송한 메시지를 받아옴
        /// </summary>
        private void getMsg()
        {
            //서버가 보내준 메시지를 받음!!!
            while (true)
            {
                if (client.Connected)
                {
                    try
                    {
                        Network = client.GetStream();
                        Byte[] byteFrom = new byte[client.SendBufferSize];
                        Network.Read(byteFrom, 0, client.SendBufferSize);
                        readData = Encoding.UTF8.GetString(byteFrom).Replace("\0", "");
                    }
                    catch (Exception)
                    {


                    };
                    if (readData.Contains("해당 방은 있습니다"))
                        MessageBox.Show("같은 이름의 방은 만들수 없습니다");

                    Msg();
                    DisplayMember();
                }


            }
        }
        /// <summary>
        /// 방목록과 방에 들어온 접속자들을 폼에 추가
        /// </summary>
        private void DisplayMember()
        {
            if (this.InvokeRequired)//현재 getMsg()를 실행하는 스레드가 ui를 담당하는(Main()에서만들어진 스레드라면 다른 스레드로 getMsge가 호출되도록 함(대리자 이용)
            {
                this.Invoke(new MethodInvoker(DisplayMember));//스레드간 메시지 교환시킴
            }
            else
            {
                Messagedao.DisplayContent(readData, memberList, roomList, roomtable);

            }
        }

        /// <summary>
        /// 서버에서 받은 메시지를 채팅창에 추가
        /// </summary>
        private void Msg()
        {
            if (this.InvokeRequired)//현재 getMsg()를 실행하는 스레드가 ui를 담당하는(Main()에서만들어진 스레드라면 다른 스레드로 getMsge가 호출되도록 함(대리자 이용)
            {
                this.Invoke(new MethodInvoker(Msg));//스레드간 메시지 교환시킴
            }
            else
            {
                Messagedao.GetMsg(readData, roomtable, roomList, ChatContent, windowstate);


            }
        }

        private void accessChatting()
        {
            try
            {
                client.SendTimeout = 1000;
                client.Connect(serverip, 3333);
                messagedao.Network = client.GetStream();
                
                //client.ReceiveTimeout = 1000;
               
               

                Messagedao.Client = client;
                roomtable = new Hashtable();//처음 서버에 접속했을때 방목록을 처음 생성
                roomtable.Add("전체", "");
                //Msg();
                if(client.Connected)
                { 
                Network = client.GetStream();
                Messagedao.SendMessage(nickname);                
                nicknamel.Text = nickname;
                Thread thread = new Thread(getMsg);
                thread.Start();
                Thread ftptread = new Thread(FTPConnection);
                ftptread.Start();
                }


            }
            catch (Exception ee)
            {

                MessageBox.Show("서버가 열려있지않습니다");
            }


        }



        private void message_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMsg_Click(sender, null);
                message.Text = "";
            }
        }

        private void sendMsg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(message.Text))
            {
               
                Messagedao.SendChatMessage(message.Text, roomList);
                string date = Environment.NewLine + "보낸 시간:" + DateTime.Now + Environment.NewLine;
                if (roomList.SelectedIndex != -1)
                {
                    roomtable[roomList.SelectedItem.ToString()] += date + "\n<<자신 메시지:" + message.Text + Environment.NewLine;

                }
                else
                {
                    roomtable["전체"] += date + "\n<<자신 메시지:" + message.Text + Environment.NewLine;
                }
                ChatContent.Text += "\n" + date + "\n<<자신 메시지:" + message.Text + Environment.NewLine;
                message.Text = "";          

            }

            if (additionFile.Checked)
            {


                List<UploadData> upload = new List<UploadData>(); //업로드할 파일들

                OpenFileDialog openfile1 = new OpenFileDialog();
                DialogResult dr = openfile1.ShowDialog();
                openfile1.Multiselect = true;
                openfile1.Filter = "All files (*.*)|*.*";
                openfile1.FilterIndex = 2;
                openfile1.RestoreDirectory = true;

                if (dr == DialogResult.OK)
                {
                    string filename = openfile1.FileName;
                    currentfileName = openfile1.FileName;
                    filelabel1.Text = openfile1.SafeFileName;

                    //파일 아이콘을 갖고오는 부분

                    SHFILEINFO shinfo = new SHFILEINFO();
                    Win32.SHGetFileInfo(filename, 0, ref shinfo, (uint)System.Runtime.InteropServices.Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);
                    System.Drawing.Icon myIcon = System.Drawing.Icon.FromHandle(shinfo.hIcon);
                    fileImage.Image = (Image)myIcon.ToBitmap();


                    try
                    {
                        int uploadcount = 0;
                        UploadData data = new UploadData();
                        System.IO.FileInfo fileinfo = null;
                        string folderName = "전체";
                        foreach (string file in openfile1.FileNames)
                        {
                            fileinfo = new System.IO.FileInfo(file);
                            if (fileinfo.Length > 200000000)
                            {
                                MessageBox.Show("파일명: '" + file + "'은 사이즈가 200mb 보다 큽니다 더 작은 파일을 선택해주세요.", "FTP파일전송", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                continue;
                            }

                            data.Filename = file.Split('\\')[file.Split('\\').Length - 1];
                            Byte[] arr = System.IO.File.ReadAllBytes(file);

                            data.File = arr;
                            upload.Add(data);
                            if (roomList.SelectedIndex != -1)
                                folderName = roomList.SelectedItem.ToString();
                            uploadcount++;
                        }
                        if (uploadcount > 0)
                        {
                            Server.Upload(MachineInfo.GetJustIP(), upload, folderName);

                            MessageBox.Show("성공적으로 파일을 업로드 했습니다");
                        }



                    }
                    catch (SocketException soed)
                    {
                        MessageBox.Show(soed.Message + "연결에서 문제가 생겼습니다");

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message + "파일을 올리는 도중에 오류가 생겼습니다");

                    }

                }

                RefreshList();

            }


        }

        private void Server_posted(string fileName)
        {
            MessageBox.Show("서버에 파일:" + fileName + "을 모두 전송완료 하였습니다");
        }

        private void particiRoom_Click(object sender, EventArgs e)
        {
            if (roomList.SelectedIndex != -1)
            {
                string message = roomList.SelectedItem.ToString() + "방에 참가했습니다";
                Messagedao.SendMessage(message);
            }
        }

        private void mkRoom_Click(object sender, EventArgs e)
        {
            makeRoom = new Frm_MakeRoom();
            makeRoom.Owner = this;
            makeRoom.RoomArr = new string[roomList.Items.Count];
            makeRoom.MemberArr = new string[memberList.Items.Count];
            DisplayMemberRoom();
            makeRoom.Show();

        }

        private void DisplayMemberRoom()
        {
            for (int i = 0; i < roomList.Items.Count; i++)
            {
                makeRoom.RoomArr[i] = roomList.Items[i].ToString();
            }

            for (int i = 0; i < memberList.Items.Count; i++)
            {
                makeRoom.MemberArr[i] = memberList.Items[i].ToString();
            }
        }

        private void roomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChatContent.Text = roomtable[roomList.SelectedItem].ToString();
            if (this.OwnedRoom.Contains(roomList.SelectedItem.ToString()))
            {
                rmRoom.Enabled = true;
                rmRoom.Visible = true;
            }
            else
            {
                rmRoom.Enabled = false;
                rmRoom.Visible = false;

            }
            lbl_RoomName.Text = roomList.SelectedItem.ToString();
            RefreshList();

        }

        private void rmRoom_Click(object sender, EventArgs e)
        {
            if (roomList.SelectedIndex != -1 && roomList.SelectedItem != "전체")
            {
                DialogResult result = MessageBox.Show("제거하시겠습니까?", "방제거창", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string message = roomList.SelectedItem.ToString() + "방을 삭제합니다";
                    Messagedao.SendMessage(message);
                    roomtable.Remove(roomList.SelectedItem);
                    rmRoom.Enabled = false;
                    rmRoom.Visible = false;
                }

            }
        }

        /// <summary>
        /// 파일이 서버에 올려졌을때 서버의 파일목록을 최신화
        /// </summary>
        private void RefreshList()
        {


            if (ServerFileListView.InvokeRequired)
            {
                MethodInvoker invoker = new MethodInvoker(RefreshList);
                ServerFileListView.Invoke(invoker);
            }
            else
            {
                try
                {
                    ServerFileListView.Items.Clear();
                    ServerFileListView.SuspendLayout();
                    List<ChattingServer.FTPbase.FileInfo> files = new List<ChattingServer.FTPbase.FileInfo>();
                    string folderName = "전체";
                    if (roomList.SelectedIndex != -1)
                        folderName = roomList.SelectedItem.ToString();
                    Server.GetFiles(out files, folderName);

                    foreach (ChattingServer.FTPbase.FileInfo file in files)
                    {

                        ListViewItem item = new ListViewItem((ServerFileListView.Items.Count + 1).ToString());
                        item.SubItems.Add("FTP Server");
                        item.SubItems.Add(file.Filename.Split('\\')[2]);
                        item.SubItems.Add(file.Size.ToString());
                        ServerFileListView.Items.Add(item);
                    }
                    ServerFileListView.ResumeLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FTP File Sharing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FTPConnection()
        {
            if (!GetConnection())//만약 ftpconnection이 되어있지않으면 ftp연결은 되지 않는다;
                return;
            else
                MessageBox.Show("FTP서버와 연결이 잘 되었습니다");

        }

        /// <summary>
        /// FTP서버에 접속!!
        /// </summary>
        private bool GetConnection()
        {
            bool connected = true;

            SoapServerFormatterSinkProvider soap = new SoapServerFormatterSinkProvider();
            BinaryServerFormatterSinkProvider binary = new BinaryServerFormatterSinkProvider();
            soap.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            binary.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            soap.Next = binary;

            Hashtable table = new Hashtable();
            table.Add("port", "0");

            TcpChannel channel = new TcpChannel(table, null, soap);
            ChannelServices.RegisterChannel(channel, false);

            try
            {
                Server = (IFTPServer)Activator.GetObject(typeof(IFTPServer), string.Format("tcp://{0}:{1}/FTPServerAPP/ftpserver.svr", serverip, "8081"));
            }
            catch (Exception ex)
            {
                connected = false;
                EventLogger.Logger(ex, "Client - GetConnection");
            }

            if (Server == null)
            {
                connected = false;
                ChannelServices.UnregisterChannel(channel);
                MessageBox.Show("Cannot Connect to the Server", "FTP File Sharing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return connected;
            }

            try
            {
                MiniERP.Model.DAO.PostedData handler = new MiniERP.Model.DAO.PostedData();
                handler.RefreshList += new EventHandler(handler_RefreshList);

                Server.PostedData += new PostedDataHandler(handler.Server_PostData);
                Server.Update += new UpdateHandler(handler.Server_Update);

                Server.Connect(MachineInfo.GetJustIP());
            }
            catch (Exception ex)
            {
                connected = false;
                ChannelServices.UnregisterChannel(channel);
                MessageBox.Show(ex.Message, "FTP File Sharing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connected;

        }
        void handler_RefreshList(object sender, EventArgs e)
        {
            MessageBox.Show("Please Refresh your list.", "FTP File Sharing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }














        private void Frm_message_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nicknamel.Text != "label5")
                messagedao.SendMessage("접속종료합니다");
            if (Server != null)
            {
                Server.Disconnect(serverip);
            }

        }

        private void message_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMsg_Click(sender, null);
                message.Text = "";
            }
        }

        private void Frm_message_Load(object sender, EventArgs e)
        {
            messagedao = new MessageDAO();
            messagedao.Form = this.form;
            accessChatting();
        }

        private void access_Click(object sender, EventArgs e)
        {

        }

        private void ServerFileListView_DoubleClick(object sender, EventArgs e)
        {
            if (ServerFileListView.SelectedItems.Count < 1)
                return;

            byte[] file;
            string folderName = "전체";
            if (roomList.SelectedIndex != -1)
                folderName = roomList.SelectedItem.ToString();
            Server.Download(MachineInfo.GetJustIP(), ServerFileListView.SelectedItems[0].SubItems[2].Text, out file, folderName);

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "It saves the downloaded file.";
            save.SupportMultiDottedExtensions = false;
            save.Filter = "All|*.*";
            save.FileName = ServerFileListView.SelectedItems[0].SubItems[2].Text;
            if (save.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                System.IO.File.WriteAllBytes(save.FileName, file);
                MessageBox.Show(ServerFileListView.SelectedItems[0].SubItems[2].Text + "이 다운로드 되었습니다.", "FTP File 공유중", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            save.Dispose();

        }

        private void reacess_Click(object sender, EventArgs e)
        {
        if(messagedao.Network==null)
            { 
            messagedao = new MessageDAO();             
            accessChatting();
            }
        }
    }
}
