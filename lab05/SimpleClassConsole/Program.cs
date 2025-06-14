using System;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace SimpleClassConsole
{
    public class Program
    {
        public static Entrant[] ReadEntrantsArray()
        {
            Console.WriteLine("Введіть кількість абітурієнтів:");
            int n = int.Parse(Console.ReadLine());

            Entrant[] entrants = new Entrant[n];
            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.WriteLine($"Введіть дані для абітурієнта {i + 1}:");
                Console.Write("Ім'я: ");
                string name = Console.ReadLine();
                Console.Write("ID: ");
                string idNum = Console.ReadLine();
                Console.Write("Бали за курси: ");
                double coursePoints = double.Parse(Console.ReadLine());
                Console.Write("Бал атестату: ");
                double avgPoints = double.Parse(Console.ReadLine());

                Console.WriteLine("Введіть бали за ЗНО (предмет та бал):");
                ZNO[] znoResults = new ZNO[3];

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Предмет {j + 1}: ");
                    string subject = Console.ReadLine();
                    Console.Write("Бали: ");
                    double points = double.Parse(Console.ReadLine());
                    znoResults[j] = new ZNO(subject, points);
                }

                double payForMonth, payForYear, payForWholePeriod;

                Console.WriteLine("Введіть вартість навчання:");

                Console.WriteLine("1. За місяць");
                Console.WriteLine("2. За рік");
                Console.WriteLine("3. За весь період навчання");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введіть вартість навчання за місяць:");
                        payForMonth = double.Parse(Console.ReadLine());
                        payForYear = payForMonth * 10;
                        payForWholePeriod = payForMonth * 40;
                        break;
                    case 2:
                        Console.WriteLine("Введіть вартість навчання за рік:");
                        payForYear = double.Parse(Console.ReadLine());
                        payForMonth = payForYear / 10;
                        payForWholePeriod = payForYear * 4;
                        break;
                    case 3:
                        Console.WriteLine("Введіть вартість навчання за весь період навчання:");
                        payForWholePeriod = double.Parse(Console.ReadLine());
                        payForMonth = payForWholePeriod / 40;
                        payForYear = payForWholePeriod / 4;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір. Вартість навчання за місяць буде встановлено за замовчуванням.");
                        payForMonth = 0;
                        payForYear = 0;
                        payForWholePeriod = 0;
                        break;
                }

                entrants[i] = new Entrant(name, idNum, coursePoints, avgPoints, znoResults, payForMonth, payForWholePeriod, payForYear);
                Console.Clear();
            }



            return entrants;
        }

        public static void PrintEntrants(Entrant entrant)
        {
            Console.WriteLine($"Ім'я: {entrant.Name}");
            Console.WriteLine($"ID: {entrant.IdNum}");
            Console.WriteLine($"Бали за курси: {entrant.CoursePoints}");
            Console.WriteLine($"Бал атестату: {entrant.AvgPoints}");

            Console.WriteLine("Результати ЗНО:");
            foreach (var zno in entrant.ZNOResults)
            {
                Console.WriteLine($"Предмет: {zno.Subject}, бал за предмет: {zno.Points}");
            }
            Console.WriteLine($"Конкурсний бал: {entrant.GetCompMark()}");
            Console.WriteLine($"Найкращий предмет: {entrant.GetBestSubject()}");
            Console.WriteLine($"Найгірший предмет: {entrant.GetWorstSubject()}");
            Console.WriteLine($"Вартість навчання за місяць: {entrant.PayForMonth}");
            Console.WriteLine($"Вартість навчання за рік: {entrant.PayForYear}");
            Console.WriteLine($"Вартість навчання за весь період навчання: {entrant.PayForWholePeriod}");
        }

        public static void PrintEntrants(Entrant[] entrants)
        {
            foreach (var entrant in entrants)
            {
                PrintEntrants(entrant);
                Console.WriteLine();
            }
        }

        public static void GetEntrantsInfo(Entrant[] entrants, out double maxCompMark, out double minCompMark)
        {
            maxCompMark = entrants.Max(entrant => entrant.GetCompMark());
            minCompMark = entrants.Min(entrant => entrant.GetCompMark());
        }

        public static void SortEntrantsByPoints(Entrant[] entrants)
        {
            Array.Sort(entrants, (x, y) => y.GetCompMark().CompareTo(x.GetCompMark()));
        }

        public static void SortEntrantsByName(Entrant[] entrants)
        {
            Array.Sort(entrants, (x, y) =>
            {
                int result = string.Compare(x.Name, y.Name, StringComparison.Ordinal);
                return result != 0 ? result : y.GetCompMark().CompareTo(x.GetCompMark());
            });
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Entrant[] entrants = ReadEntrantsArray();
            Console.Clear();

            Console.WriteLine("\nІнформація про абітурієнтів:");
            PrintEntrants(entrants);

            GetEntrantsInfo(entrants, out double maxCompMark, out double minCompMark);
            Console.WriteLine($"\nНайбільший конкурсний бал: {maxCompMark}");
            Console.WriteLine($"Найменший конкурсний бал: {minCompMark}");

            SortEntrantsByPoints(entrants);
            Console.WriteLine("\nВідсортовані абітурієнти за балами:");
            PrintEntrants(entrants);

            SortEntrantsByName(entrants);
            Console.WriteLine("\nВідсортовані абітурієнти за іменем:");
            PrintEntrants(entrants);
        }
    }
}
