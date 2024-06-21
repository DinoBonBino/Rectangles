namespace Rectangles.Models
{
    public class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}", X, Y);
        }
    }
}
