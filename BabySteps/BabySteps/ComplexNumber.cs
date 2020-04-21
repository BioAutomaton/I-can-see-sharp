using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySteps
{
#pragma warning disable CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
#pragma warning disable CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
    public class ComplexNumber
#pragma warning restore CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
#pragma warning restore CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
    {
        int real;
        int imaginable;
        const char i = 'i';
        Random r = new Random();

        public ComplexNumber()
        {
            real = r.Next(0, 99);
            imaginable = r.Next(0, 99);
        }

        public string Output()
        {
            string cout;
            cout = $"a = {real} + {imaginable}*i";
            return cout;
        }

        public static ComplexNumber operator +(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber test = new ComplexNumber();

            test.real = first.real + second.real;
            test.imaginable = first.imaginable + second.imaginable;

            return test;
        }
        public static ComplexNumber operator -(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber test = new ComplexNumber();

            test.real = first.real - second.real;
            test.imaginable = first.imaginable - second.imaginable;

            return test;
        }

        
        public static ComplexNumber operator *(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber test = new ComplexNumber();

            test.real = first.real * second.real - first.imaginable * second.imaginable;
            test.imaginable = first.real * second.imaginable + first.imaginable * second.real;

            return test;
        }
                
        public static ComplexNumber operator /(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber test = new ComplexNumber();

            test.real = (first.real * second.real + first.imaginable * second.imaginable) / (second.real * second.real + second.imaginable * second.imaginable);
            test.imaginable = (first.imaginable * second.real - first.real * second.imaginable) / (second.real * second.real + second.imaginable * second.imaginable);

            return test;
        }
                        
        public static bool operator ==(ComplexNumber first, ComplexNumber second)
        {
            bool isConjugate = false;
            if (first.real == second.real)
            {
                if (Math.Abs(first.imaginable) == Math.Abs(second.imaginable))
                {
                    isConjugate = true;
                }
            }
            
            return isConjugate;
        }

        public static bool operator !=(ComplexNumber first, ComplexNumber second)
        {
            bool isConjugate = true;
            if (first.real == second.real)
            {
                if (Math.Abs(first.imaginable) == Math.Abs(second.imaginable))
                {
                    isConjugate = false;
                }
            }

            return isConjugate;
        }

    }
}
