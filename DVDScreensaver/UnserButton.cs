using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDScreensaver
{
    public class UnserButton : Panel
    {
        Bitmap bmp;
        public UnserButton()
        {
            bmp = new Bitmap(DVDScreensaver.Properties.Resources.ppLogo);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var contentRect = new Rectangle(Point.Empty, ClientSize);
            pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pevent.Graphics.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);
            contentRect.Inflate(-4, -4);
            pevent.Graphics.FillEllipse(Brushes.White, contentRect);
            pevent.Graphics.DrawEllipse(new Pen(Brushes.DeepPink, 7),contentRect);

            var imgRect = new Rectangle(Point.Empty, ClientSize);
            imgRect.Inflate(-15, -15);
            pevent.Graphics.DrawImage(bmp, imgRect);
        }
    }
}
