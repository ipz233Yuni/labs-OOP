using System;
using System.Text;
using ClassLibrary;

namespace FractionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                Console.Write("Введіть перший дріб: ");
                string input1 = Console.ReadLine();
                string[] parts1 = input1.Split('/');
                int numerator1 = int.Parse(parts1[0]);
                int denominator1 = int.Parse(parts1[1]);
                Fraction fraction1 = new Fraction(numerator1, denominator1);
                fraction1.Reduce();

                Console.Write("Введіть другий дріб: ");
                string input2 = Console.ReadLine();
                string[] parts2 = input2.Split('/');
                int numerator2 = int.Parse(parts2[0]);
                int denominator2 = int.Parse(parts2[1]);
                Fraction fraction2 = new Fraction(numerator2, denominator2);
                fraction2.Reduce();

                Console.WriteLine();
                Console.WriteLine($"скорочений дріб 1: {fraction1}");
                Console.WriteLine($"скорочений дріб 2: {fraction2} \n");
                Console.WriteLine($"сума: {fraction1 + fraction2}");
                Console.WriteLine($"різниця: {fraction1 - fraction2}");
                Console.WriteLine($"добуток: {fraction1 * fraction2}");
                Console.WriteLine($"частка: {fraction1 / fraction2} \n");
                Console.WriteLine($"Перший дріб у вигляді десяткового числа: {(double)fraction1}");
                Console.WriteLine($"Другий дріб у вигляді десяткового числа: {(double)fraction2}\n");
                Console.WriteLine($"перший дріб більше другого: {fraction1 > fraction2}");
                Console.WriteLine($"перший дріб менше другого: {fraction1 < fraction2}");
                Console.WriteLine($"перший дріб більше або рівний другому: {fraction1 >= fraction2}");
                Console.WriteLine($"перший дріб менше або рівний другому: {fraction1 <= fraction2}");
                Console.WriteLine($"дроби рівні: {fraction1 == fraction2}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}

