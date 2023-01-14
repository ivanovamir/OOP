using System.Drawing;

namespace Figures
{
    public class Ellipse : Figure
    {
        public Ellipse(int x, int y, int r1, int r2) : base(x, y)
        {
            w = r1 * 2;
            h = r2 * 2;
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(Init.pen, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }
    }
}
