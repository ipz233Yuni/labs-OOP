using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public List<Course> Courses { get; set; }
        public List<Lecture> Lectures { get; set; }
        public List<LabSession> LabSessions { get; set; }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            Courses.Remove(course);
        }

        public void AddLecture(Lecture lecture)
        {
            Lectures.Add(lecture);
        }

        public void RemoveLecture(Lecture lecture)
        {
            Lectures.Remove(lecture);
        }

        public void AddLabSession(LabSession labSession)
        {
            LabSessions.Add(labSession);
        }

        public void RemoveLabSession(LabSession labSession)
        {
            LabSessions.Remove(labSession);
        }
    }
}
