using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Lecture
    {
        public Course Course { get; set; }
        public string Lecturer { get; set; }
        public string Classroom { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string GetLectureInfo()
        {
            return $"{Course.CourseName} Lecture by {Lecturer} at {StartTime} in {Classroom}";
        }
    }
}
