using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_7_1_5.Control
{
    public partial class Board : UserControl
    {
        Balloon[] balloons = new Balloon[9];
        int nextY, index = 0;

        public Board()
        {
            InitializeComponent();

            for (int n = 0; n < balloons.Length; n++)
            {
                balloons[n] = new Balloon();
                balloons[n].Visible = false;

                this.Controls.Add(balloons[n]);
            }
        }

        public void AddMessages(string text, bool isMine)
        {
            int x = 5;

            if (index >= balloons.Length)
                index = 0;

            balloons[index].isMine = isMine;
            balloons[index].Text = text;

            if (nextY + balloons[index].Height > this.Height || index == 0)
            {
                for (int n = 0; n < balloons.Length; n++)
                    balloons[n].Visible = false;

                nextY = 5;
            }

            if (isMine)
                x = this.Width - balloons[index].Width - 5;

            balloons[index].Location = new Point(x, nextY);
            balloons[index].Visible = true;

            nextY += balloons[index].Height + 5;
            index++;
        }
    }
}
