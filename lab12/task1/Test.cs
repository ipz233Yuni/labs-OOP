using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Test
    {
        public Course Course { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Examiner { get; set; }
        public string Classroom { get; set; }

        public string GetTestInfo()
        {
            return $"Test for {Course.CourseName} on {Date} at {Time} in {Classroom} by {Examiner}";
        }
    }
}
