using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2b__GUI_
{
    public class Storage
    {
        public Quadrangle[] Quadrangles;
        public Rectangle[] Rectangles;
        private double avgQuadrSquare = 0;
        private double avgRectSquare = 0;
        int lesserSquareCounter = 0;


        public double AvgQuadrSquare { get => avgQuadrSquare; }
        public double AvgRectSquare { get => avgRectSquare; }
        public int LesserSquareCounter { get => lesserSquareCounter; }

        public int Generate(int quadrNumber, int rectNumber, int seed)
        { 




            Quadrangles = new Quadrangle[quadrNumber];

            for (int i = 0; i < quadrNumber; i++)
            {
                Quadrangles[i] = new Quadrangle(seed++);
                Quadrangles[i].GetSideLength();
                Quadrangles[i].GetDiagonals();
                Quadrangles[i].GetPerimeter();
                Quadrangles[i].GetSquare();
                avgQuadrSquare += Quadrangles[i].Square;
            }
            avgQuadrSquare /= quadrNumber;

            //Console.WriteLine("Average suare of quadrangles: " + avgSquare);
            for (int i = 0; i < quadrNumber; i++)
            {
                if (Quadrangles[i].Square < avgQuadrSquare) { lesserSquareCounter++; }
            }
            //Console.WriteLine("Quadrangles with suare below average: " + lesserSquareCounter);

            /*Rectangles*/

            Rectangles = new Rectangle[rectNumber];
            for (int i = 0; i < rectNumber; i++)
            {
                do
                {
                    Rectangles[i] = new Rectangle(seed++);
                    Rectangles[i].GetDiagonals();
                    Rectangles[i].GetSideLength();
                } while (!Rectangles[i].IsRectangle());
                Rectangles[i].GetPerimeter();
                Rectangles[i].GetSquare();
                avgRectSquare += Rectangles[i].Square;
            }
            avgRectSquare /= rectNumber;

            return seed;
        }

    }
}
