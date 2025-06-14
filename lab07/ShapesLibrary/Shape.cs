using System;
using System.Drawing;

namespace ShapesLibrary
{
    public class Shape
    {
        protected int x, y;
        protected Color color;

        public Shape()
        {
            Random rnd = new Random();
            x = rnd.Next(0, 600);
            y = rnd.Next(0, 600);
            color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        public Shape(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public Shape(Shape other)
        {
            this.x = other.x;
            this.y = other.y;
            this.color = other.color;
        }

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public virtual void Draw(Graphics g)
        {

        }
    }
}
