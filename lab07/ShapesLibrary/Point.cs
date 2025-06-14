using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Point : Shape
    {
        public Point() : base()
        {
        }

        public Point(int x, int y, Color color) : base(x, y, color)
        {
        }

        public Point(Point other) : base(other)
        {
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            g.FillEllipse(Brushes.Black, x - 2, y - 2, 4, 4);
        }
    }
}
