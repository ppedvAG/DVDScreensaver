using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDScreensaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int speedX = 1;
        int speedY = 1;

        Random ran = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left += speedX;
            button1.Top += speedY;

            Text = button1.Left + "x" + button1.Top;

            if (button1.Right >= ClientRectangle.Width || button1.Left <= 0)
            {
                //button1.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
                speedX *= -1;
                Task.Run(() => Console.Beep());
            }

            if (button1.Bottom >= ClientRectangle.Height || button1.Top <= 0)
            {
                //button1.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
                speedY *= -1;
                Task.Run(() => Console.Beep());
            }
        }
    }
}
