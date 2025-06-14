using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1DConsole
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
            Console.WriteLine("Лабораторна робота №3.\nВиконав: Юр'єв Н.І., група ІПЗ-23-3\nВаріант №5.\nЗавдання 1.");
            bool ok;
            int n;
            do
            {
                Console.Write("Введіть розмір масиву n - ");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                    Console.WriteLine("Помилка введення значення n. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            double[] arr = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Round(-158.403 + (rnd.NextDouble() * (123.908 +158.403)),3);
                Console.WriteLine($"arr[{i}] - {arr[i]}");
            }
            int maxi = 0, mini = 0;
            double max = 0, min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxi = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    mini = i;
                }
            }
            Console.WriteLine($"max = {max} maxi ={maxi} \nmin = {min} mini = {mini}");
            double S = 0;
            for (int i = Math.Min(maxi, mini) + 1; i < Math.Max(maxi, mini); i++)
            {
                S += Math.Abs(arr[i]);
            }
            Console.WriteLine($"№1.Сума модулів елементів, які розташовані між min та max = {S}");
            double[] newarr = new double[arr.Length - maxi - 1];
            for (int i = 0, j = maxi+1; i < arr.Length - maxi-1; i++, j++)
            {
                newarr[i] = arr[j];
            }
            Array.Sort(newarr);
            Array.Reverse(newarr);
            for (int i = maxi+1, j = 0; i < arr.Length; i++, j++) {
                arr[i] = newarr[j];
            }
            Console.WriteLine("№2.Масив після упорядкування:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] - {arr[i]}");
            }
            Console.ReadKey();
        }
    }
}
