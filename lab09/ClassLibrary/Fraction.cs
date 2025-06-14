namespace ClassLibrary
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменник не може бути нулем.");

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public void Reduce()
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public static implicit operator double(Fraction fraction)
        {
            return (double)fraction.numerator / fraction.denominator;
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.denominator - b.numerator * a.denominator;
            int newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.numerator;
            int newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.denominator;
            int newDenominator = a.denominator * b.numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static bool operator > (Fraction a, Fraction b)
        {
            return (double)a > (double)b;
        }

        public static bool operator < (Fraction a, Fraction b)
        {
            return (double)a < (double)b;
        }

        public static bool operator >= (Fraction a, Fraction b)
        {
            return (double)a >= (double)b;
        }

        public static bool operator <= (Fraction a, Fraction b)
        {
            return (double)a <= (double)b;
        }

        public static bool operator == (Fraction a, Fraction b)
        {
            return a.numerator == b.numerator && a.denominator == b.denominator;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
    }
}
