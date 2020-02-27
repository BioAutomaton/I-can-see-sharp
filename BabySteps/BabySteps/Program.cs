using System;

namespace BabySteps
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct = false;
            Int32 first = 0, second = 0;
            do
            {
                Console.WriteLine("Enter first value. Mest be an integer.");
                correct = Int32.TryParse(Console.ReadLine(), out first);
                Console.WriteLine(correct == true ? "Ok" : "Error. Try again.");
            } while (!correct);
            Console.WriteLine();

            do
            {
                Console.WriteLine("Enter second value. Mest be an integer.");
                correct = Int32.TryParse(Console.ReadLine(), out second);
                Console.WriteLine(correct == true ? "Ok" : "Error. Try again.");
            } while (!correct);

            int result = first / second;
            Console.WriteLine("\n" + Math.Pow(result, 3));

            Console.ReadLine();
        }
    }
}
