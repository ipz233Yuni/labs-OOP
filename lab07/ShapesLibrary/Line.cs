using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Line : Shape
    {
        protected int endX;
        protected int endY;

        public Line() : base()
        {
            Random rnd = new Random();
            endX = rnd.Next(100, 200); 
            endY = rnd.Next(100, 200);
        }

        public Line(int startX, int startY, int endX, int endY, Color color) : base(startX, startY, color)
        {
            this.endX = endX;
            this.endY = endY;
        }

        public Line(Line other) : base(other)
        {
            this.endX = other.endX;
            this.endY = other.endY;
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Pen pen = new Pen(color);
            g.DrawLine(pen, x, y, endX, endY);

            g.FillEllipse(Brushes.Black, x - 2, y - 2, 4, 4);
            g.FillEllipse(Brushes.Black, endX - 2, endY - 2, 4, 4);
        }
    }
}
