using System;

namespace ClassLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime dateofbirth { get; set; }

        public Person()
        {

        }

        public Person (string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            dateofbirth = dateOfBirth;
        }

        public Person(Person other)
        {
            FirstName = other.FirstName;
            LastName = other.LastName;
            dateofbirth = other.dateofbirth;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я та прізвище: {FirstName} {LastName}");
            Console.WriteLine($"Дата народження: {dateofbirth.ToShortDateString()}");
        }
    }
}
