using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.OperatorsOverload
{
    class Fraction
    {
        //int[] Primes = { 2, 3, 5, 7, 11, 13};
        int numerator, denominator;
        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator { get => denominator; set => denominator = value != 0 ? value : 1; }



        public Fraction()
        {
            numerator = 1;
            denominator = 1;
        }

        public Fraction(int seed)
        {
            Random r = new Random(seed);
            Numerator = r.Next(-20, 20);
            Denominator = r.Next(-20, 20);
        }
        public Fraction(int enteredNum, int enteredDenom)
        {
            Numerator = enteredNum;
            Denominator = enteredDenom;
        }

        public double Calculate()
        {
            return Numerator / Denominator;
        }

        public Fraction Simplify()
        {
            Fraction temp = new Fraction();

            temp.Numerator = Numerator;
            temp.Denominator = Denominator;
            /*Negatives elimination*/
            if (Numerator < 0 && Denominator < 0)
            {
                temp.Numerator *= -1;
                temp.Denominator *= -1;
            }

            int size = (temp.Numerator > temp.Denominator ? temp.Numerator : temp.Denominator);
            int[] Primes = new int[size];
            for (int i = 0; i < size; i++)
            {
                Primes[i] = i + 1;
            }
            for (int c = 2; c <= Math.Sqrt(size); c++)
            {
                for (int i = c + c; i <= size; i += c)
                {
                    Primes[i - 1] = 0;
                }
            }

            for (int i = 0; i < Primes.Length; i++)
            {
                if (Primes[i] == 0)
                {
                    continue;
                }
                if (temp.Numerator == 1 || temp.Denominator == 1)
                {
                    break;
                }

                if (temp.Numerator % Primes[i] == 0 && temp.Denominator % Primes[i] == 0)
                {
                    temp.Numerator /= Primes[i];
                    temp.Denominator /= Primes[i];
                    i = 0;
                }
            }
            return temp;
        }
        public Fraction Flip()
        {
            Fraction temp = new Fraction();
            temp.Numerator = this.Denominator;
            temp.Denominator = this.Numerator;
            return temp;
        }

        public Fraction FractionPow(int power)
        {
            Fraction temp = new Fraction();
            temp.Numerator = (int)Math.Pow(this.Numerator, power);
            temp.Denominator = (int)Math.Pow(this.Denominator, power);
            return temp;
        }

        public static Fraction operator +(Fraction frac1, Fraction frac2)
        {
            Fraction temp = new Fraction();
            temp.Numerator = frac1.Numerator * frac2.Denominator + frac2.Numerator * frac1.Denominator;
            temp.Denominator = frac1.Denominator * frac2.Denominator;
            return temp;
        }
        public static Fraction operator -(Fraction frac1, Fraction frac2)
        {
            Fraction temp = new Fraction();
            temp.Numerator = frac1.Numerator * frac2.Denominator - frac2.Numerator * frac1.Denominator;
            temp.Denominator = frac1.Denominator * frac2.Denominator;
            return temp;
        }
        public static Fraction operator *(Fraction frac1, Fraction frac2)
        {
            Fraction temp = new Fraction();
            temp.Numerator = frac1.Numerator * frac2.Numerator;
            temp.Denominator = frac1.Denominator * frac2.Denominator;
            return temp;
        }
        public static Fraction operator /(Fraction frac1, Fraction frac2)
        {
            Fraction temp = new Fraction();
            temp = frac1 * frac2.Flip();
            return temp;
        }



    }
}
