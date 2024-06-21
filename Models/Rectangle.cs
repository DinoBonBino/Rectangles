
using System.Drawing;
using System.Text;

namespace Rectangles.Models
{
    internal class Rectangle
    {
        public Rectangle(double topLeftX, double topLeftY, double botRightX, double botRightY, Color color)
        {
            Set(topLeftX, topLeftY, botRightX, botRightY, color);
        }

        public Point TopLeft { get; private set; }
        public Point TopRight { get; private set; }
        public Point BotRight { get; private set; }
        public Point BotLeft { get; private set; }
        public Color Color { get; private set; }

        public void Set(double topLeftX, double topLeftY, double botRightX, double botRightY, Color color)
        {
            TopLeft = new Point(topLeftX, topLeftY);
            TopRight = new Point(botRightX, topLeftY);
            BotRight = new Point(botRightX, botRightY);
            BotLeft = new Point(topLeftX, botRightY);
            Color = color;
        }

        public bool Contains(Rectangle rect) =>
            Contains(rect.TopLeft)
            && Contains(rect.TopRight)
            && Contains(rect.BotRight)
            && Contains(rect.BotLeft);

        public bool Intersect(Rectangle rect)
        {
            var x1 = Math.Max(TopLeft.X, rect.TopLeft.X);
            var x2 = Math.Min(BotRight.X, rect.BotRight.X);
            var y1 = Math.Max(TopLeft.Y, rect.TopLeft.Y);
            var y2 = Math.Min(BotRight.Y, rect.BotRight.Y);

            if (x2 >= x1 && y2 >= y1)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine();
            builder.AppendLine("TopLeft = " + TopLeft);
            builder.AppendLine("TopRight = " + TopRight);
            builder.AppendLine("BotRight = " + BotRight);
            builder.AppendLine("BotLeft = " + BotLeft);
            builder.AppendLine("Color = " + Color.Name);
            return builder.ToString();
        }

        private bool Contains(Point point) => 
            TopLeft.X <= point.X 
            && point.X < TopRight.X 
            && TopLeft.Y <= point.Y 
            && point.Y < BotLeft.Y;
    }
}