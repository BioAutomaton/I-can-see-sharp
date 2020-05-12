using System;
using System.Collections.Generic;
using System.IO;
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

        int quadranglesNumber, rectanglesNumber;
        public Quadrangle[] Quadrangles { get => quadrangles; set => quadrangles = value; }
        public double AvgQuadrSquare { get => avgQuadrSquare; set => avgQuadrSquare = value; }
        public double AvgRectSquare { get => avgRectSquare; set => avgRectSquare = value; }
        public int LesserSquareCounter { get => lesserSquareCounter; set => lesserSquareCounter = value; }

        public int Generate(int quadrNumber, int rectNumber, int seed)
        {

            quadrangles = new Quadrangle[quadrNumber + rectNumber];
            quadranglesNumber = quadrNumber;
            rectanglesNumber = rectNumber;
            for (int i = 0; i < quadrNumber; i++)
            {
                do
                {
                    quadrangles[i] = new Quadrangle(seed++);
                    quadrangles[i].GetSideLength();
                    quadrangles[i].GetDiagonals();
                } while (!quadrangles[i].IsBig());
                quadrangles[i].GetPerimeter();
                quadrangles[i].GetSquare();
                avgQuadrSquare += quadrangles[i].Square;
            }
            avgQuadrSquare /= quadrNumber;

            for (int i = 0; i < quadrNumber; i++)
            {
                if (quadrangles[i].Square < avgQuadrSquare) { lesserSquareCounter++; }
            }

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

        public Quadrangle[] Read(BinaryReader br, int quadranglesNumber, int rectanglesNumber)//to test
        {
            Quadrangle[] quadrangles = new Quadrangle[quadranglesNumber + rectanglesNumber];

            for (int i = 0; i < quadranglesNumber; i++)
            {
                quadrangles[i] = new Quadrangle();
                quadrangles[i] = quadrangles[i].Read(br);
            }
            for (int i = 0; i < rectanglesNumber; i++)
            {
                quadrangles[i + quadranglesNumber] = new Quadrangle();
                quadrangles[i+quadranglesNumber] = quadrangles[i+quadranglesNumber].Read(br);
            }

            AvgQuadrSquare = br.ReadDouble();
            AvgRectSquare = br.ReadDouble();
            LesserSquareCounter = br.ReadInt32();


            return quadrangles;
        }

        public void Write(BinaryWriter bw) 
        {
            bw.Write(quadranglesNumber);
            bw.Write(rectanglesNumber);
            for (int i = 0; i < quadrangles.Length; i++)
            {
                quadrangles[i].Write(bw);
            }
            bw.Write(AvgQuadrSquare);
            bw.Write(AvgRectSquare);
            bw.Write(LesserSquareCounter);
        }
    }
}
