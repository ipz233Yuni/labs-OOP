using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string Type { get; set; }
        public int Credits { get; set; }

        public string GetCourseName()
        {
            return CourseName;
        }

        public int GetCredits()
        {
            return Credits;
        }
    }
}
