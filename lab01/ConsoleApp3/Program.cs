using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int n;
            bool ok;
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Юр'єв Н.І., група ІПЗ-23-3\nВаріант №5.\nЗавдання 3.1.");
            do
            {
                Console.Write("Введіть значення N (N>0):");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                    Console.WriteLine("Помилка введення значення N. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            double result = 0;
            int j = n;
            for(int i = 1;i<=n;i++)
            {
                result += Math.Pow(i, j);
                j--;
            }
            Console.WriteLine("Результат виконання = {0}", result);
            Console.ReadKey();
        }
    }
}
