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
    }
}
