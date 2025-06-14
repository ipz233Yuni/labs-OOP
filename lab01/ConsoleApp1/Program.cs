using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            
            double x, y, z;
            bool ok;
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Юр'єв Н.І., група ІПЗ-23-3\nВаріант №5.\nЗавдання 1.");
            do
            {
                Console.Write("Введіть дробове значення x = ");
                ok = double.TryParse(Console.ReadLine(), out x);
                if (!ok)
                    Console.WriteLine("Помилка введення значення x. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть дробове значення y = ");
                ok = double.TryParse(Console.ReadLine(), out y);
                if (!ok)
                    Console.WriteLine("Помилка введення значення y. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть дробове значення z = ");
                ok = double.TryParse(Console.ReadLine(), out z);
                if (!ok)
                    Console.WriteLine("Помилка введення значення z. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            double s = Math.Sin(Math.Pow(y,-Math.Sqrt(Math.Abs(x))))*(z-x/y)+Math.Sin(Math.Cos(z));
            Console.WriteLine("Результат обчислення: s = {0:F3}", s);
            Console.ReadKey();

        }
    }
}
