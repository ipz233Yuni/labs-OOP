using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static task1.Program;

namespace task1
{
    internal class Deanery
    {
        public List<Student> Students { get; set; }
        public bool Attendance { get; set; }
        public bool IntermediateControl { get; set; }
        public bool Coursework { get; set; }
        public string Results { get; set; }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void UpdateResults(string results)
        {
            Results = results;
        }
    }
}
