using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassConsole
{
    public class ZNO
    {
        private string subject;
        private double points;

        public string Subject { get => subject; set => subject = value; }
        public double Points { get => points; set => points = value; }

        public ZNO()
        {
            Subject = "";
            Points = 0;
        }

        public ZNO(string subject, double points)
        {
            Subject = subject;
            Points = points;
        }

        public ZNO(ZNO zno)
        {
            Subject = zno.Subject;
            Points = zno.Points;
        }
    }
}

