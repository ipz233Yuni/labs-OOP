using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
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
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Юр'єв Н.І., група ІПЗ-23-3\nВаріант №5.\nЗавдання 3.3.");
            int pos=0, neg=0, odd=0, even=0;
            int i;
            bool ok;
            Console.WriteLine("Вводьте числа (через Enter), 0 - закінчує виконання програми:");
            do
            {
                do
                {
                    Console.Write("Введіть значення x:");
                    ok = int.TryParse(Console.ReadLine(), out i);
                    if (!ok)
                        Console.WriteLine("Помилка введення значення x. Будь-ласка повторіть введення значення ще раз!");
                } while (!ok);
                if (i == 0) break;
                if (i > 0) pos++;
                if (i < 0) neg++;
                if (i%2==0) even++; 
                if (i%2!=0) odd++;
            } while (i!= 0);
            Console.WriteLine("Кількість парних чисел: {0}", even);
            Console.WriteLine("Кількість непарних чисел: {0}", odd);
            Console.WriteLine("Кількість додатних чисел: {0}", pos);
            Console.WriteLine("Кількість від'ємних чисел: {0}", neg);
            Console.ReadKey();
        }
    }
}
