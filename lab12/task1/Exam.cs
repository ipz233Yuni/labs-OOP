using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Exam
    {
        public Course Course { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Examiner { get; set; }
        public string Classroom { get; set; }

        public string GetExamInfo()
        {
            return $"Exam for {Course.CourseName} on {Date} at {Time} in {Classroom} by {Examiner}";
        }
    }
}
