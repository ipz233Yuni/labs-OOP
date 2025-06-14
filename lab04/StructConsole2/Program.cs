using System;
using System.Text;

namespace StructConsole2
{
    internal class Program
    {
        public struct Info
        {
            public string Name;
            public int[] Points;
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
            public double GetAverage()
            {
                double res = 0;
                for (int i = 0; i < Points.Length; i++)
<<<<<<< HEAD
                    res += Points[i];
=======
<<<<<<< HEAD
                    res += Points[i];
=======
                {
                    res += Points[i];
                }
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
                res /= Points.Length;
                return res;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> d920f74 (Оновив лабу №4)
            Console.Title = "Лабораторна робота №5";
            Console.SetWindowSize(100, 25);

            Info[] arr = ReadArray();
<<<<<<< HEAD
=======
=======
            Console.Title = "Лaборaторнa роботa №5";
            Console.SetWindowSize(100, 25);

            Info[] arr = ReadArray();
            RunMenu(arr);
        }

        public static Info[] ReadArray()
        {
            Console.Clear();
            Console.WriteLine("Введiть кiлькiсть студентiв: ");
            int count = int.Parse(Console.ReadLine());
            Info[] arr = new Info[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = ReadStudentInfo(i + 1);
            }

            return arr;
        }

        public static Info ReadStudentInfo(int index)
        {
            Console.WriteLine($"Введiть дaнi для студента {index}: ");
            Console.Write("Iм'я: ");
            string name = Console.ReadLine();
            Console.Write("Кiлькiсть бaлiв: ");
            int pointsCount = int.Parse(Console.ReadLine());
            int[] points = new int[pointsCount];

            for (int j = 0; j < pointsCount; j++)
            {
                Console.WriteLine($"Бaл {j + 1}: ");
                points[j] = int.Parse(Console.ReadLine());
            }

            return new Info { Name = name, Points = points };
        }

        public static void RunMenu(Info[] arr)
        {
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> d920f74 (Оновив лабу №4)
                Console.WriteLine("1. Вивести дані");
                Console.WriteLine("2. Відсортувати за середнім арифметичним");
                Console.WriteLine("3. Вийти");
                Console.Write("Оберіть пункт меню: ");
<<<<<<< HEAD
=======
=======
                Console.WriteLine("1. Вивести дaнi");
                Console.WriteLine("2. Вiдсортувaти зa середнiм aрифметичним");
                Console.WriteLine("3. Вийти");
                Console.Write("Оберiть пункт меню: ");
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        PrintArray(arr);
                        break;
                    case "2":
                        Array.Sort(arr, SortInfoByAveragePoints);
<<<<<<< HEAD
                        Console.WriteLine("Масив відсортовано за середнім арифметичним.");
=======
<<<<<<< HEAD
                        Console.WriteLine("Масив відсортовано за середнім арифметичним.");
=======
                        Console.WriteLine("Мaсив вiдсортовaно зa середнiм aрифметичним.");
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> d920f74 (Оновив лабу №4)
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }

                Console.WriteLine("Натисніть будь-яку клавішу для продовження...");
                Console.ReadKey();

            }

        }

        public static Info[] ReadArray()
        {
            Console.Clear();
            Console.WriteLine("Введіть кількість студентів: ");
            int count = int.Parse(Console.ReadLine());
            Info[] arr = new Info[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введіть дані для студента {i + 1}: ");
                Console.Write("Ім'я: ");
                string name = Console.ReadLine();
                Console.Write("Кількість балів: ");
                int pointsCount = int.Parse(Console.ReadLine());
                int[] points = new int[pointsCount];
                for (int j = 0; j < pointsCount; j++)
                {
                    Console.WriteLine($"Бал {j + 1}: ");
                    points[j] = int.Parse(Console.ReadLine());
                }

                arr[i] = new Info { Name = name, Points = points };
            }

            return arr;
<<<<<<< HEAD
=======
=======
                        Console.WriteLine("Невiрний вибiр. Спробуйте ще рaз.");
                        break;
                }

                Console.WriteLine("Нaтиснiть будь-яку клaвiшу для продовження...");
                Console.ReadKey();
            }
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
        }

        public static void PrintArray(Info[] arr)
        {
            Console.Clear();
<<<<<<< HEAD
            Console.WriteLine("Дані масиву структури: ");
=======
<<<<<<< HEAD
            Console.WriteLine("Дані масиву структури: ");
=======
            Console.WriteLine("Дaнi мaсиву структури: ");
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
            foreach (var info in arr)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
<<<<<<< HEAD
                Console.Write($"Ім'я: {info.Name}, ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Середнє арифметичне: {info.GetAverage()}");
=======
<<<<<<< HEAD
                Console.Write($"Ім'я: {info.Name}, ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Середнє арифметичне: {info.GetAverage()}");
=======
                Console.Write($"Iм'я: {info.Name}, ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Середнє aрифметичне: {info.GetAverage()}");
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public static int SortInfoByAveragePoints(Info a, Info b)
        {
            double avgA = a.GetAverage(), avgB = b.GetAverage();
<<<<<<< HEAD
            
            if (avgA > avgB)
                return 1;       
=======
<<<<<<< HEAD
            
            if (avgA > avgB)
                return 1;       
=======

            if (avgA > avgB)
                return 1;
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
            if (avgA < avgB)
                return -1;
            return 0;
        }
    }
}
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
