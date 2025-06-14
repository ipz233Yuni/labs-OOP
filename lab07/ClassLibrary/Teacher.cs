using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string University {  get; set; }

        public Teacher()
        {

        }

        public Teacher(string FirstName, string LastName, DateTime dateOfBirth, string position, string department, string university) 
            : base(FirstName, LastName, dateOfBirth)
        {
            Position = position;
            Department = department;
            University = university;
        }

        public Teacher(Teacher other) : base(other)
        {
            Position = other.Position;
            Department = other.Department;
            University = other.University;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Посада: {Position}");
            Console.WriteLine($"Кафедра: {Department}");
            Console.WriteLine($"Назва університету: {University}");
        }
    }
}
