using System;

namespace ClassLibrary
{
    public class Student : Person
    {
        public int Course {  get; set; }
        public string Group { get; set; }
        public string Faculty {  get; set; }
        public string nameOfUniversity {  get; set; }

        public Student()
        {

        }

        public Student(string FirstName, string LastName, DateTime dateOfBirth, int course, string group, string faculty, string NameOfUniversity) 
            : base(FirstName, LastName, dateOfBirth)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            nameOfUniversity = NameOfUniversity;
        }

        public Student(Student other) : base(other)
        {
            Course = other.Course;
            Group = other.Group;
            Faculty = other.Faculty;
            nameOfUniversity = other.nameOfUniversity;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Курс: {Course}");
            Console.WriteLine($"Група: {Group}");
            Console.WriteLine($"Факультет: {Faculty}");
            Console.WriteLine($"Назва університету: {nameOfUniversity}");
        }
    }
}
