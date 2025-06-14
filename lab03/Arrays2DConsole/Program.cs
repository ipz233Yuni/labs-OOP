using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2DConsole
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
            Console.WriteLine("Лабораторна робота №3.\nВиконав: Юр'єв Н.І., група ІПЗ-23-3\nВаріант №5.\nЗавдання 2.");
            bool ok;
            int n, m;
            do
            {
                Console.Write("Введіть кількість рядків масиву n - ");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                    Console.WriteLine("Помилка введення значення n. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть кількість стовпців масиву m - ");
                ok = int.TryParse(Console.ReadLine(), out m);
                if (!ok)
                    Console.WriteLine("Помилка введення значення m. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            double[,] matr =new double[n,m];
            Random rnd = new Random();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = Math.Round(-8.541 + (rnd.NextDouble() * (3.530 + 8.541)), 3);
                    Console.Write($"matr[{i},{j}] = {matr[i, j],-10}");
                }
                Console.Write("\n");
            }
            double minS = 0, mini = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                double S = 0;
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    S+= matr[i,j];
                }
                Console.WriteLine($"Сума елементів {i+1} рядка = {S:F3}");
                if (S < minS)
                {
                    minS = S;
                    mini = i;
                }
            }
            Console.WriteLine($"Мінімальна сума рядка №{mini+1} = {minS:F3}");
            for (int j = 1; j < matr.GetLength(1); j += 2)
            {
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    if (matr[i, j] < 0)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            double temp = matr[k, j];
                            matr[k, j] = matr[k - 1, j];
                            matr[k - 1, j] = temp;
                        }

                    }
                }

            }
            Console.WriteLine("Масив після завдання №2");
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"matr[{i},{j}] = {matr[i, j],-10}");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
