using ClassLibrary;
using System;
using System.Text;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Person person = new Person("Максим", "Бондарчук", new DateTime(1960, 05, 02));
            person.ShowInfo();

            Console.WriteLine();

            Entrant entrant = new Entrant("Олег", "Тягнибок", new DateTime(2006, 04, 22), 3, 11, "Школа №10");
            entrant.ShowInfo();

            Console.WriteLine();

            Student student = new Student("Артур", "Немченко", new DateTime(2003, 12, 24), 3, "КН-20-2", "ФІКТ", "ЖДТУ");
            student.ShowInfo();

            Console.WriteLine();

            Teacher teacher = new Teacher("Анна", "Цимбалюк", new DateTime(1980, 10, 10), "Лектор", "ІПЗ", "ЖДТУ");
            teacher.ShowInfo();

            Console.WriteLine();

            LibraryUser libraryuser = new LibraryUser("Нікіта", "Ярмоленко", new DateTime(2010, 08, 10), 1487, new DateTime(2023, 12, 10), 300);
            libraryuser.ShowInfo();

            Console.ReadLine();
        }
    }
}
