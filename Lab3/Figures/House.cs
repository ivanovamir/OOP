using System.Collections.Generic;
using System.Drawing;

namespace Figures
{
    public class House : Rectangle
    {
        public List<Figure> figures;
        public House(int id, int x, int y, int w, int h) : base(id, x, y, w, h)
        {
            name = "Дом";
            figures = new List<Figure>();
            Rectangle r1 = new Rectangle(0, x, y + 60, 100, 120);
            Rectangle r2 = new Rectangle(0, x + 30, y + 90, 35, 45);
            Rectangle r3 = new Rectangle(0, x + 75, y, 15, 1);
            Rectangle r4 = new Rectangle(0, x + 75, y, 1, 30);
            Rectangle r5 = new Rectangle(0, x + 90, y, 1, 47);
            Point p1 = new Point(x, y + 60);
            Point p2 = new Point(x + 50, y);
            Point p3 = new Point(x + 100, y + 60);
            Point[] points = { p1, p2, p3 };
            Triangle tgl = new Triangle(0, points);
            Figure[] f_list = { r1, r2, r3, r4, r5, tgl };
            figures.AddRange(f_list);
        }
        public override void Draw()
        {
            foreach (Figure f in figures)
            {
                f.Draw();
            }
        }
        public override void MoveTo(int x, int y)
        {
            Init.Clear();
            this.x += x;
            this.y += y;
            for (int i = 0; i < 6; i++)
            {
                Figure figure = figures[i];
                if (figure.ToString() == "Figures.Triangle")
                {
                    for (int j = 0; j < figure.points.Length; j++)
                    {
                        figure.points[j].X += x;
                        figure.points[j].Y += y;
                    }
                }
                else
                {
                    figure.x += x;
                    figure.y += y;
                }
            }
            Draw();
            foreach (Figure f in ShapeContainer.figureList)
            {
                f.Draw();
            }
        }
    }
}
