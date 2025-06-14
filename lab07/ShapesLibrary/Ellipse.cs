using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Ellipse : Shape
    {
        protected int radiusX;
        protected int radiusY;

        public Ellipse() : base()
        {
            Random rnd = new Random();
            radiusX = rnd.Next(20, 50); 
            radiusY = rnd.Next(20, 50); 
        }

        public Ellipse(int x, int y, int radiusX, int radiusY, Color color) : base(x, y, color)
        {
            this.radiusX = radiusX;
            this.radiusY = radiusY;
        }

        public Ellipse(Ellipse other) : base(other)
        {
            this.radiusX = other.radiusX;
            this.radiusY = other.radiusY;
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Pen pen = new Pen(color);
            g.DrawEllipse(pen, x - radiusX, y - radiusY, 2 * radiusX, 2 * radiusY);

            g.DrawLine(pen, x, y, x + radiusX, y);
            g.DrawLine(pen, x, y, x, y - radiusY);

            g.FillEllipse(Brushes.Black, x - 2, y - 2, 4, 4);
        }
    }
}
