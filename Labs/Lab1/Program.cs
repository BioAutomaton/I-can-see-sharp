using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct = false;
            Int32 first = 0, second = 0;
            do
            {
                Console.WriteLine("Enter first value. Must be an integer.");
                correct = Int32.TryParse(Console.ReadLine(), out first);
                Console.WriteLine(correct ? "\n" : "Error. Try again.");
            } while (!correct);

            do
            {
                Console.WriteLine("Enter second value. Must be an integer.");
                correct = Int32.TryParse(Console.ReadLine(), out second);
                Console.WriteLine(correct ? "\n" : "Error. Try again.");
            } while (!correct);

            float result = (float)first / (float)second;
            Console.WriteLine("Square of the private of first and second value is:\t({0}/{1})^3 = {2}", first, second, Math.Pow(result, 3));

            Console.ReadLine();
        }
    }
}
