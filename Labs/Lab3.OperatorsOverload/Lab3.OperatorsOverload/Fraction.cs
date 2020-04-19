using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.OperatorsOverload
{
    class Fraction
    {
        //Fraction numerator, denominator;

        //internal Fraction Numerator { get => numerator; set => numerator = value; }
        //internal Fraction Denominator { get => denominator; set => denominator = value; }

        double numerator, denominator;
        public double Numerator { get => numerator; set => numerator = value; }
        public double Denominator { get => denominator; set => denominator = value; }

        public Fraction(double enteredNum, double enteredDenom)
        {
            Numerator = enteredNum;
            Denominator = enteredDenom;
        }
        public Fraction(Fraction enteredNum, Fraction enteredDenom)
        {
            Numerator = enteredNum.Calculate();
            Denominator = enteredDenom.Calculate();
        }

        public Fraction(double enteredNum, Fraction enteredDenom)
        {
            Numerator = enteredNum;
            Denominator = enteredDenom.Calculate();
        }
        public Fraction(Fraction enteredNum, double enteredDenom)
        {
            Numerator = enteredNum.Calculate();
            Denominator = enteredDenom;
        }

        public double Calculate()
        {
            return Numerator / Denominator;
        }

        public Fraction Flip()
        {
            Fraction temp = new Fraction(0,1);
            temp.Numerator = this.Denominator;
            temp.Denominator = this.Numerator;
            return temp;
        }

        public Fraction FractionPow(int power)
        {
            Fraction temp = new Fraction(0,1);
            temp.Numerator = Math.Pow(Numerator, power);
            temp.Denominator = Math.Pow(Denominator, power);
            return temp;
        }
    }
}
