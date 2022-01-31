using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyInput
{
    public partial class Form1 : Form
    {
        int x = 50;
        int y = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //draw stuff here
            Pen penBlack = new Pen(Color.Black, 4);
            SolidBrush brushRed = new SolidBrush(Color.OrangeRed);
            SolidBrush brushRGB = new SolidBrush(Color.FromArgb(128, 255, 128));
            //      
            e.Graphics.DrawLine(penBlack, 0, 0, x, y);
            e.Graphics.DrawLine(penBlack, pictureBox1.Width, 0, x + 50, y);

            e.Graphics.DrawRectangle(penBlack, new Rectangle(x, y, 50, 50));
            e.Graphics.FillRectangle(brushRed, new Rectangle(x, y, 50, 50));

            e.Graphics.FillEllipse(brushRGB, new Rectangle(x, y, 50, 50));
            e.Graphics.DrawEllipse(penBlack, new Rectangle(x, y, 50, 50));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.A) //Capital A!!!
            {
                x -= 2;            
            }
            if (e.KeyChar == (char)Keys.D)
            {
                x += 2;
            }
        }
    }
}
