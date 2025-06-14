using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassConsole2
{
    internal class Program
    {
        static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Додати людину");
                Console.WriteLine("2. Вивести список людей за зростанням зарплати");
                Console.WriteLine("3. Вийти");
                Console.Write("Виберіть опцію: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        PrintPeopleSortedBySalary();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }

        static void AddPerson()
        {
            Console.Write("Введіть ім'я: ");
            string name = Console.ReadLine();

            double salary;
            while (true)
            {
                Console.Write("Введіть зарплату: ");
                if (double.TryParse(Console.ReadLine(), out salary))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Невірний формат зарплати. Будь ласка, спробуйте ще раз.");
                }
            }

            people.Add(new Person(name, salary));
            Console.WriteLine("Людина успішно додана.");
        }

        static void PrintPeopleSortedBySalary()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Список людей порожній.");
                return;
            }

            people.Sort();
            Console.WriteLine("Список людей за зростанням зарплати:");
            foreach (var person in people)
            {
                Console.WriteLine($"Ім'я: {person.Name}, Зарплата: {person.Salary}");
            }
        }
    }
}
