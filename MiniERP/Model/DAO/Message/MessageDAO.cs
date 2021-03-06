using MiniERP.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace MiniERP.Model.DAO
{
    public class MessageDAO
    {
        private NetworkStream network;
        private TcpClient client;


        public string[] bannWord = { "//", "[", "]", "접속종료합니다", "접속인원:", "만든 방명:", "$$$$", "방에 참가했습니다", "방정보:", "방에 메시지를 보냅니다", ":방의 주인은?", "방을 삭제합니다", "인원:" };

        public NetworkStream Network { get => network; set => network = value; }
        public TcpClient Client { get => client; set => client = value; }
        public Form1 Form { get => form; set => form = value; }

        private ComboBox roomList;
        private PopupNotifier popup;
        private Form1 form;
        public MessageDAO()
        {

        }

        /// <summary>
        /// 서버로부터 받은 메시지 따라 폼의 상태를 변화시킴
        /// </summary>
        /// <param name="readData"></param>
        /// <param name="memberList"></param>
        /// <param name="roomList"></param>
        /// <param name="roomtable"></param>
        public void DisplayContent(string readData, ListBox memberList, ComboBox roomList, Hashtable roomtable)
        {
            if (readData.Contains("접속 인원:"))
            {
                memberList.Items.Clear();
                var seperators = new char[1];
                seperators[0] = ',';
                int lastIndex = readData.IndexOf("::");
                string accessmember = readData.Remove(lastIndex);
                int accessMemberIndex = readData.IndexOf("접속 인원:") + 6;
                accessmember = accessmember.Substring(accessMemberIndex);
                string[] members = accessmember.Split(seperators[0]);
                string memberNamelist = "";
                foreach (var v in members)
                {
                    if (!memberNamelist.Contains(v))
                        memberList.Items.Add(v);
                    memberNamelist += v;
                }
            }

            if (readData.Contains("방 목록:"))
            {
                roomList.Items.Clear();
                var seperators = new char[1];
                seperators[0] = ',';
                int lastIndex = readData.IndexOf(";;");
                int accessRoomIndex = readData.IndexOf("방 목록:") + 5;
                string accessRoom = readData.Remove(lastIndex);
                string roomlist = accessRoom.Substring(accessRoomIndex);
                if (roomlist != "")
                {
                    string[] rooms = roomlist.Split(seperators[0]);
                    string roomNamelist = "";
                    foreach (var v in rooms)
                    {
                        if (!roomNamelist.Contains(v))
                        {

                            roomList.Items.Add(v);
                        }
                        if (!roomtable.Contains(v))
                        {
                            roomtable.Add(v, "");//로컬프로그램에 저장될 채팅방 이름과 메시지내용들
                        }
                        roomNamelist += v;
                    }
                }
            }
        }

        /// <summary>
        /// 서버에 채팅메시지를 전송시킴 combo박스의 선택이름에 따라 다른 서버의 채팅 방에 메시지를 전달
        /// </summary>
        /// <param name="sendMsg"></param>
        /// <param name="combo"></param>
        public void SendChatMessage(string sendMsg, ComboBox combo)
        {
            try
            {
                if (sendMsg != "")
                {
                    if (combo.SelectedIndex != -1)
                    {
                        if (checkmessage(sendMsg))
                        {
                            if (combo.SelectedItem.ToString() == "전체")
                                SendMessage(sendMsg + "$$$$");
                            else
                                SendMessage(combo.SelectedItem.ToString() + "방에 메시지를 보냅니다" + sendMsg + "//");

                        }

                    }
                    if (combo.SelectedIndex == -1)
                    {
                        SendMessage(sendMsg + "$$$$");
                    }
                    sendMsg = "";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 서버로 부터 받은 메시지 내용을 받음
        /// </summary>
        /// <param name="readData"></param>
        /// <param name="roomtable"></param>
        /// <param name="roomList"></param>
        /// <param name="ChatContent"></param>
        /// <param name="windowstate"></param>
        public void GetMsg(string readData, Hashtable roomtable, ComboBox roomList, RichTextBox ChatContent, string windowstate)
        {
            this.roomList = roomList;
            if (!readData.Contains("서버 메시지:"))
            {
                string date = Environment.NewLine + "보낸 시간:" + DateTime.Now + "\n";
                if (readData.Contains(">>>>"))
                {
                    int indexOfseprate = readData.IndexOf(">>>>");
                    string roomname = readData.Remove(indexOfseprate);
                    string message = readData.Substring(indexOfseprate + 4);
                    roomname = roomname.Substring(3);//방명:으로부터 인덱스가 3인것부터가 방명이므로
                    roomtable[roomname] += "\n" + date + Environment.NewLine + ">>" + message + "\n";
                    if (windowstate != "최소화")
                    {
                        if (roomList.SelectedIndex == -1)
                            View.Form1.notify = true;
                        else if (roomname != roomList.SelectedItem.ToString())
                            View.Form1.notify = true;
                        else
                            View.Form1.notify = false;
                    }
                    //알림창을 띄워줌 해당 창의 알림이 울릴지 여부를 확인
                    if (MiniERP.View.Form1.notify)
                    {
                        popup = new PopupNotifier();
                        popup.Image = Properties.Resources.message;
                        popup.ImageSize = new Size(50, 50);
                        popup.Delay = 1000;
                        popup.TitleText = "방:" + roomname + "메시지";
                        popup.ContentText = message;
                        popup.Click += Popup_Click;
                        popup.Popup();

                    }
                    if (roomList.SelectedIndex != -1)
                    {
                        if (roomList.SelectedItem.ToString() == roomname)
                        {

                            ChatContent.AppendText(ChatContent.Text + "\n" + date + Environment.NewLine + ">>" + message + "\n");
                            ChatContent.SelectionStart = ChatContent.Text.Length;//맨 마지막 선택...
                            ChatContent.ScrollToCaret();


                        }
                    }

                }
                else
                {
                   
                    if (roomList.SelectedItem == null || roomList.SelectedItem.ToString() == "전체")
                    {
                        ChatContent.Text = ChatContent.Text + "\n" + date + Environment.NewLine + ">>" + readData;
                        ChatContent.SelectionStart = ChatContent.TextLength;
                        ChatContent.ScrollToCaret();


                    }
                    roomtable["전체"] += "\n" + date + Environment.NewLine + "\n>>" + readData + "\n";

                    if (windowstate != "최소화")
                    {
                        if (roomList.SelectedIndex == -1)
                            View.Form1.notify = true;
                        else if ("전체" != roomList.SelectedItem.ToString() && roomList.SelectedIndex > 0)
                            View.Form1.notify = true;
                        else
                            View.Form1.notify = false;
                    }
                    if (MiniERP.View.Form1.notify)
                    {
                        popup = new PopupNotifier();
                        // popup.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\resources" + "\\message.png");
                        popup.Image = Properties.Resources.message;
                        popup.ImageSize = new Size(50, 50);
                        popup.Delay = 1000;
                        popup.TitleText = "방:" + "전체" + "메시지";
                        popup.ContentText = readData;
                        popup.Click += Popup_Click;
                        popup.Popup();
                    }
                    ChatContent.SelectionStart = ChatContent.Text.Length;//맨 마지막 선택...
                    ChatContent.ScrollToCaret();
                }


            }

        }
        /// <summary>
        /// 채팅 알림을 클릭했을때 해당 방으로 이동시킴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Popup_Click(object sender, EventArgs e)
        {
            roomList.SelectedItem = popup.TitleText.Remove(popup.TitleText.IndexOf("메시지")).Substring(2);
            form.WindowState = FormWindowState.Normal;

        }

        /// <summary>
        /// 메시지 내용을 입력받아 서버에 해당 메시지를 전달
        /// </summary>
        /// <param name="message"></param>
        public void SendMessage(string message)
        {
            try
            {
                byte[] messageByte = Encoding.UTF8.GetBytes(message);//서버쪽에서 받았을때 해당 문자가 있으면 사용자가 보낸 문자라고 인식되게 함~~
                if (Client.Connected)
                {
                    Network = Client.GetStream();
                    Network.Write(messageByte, 0, messageByte.Length);
                    Network.Flush();
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }


        /// <summary>
        /// 해당 메시지가 금지된 단어로 쓰이지 않았나 확인시킴 쓰지 않으면 true를 반환
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool checkmessage(string message)
        {
            foreach (var v in bannWord)
            {
                if (message.Contains(v))
                    return false;
            }
            return true;
        }

    }
}
