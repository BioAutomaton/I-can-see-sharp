using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2b__GUI_
{
    public class Storage
    {
        private Quadrangle[] quadrangles;
        private Rectangle[] rectangles;

        private double avgQuadrSquare = 0;
        private double avgRectSquare = 0;
        int lesserSquareCounter = 0;


        public double AvgQuadrSquare { get => avgQuadrSquare; }
        public double AvgRectSquare { get => avgRectSquare; }
        public int LesserSquareCounter { get => lesserSquareCounter; }
        public Rectangle[] Rectangles { get => rectangles; }
        public Quadrangle[] Quadrangles { get => quadrangles; }

        public int Generate(int quadrNumber, int rectNumber, int seed)
        {
            quadrangles = new Quadrangle[quadrNumber + rectNumber];

            for (int i = 0; i < quadrNumber; i++)
            {
                do
                {
                    quadrangles[i] = new Quadrangle(seed++);
                    quadrangles[i].GetSideLength();
                    quadrangles[i].GetDiagonals();
                } while (!quadrangles[i].IsGood());
                quadrangles[i].GetPerimeter();
                quadrangles[i].GetSquare();
                avgQuadrSquare += quadrangles[i].Square;
            }
            avgQuadrSquare /= quadrNumber;

            //Console.WriteLine("Average suare of quadrangles: " + avgSquare);
            for (int i = 0; i < quadrNumber; i++)
            {
                if (quadrangles[i].Square < avgQuadrSquare) { lesserSquareCounter++; }
            }
            //Console.WriteLine("Quadrangles with suare below average: " + lesserSquareCounter);

            /*Rectangles*/

            rectangles = new Rectangle[rectNumber];
            for (int i = 0; i < rectNumber; i++)
            {
                do
                {
                    rectangles[i] = new Rectangle(seed++);
                    rectangles[i].GetDiagonals();
                    rectangles[i].GetSideLength();
                } while (!rectangles[i].IsRectangle());
                rectangles[i].GetPerimeter();
                rectangles[i].GetSquare();
                avgRectSquare += rectangles[i].Square;
            }
            avgRectSquare /= rectNumber;


            /*Copy everything to one array*/
            for (int i = quadrNumber; i < quadrNumber + rectNumber; i++)
            {
                quadrangles[i] = new Quadrangle(0);

                quadrangles[i] = rectangles[i - quadrNumber];
            }

            return seed;
        }

    }
}
