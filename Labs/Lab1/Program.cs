﻿/*Вариант 22. Реализовать функцию возведения в куб частного двух целых чисел.*/

using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variables init*/

            bool correct = false;
            Int32 first = 0, second = 0;

            /*Entering of the first number*/

            do
            {
                Console.WriteLine("Enter first value. Must be an integer.");
                correct = Int32.TryParse(Console.ReadLine(), out first);
                Console.WriteLine(correct ? "\n" : "Error. Try again.");
            } while (!correct);

            /*Entering of the second number*/


            do
            {
                Console.WriteLine("Enter second value. Must be an integer.");
                correct = Int32.TryParse(Console.ReadLine(), out second);
                Console.WriteLine(correct ? "\n" : "Error. Try again.");
            } while (!correct);

            /*Calculatiuon & output*/
            if (second !=0)
            {
                float result = (float)first / (float)second;
                Console.WriteLine("Cube of the private of first and second value is:\t({0}/{1})^3 = {2}", first, second, Math.Pow(result, 3));
            }
            else
            {
                Console.WriteLine("Error. Second number must be different from zero.");
            }


            Console.ReadLine();
        }
    }
}
