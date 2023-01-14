using System.Drawing;

namespace Figures
{
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y, int w, int h) : base(x, y)
        {
            this.w = w;
            this.h = h;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }
    }
}
