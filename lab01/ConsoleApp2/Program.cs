using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double a, b, c;
            bool ok;
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Юр'єв Н.І., група ІПЗ-23-3\nВаріант №5.\nЗавдання 2.");
            do
            {
                Console.Write("Введіть значення a = ");
                ok = double.TryParse(Console.ReadLine(), out a);
                if (!ok)
                    Console.WriteLine("Помилка введення значення a. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть значення b = ");
                ok = double.TryParse(Console.ReadLine(), out b);
                if (!ok)
                    Console.WriteLine("Помилка введення значення b. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть значення c = ");
                ok = double.TryParse(Console.ReadLine(), out c);
                if (!ok)
                    Console.WriteLine("Помилка введення значення c. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            if (a == 0) Console.WriteLine("Рівняння неквадратне!");
            else
            {
                double D = b * b - 4 * a * c;
                Console.WriteLine("Дискримінант: {0:F2}", D);
                double x1, x2;
                if (D == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Рівняння має 1 розв'язок х = {0:F2}", x1);
                }
                if (D > 0)
                {
                    x1 = (-b - Math.Sqrt(D)) / (2 * a);
                    x2 = (-b + Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("Рівняння має 2 розв'язки х1 = {0:F2}, х2 = {1:F2}", x1, x2);

                }
                if (D < 0) Console.WriteLine("Рівняння немає розв'язків");
            }
            Console.ReadKey();
        }
    }
}
