namespace Figures
{
    public class Circle : Ellipse
    {
        public Circle(string name, int x, int y, int r) : base(x, y, r, r)
        {
            this.name = name;
        }
    }
}
