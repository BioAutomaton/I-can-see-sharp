using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter the number of quadrangles:");
            int K = 0;
            bool isCorrect;
            do
            {
                isCorrect = Int32.TryParse(Console.ReadLine(), out K);
                if (!isCorrect) { Console.WriteLine("Wrong entering."); }
            } while (!isCorrect);


            Quadrangle[] Quadrangles = new Quadrangle[K];
            double avgSquare = 0;
            int lesserSquareCounter = 0;

            for (int i = 0; i < K; i++)
            {
                Quadrangles[i] = new Quadrangle(i);
                Quadrangles[i].SideLength();
                Quadrangles[i].Diagonals();
                Quadrangles[i].PrintData();
                Console.WriteLine("Perimeter = " + Quadrangles[i].Perimeter());
                Console.WriteLine("Suare = " + Quadrangles[i].Square());


                avgSquare += Quadrangles[i].square;
                Console.WriteLine("-----------------------------------");
            }
            avgSquare /= K;

            Console.WriteLine("Average suare of quadrangles: " + avgSquare);
            for (int i = 0; i < K; i++)
            {
                if (Quadrangles[i].square < avgSquare) { lesserSquareCounter++; }
            }
            Console.WriteLine("Quadrangles with suare below average: " + lesserSquareCounter);

            Console.WriteLine();

            /*Rectangles*/

            Console.WriteLine("Enter the number of rectangles:");
            int L = 0;
            avgSquare = 0; // reset avg square
            isCorrect = false;
            do
            {
                isCorrect = Int32.TryParse(Console.ReadLine(), out L);
                if (!isCorrect) { Console.WriteLine("Wrong entering."); }
            } while (!isCorrect);


            Rectangle[] Rectangles = new Rectangle[L];
            int seedCounter = K + 1;
            for (int i = 0; i < L; i++)
            {
                do
                {
                    Rectangles[i] = new Rectangle(seedCounter++);
                    Rectangles[i].Diagonals();
                    Rectangles[i].SideLength();
                } while (!Rectangles[i].IsRectangle());
                Rectangles[i].PrintData();
                Console.WriteLine("Perimeter = " + Rectangles[i].Perimeter());
                Console.WriteLine("Suare = " + Rectangles[i].Square());
                avgSquare += Rectangles[i].square;
                Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine("Average suare of rectangles: " + avgSquare);
            Console.ReadLine();
        }

    }
}


