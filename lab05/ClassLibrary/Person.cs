using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassConsole2
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Person(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public int CompareTo(Person other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
}
