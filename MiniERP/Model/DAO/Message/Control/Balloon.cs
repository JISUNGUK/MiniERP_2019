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
    public partial class Balloon : UserControl
    {
        private Graphics graphics;

        private string text;
        public override string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                this.ReSize();
                this.Refresh();
            }
        }

        public bool isMine;

        public Balloon()
        {
            InitializeComponent();
        }

        private void ReSize()
        {
            string temp = null;

            int lines = (int)(Encoding.Default.GetByteCount(text) / 18) + 2;
            int m = 0;
            this.Height = (lines * 9) + 20;

            for (int n = 0; n < text.Length; n++)
            {
                temp += text.Substring(n, 1);
                m += Encoding.Default.GetByteCount(text.Substring(n, 1));

                if (m > 18) { m = 0; temp += '\n'; }
            }

            text = temp;
        }

        private void DrawBalloon()
        {
            graphics = CreateGraphics();
            Point[] points = new Point[8];
            Brush brush;

            if (isMine)
            {
                points = new Point[]{
                    new Point(5, 0), new Point(this.Width, 0),
                    new Point(this.Width - 5, 5), new Point(this.Width - 5, this.Height - 5),
                    new Point(this.Width - 10, this.Height), new Point(5, this.Height),
                    new Point(0, this.Height - 5), new Point(0, 5)
                };

                brush = Brushes.LightYellow;
            }
            else
            {
                points = new Point[8]{
                    new Point(0, 0), new Point(this.Width - 5, 0),
                    new Point(this.Width, 5), new Point(this.Width, this.Height - 5),
                    new Point(this.Width - 5, this.Height), new Point(15, this.Height),
                    new Point(10, this.Height - 5), new Point(10, 10)
                };

                brush = Brushes.LightGreen;
            }

            graphics.FillPolygon(brush, points);
        }

        private void DrawText()
        {
            int x = 15;

            if (isMine)
                x = 5;

            graphics.DrawString(text, new Font(FontFamily.GenericSansSerif, 9), new SolidBrush(Color.Black), x, 5);
        }

        private void Balloon_Paint(object sender, PaintEventArgs e)
        {
            DrawBalloon();
            DrawText();
        }
    }
}