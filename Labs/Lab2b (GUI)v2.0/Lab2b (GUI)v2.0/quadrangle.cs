using System;
using System.IO;

namespace Lab2b__GUI_
{
    public struct Point2D
    {
        public int x;
        public int y;
    }

    public class Quadrangle
    {
        private const int pointsNumber = 4;
        Point2D[] points;
        private double[] length;
        private double[] diagonal;
        private double perimeter = 0;
        private double square = 0;
        readonly Random r;

        public double[] Length { get => length; set => length = value; }
        public double[] Diagonal { get => diagonal; set => diagonal = value; }
        public double Square { get => square; set => square = value; }
        public double Perimeter { get => perimeter; set => perimeter = value; }
        public Point2D[] Points { get => points; set => points = value; }

        public Quadrangle(int seed)
        {
            r = new Random(seed);
            points = new Point2D[4];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = r.Next(5, 20);
                points[i].y = r.Next(5, 20);
            }
        }

        public Quadrangle()
        {
            points = new Point2D[4];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = 1;
                points[i].y = 1;
            }
            GetSideLength();
            GetDiagonals();
            GetPerimeter();
            GetSquare();
        }

        public void GetSideLength()
        {
            Length = new double[pointsNumber];
            for (int i = 0; i < pointsNumber; i++)
            {
                Length[i] = Math.Sqrt(Math.Pow(points[(i + 1) % pointsNumber].x - points[i].x, 2) + Math.Pow(points[(i + 1) % pointsNumber].y - points[i].y, 2));
            }
        }

        public void GetPerimeter()
        {
            for (int i = 0; i < pointsNumber; i++)
            {
                Perimeter += Length[i];
            }
        }

        public void GetDiagonals()
        {
            Diagonal = new double[2];
            for (int i = 0; i < 2; i++)
            {
                Diagonal[i] = Math.Sqrt(Math.Pow(points[(i + 2)].x - points[i].x, 2) + Math.Pow(points[(i + 2)].y - points[i].y, 2));
            }
        }

        public void GetSquare()
        {
            double p = Perimeter / 2;
            Square = Math.Sqrt((p - Length[0]) * (p - Length[1]) * (p - Length[2]) * (p - Length[3]));
        }

        public bool IsBig()
        {
            bool result = true;
            for (int i = 0; i < 4; i++)
            {
                if (length[i] < 4)
                {
                    result = false;
                    break;
                }
                /*Additional check could be added here. For example, return false if no parallel sides detected. But it would slow the algorithm*/
                /*So I decided to leave it be*/
            }

            return result;
        }

        public string PrintData()
        {
            string data = "";

            for (int i = 0; i < points.Length; i++)
            {
                data += $"X = { points[i].x }\t Y = { points[i].y }\n";
            }

            for (int i = 0; i < pointsNumber; i++)
            {
                data += $"{i + 1} side length = {Length[i]:N1}\n";
            }

            for (int i = 0; i < 2; i++)
            {
                data += $"{(i + 1)} diagonal = {Diagonal[i]:N1}\n";
            }

            data += $"Perimeter = {Perimeter:N1}\n";
            data += $"Square = {Square:N1}\n";
            
            return data;

        }

        public void Write(BinaryWriter bw)
        {
            for (int i = 0; i < points.Length; i++)
            {
                bw.Write(points[i].x);
                bw.Write(points[i].y);
            }
            for (int i = 0; i < pointsNumber; i++)
            {
                bw.Write(Length[i]);
            }
            for (int i = 0; i < 2; i++)
            {
                bw.Write(Diagonal[i]);
            }
            bw.Write(Perimeter);
            bw.Write(Square);
            //bw.Write("\n---\n");


        }

        public Quadrangle Read(BinaryReader br)
        {
            Quadrangle temp = new Quadrangle();

            for (int i = 0; i < points.Length; i++)
            {
                temp.points[i].x = br.ReadInt32();
                temp.points[i].y = br.ReadInt32();
            }
            for (int i = 0; i < pointsNumber; i++)
            {
                temp.Length[i] = br.ReadDouble();
            }
            for (int i = 0; i < 2; i++)
            {
                temp.Diagonal[i] = br.ReadDouble();
            }
            temp.Perimeter = br.ReadDouble();
            temp.Square = br.ReadDouble();

            return temp;
        }
    }
}
