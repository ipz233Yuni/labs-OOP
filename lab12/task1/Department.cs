using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static task1.Program;

namespace task1
{
    internal class Department
    {
        public string DepartmentName { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<Course> Courses { get; set; }

        public void AddInstructor(Instructor instructor)
        {
            Instructors.Add(instructor);
        }

        public void RemoveInstructor(Instructor instructor)
        {
            Instructors.Remove(instructor);
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            Courses.Remove(course);
        }
    }
}
