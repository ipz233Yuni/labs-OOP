using System;
using System.Drawing;

namespace ShapesLibrary
{
    public class Circle : Shape
    {
        private int radius;

        public Circle() : base()
        {
            Random rnd = new Random();
            radius = rnd.Next(10, 50);
        }

        public Circle(int x, int y, Color color, int radius) : base(x, y, color)
        {
            this.radius = radius;
        }

        public Circle(Circle other) : base(other)
        {
            this.radius = other.radius;
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Pen pen = new Pen(color);
            g.DrawEllipse(pen, x - radius, y - radius, 2 * radius, 2 * radius);

            g.DrawLine(pen, x, y, x + radius, y);
            g.DrawLine(pen, x, y, x, y - radius);

            g.FillEllipse(Brushes.Black, x - 2, y - 2, 4, 4);
        }

    }
}
