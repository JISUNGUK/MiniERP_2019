using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Message.Control
{
    public partial class Board : UserControl
    {
       private List<Balloon> balloons = new List<Balloon>();
        //Balloon[] balloons = new Balloon[9];
        int nextY, index = 0;
        private string boardName;

        public Board()
        {
            InitializeComponent();

            //for (int n = 0; n < balloons.Length; n++)
            //{
               // balloons[n] = new Balloon();
                //balloons[n].Visible = false;

               // this.Controls.Add(balloons[n]);
            //}
        }

        public string BoardName { get => boardName; set => boardName = value; }
        public List<Balloon> Balloons { get => balloons; set => balloons = value; }

        public void AddMessages(string text, bool isMine)
        {
             int x = 5;

            //   if (index >= balloons.Length)
            //index = 0;
            Balloon ballon = new Balloon();
            ballon.Text = text;
            ballon.isMine = isMine;
            Balloons.Add(ballon);
          Balloons[index].isMine = isMine;
            Balloons[index].Text = text;

            /*if (nextY + balloons[index].Height > this.Height || index == 0)
            {
                for (int n = 0; n < balloons.Length; n++)
                    balloons[n].Visible = false;

                nextY = 5;
            }*/

            if (isMine)
                x = this.Width - Balloons[index].Width - 5;

            Balloons[index].Location = new Point(x, nextY);
            Balloons[index].Visible = true;

            nextY += Balloons[index].Height + 5;
            this.Controls.Add(Balloons[index]);
            index++;
        }

    }
}
