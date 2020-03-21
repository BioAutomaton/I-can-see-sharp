using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            bool isCorrect;
            do
            {
                isCorrect = Int32.TryParse(Console.ReadLine(), out N);
                if (!isCorrect) { Console.WriteLine("Wrong entering."); }
            } while (!isCorrect);

            quadrangle[] array = new quadrangle[N];
            double avgSquare = 0;
            int lesserSuqareCounter = 0;

            for (int i = 0; i < N; i++)
            {
                array[i] = new quadrangle();
                array[i].PrintPoints();
                array[i].SideLengt();
                Console.WriteLine("Perimeter = " + array[i].Perimeter());
                Console.WriteLine("Suare = " + array[i].Square());
                array[i].Diagonals();

                avgSquare += array[i].square;
                Console.WriteLine("-----------------------------------");
            }
            avgSquare /= N;
            Console.WriteLine("Average suare of quadrangles: " + avgSquare);
            for (int i = 0; i < N; i++)
            {
                if (array[i].square < avgSquare) { lesserSuqareCounter++; }
            }
            Console.WriteLine("Quadrangles with suare below average: " + lesserSuqareCounter);
            Console.ReadLine();
        }

    }
}


