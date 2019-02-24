using MiniERP.View;
using System;
using System.Collections;
using System.Collections.Generic;
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

        public void SendChatMessage(string sendMsg, ComboBox combo)
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
                        popup.Delay = 1000;
                        popup.TitleText = "방:" + roomname + "메시지//";
                        popup.ContentText = message;
                        popup.Click += Popup_Click;
                        popup.Popup();

                    }
                    if (roomList.SelectedIndex != -1)
                    {
                        if (roomList.SelectedItem.ToString() == roomname)
                        {

                            ChatContent.Text = ChatContent.Text + "\n" + date + Environment.NewLine + ">>" + message + "\n";
                            ChatContent.SelectionStart = ChatContent.TextLength;
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
                        popup.Delay = 1000;
                        popup.TitleText = "방:" + "전체" + "메시지";
                        popup.ContentText = readData;
                        popup.Click += Popup_Click;
                        popup.Popup();
                    }
                }


            }

        }

        private void Popup_Click(object sender, EventArgs e)
        {
            roomList.SelectedItem = popup.TitleText.Remove(popup.TitleText.IndexOf("메시지")).Substring(2);
            form.WindowState = FormWindowState.Normal;

        }

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
