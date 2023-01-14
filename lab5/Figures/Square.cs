namespace Figures
{
    public class Square : Rectangle
    {
        public Square(string name, int x, int y, int w) : base(x, y, w, w)
        {
            this.name = name;
        }
    }
}
