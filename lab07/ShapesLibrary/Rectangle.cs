using System;
using System.Drawing;

namespace ShapesLibrary
{
    public class Rectangle : Shape
    {
        protected int width, height;

        public Rectangle() : base()
        {
            Random rnd = new Random();
            width = rnd.Next(20, 100);
            height = rnd.Next(20, 100);
        }

        public Rectangle(int x, int y, int width, int height, Color color) : base(x, y, color)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(Rectangle other) : base(other)
        {
            this.width = other.width;
            this.height = other.height;
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Pen pen = new Pen(color);
            g.DrawRectangle(pen, x, y, width, height);

            g.FillEllipse(Brushes.Black, x - 2, y - 2, 4, 4);
            g.FillEllipse(Brushes.Black, x + width - 2, y + height - 2, 4, 4);
        }
    }
}
