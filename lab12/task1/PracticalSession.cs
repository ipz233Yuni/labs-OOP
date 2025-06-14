using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class PracticalSession
    {
        public Course Course { get; set; }
        public string Instructor { get; set; }
        public string Classroom { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string GetPracticalSessionInfo()
        {
            return $"{Course.CourseName} Practical Session by {Instructor} at {StartTime} in {Classroom}";
        }
    }
}
