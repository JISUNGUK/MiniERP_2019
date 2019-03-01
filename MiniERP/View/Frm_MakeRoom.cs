using MiniERP.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View
{
    public partial class Frm_MakeRoom : Form
    {
        private string[] roomArr;
        private string[] memberArr;



        public Frm_MakeRoom()
        {
            InitializeComponent();
        }

        public string[] RoomArr { get => roomArr; set => roomArr = value; }
        public string[] MemberArr { get => memberArr; set => memberArr = value; }

        private void Frm_MakeRoom_Load(object sender, EventArgs e)
        {
            foreach (var item in RoomArr)
            {
                roomList.Items.Add(item);
            }
            foreach (var item in MemberArr)
            {
                memberList.Items.Add(item);
            }


        }

        private void makeRoom_Click(object sender, EventArgs e)
        {
            Frm_message form = (Frm_message)this.Owner;
            MessageDAO messageDao = form.Messagedao;
            if (messageDao.checkmessage(room.Text))
                if (!String.IsNullOrEmpty(room.Text) && memberList.CheckedItems.Count > 0)
                {
                    string members = "";
                    int count = 0;
                    foreach (var item in memberList.CheckedItems)
                    {
                        if (count != 0)
                            members += "," + item;
                        else
                            members += item;
                        count++;
                    }
                    try
                    {
                        //form.SendMessage("방을 만듭니다 방명:" + room.Text + "인원:" + members + "//");
                        messageDao.SendMessage("방을 만듭니다 방명:" + room.Text + "인원:" + members + "//");
                        if (form.OwnedRoom != "")
                        {
                            form.OwnedRoom += "," + room.Text;
                        }
                        else
                            form.OwnedRoom += room.Text;
                        this.Close();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("방을 만들지 못했습니다");
                    }
                }



        }
    }
}
