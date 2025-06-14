using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class LabSession
    {
        public Course Course { get; set; }
        public List<string> Instructors { get; set; }
        public string Classroom { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string GetLabSessionInfo()
        {
            return $"{Course.CourseName} Lab Session by {string.Join(", ", Instructors)} at {StartTime} in {Classroom}";
        }
    }
}
