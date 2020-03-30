using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public struct Point2D
    {
        public int x;
        public int y;
    }

    public class Quadrangle
    {
        const int n = 4;
        Point2D[] points;
        public double[] length;
        public double[] diagonal;
        double perimeter = 0;
        public double square = 0;
        readonly Random r;
        public Quadrangle(int seed)
        {
            r = new Random(seed);
            points = new Point2D[4];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = r.Next(-9, 9);
                points[i].y = r.Next(-9, 9);
            }
        }

        public void SideLength()
        {            
            length = new double[n];
            for (int i = 0; i < n; i++)
            {
                length[i] = Math.Sqrt(Math.Pow(points[(i + 1) % n].x - points[i].x, 2) + Math.Pow(points[(i + 1) % n].y - points[i].y,2));
            }
        }

        public double Perimeter()
        {
            for (int i = 0; i < n; i++)
            {
                perimeter += length[i];
            }
            return perimeter;
        }

        public void Diagonals()
        {
            diagonal = new double[2];
            for (int i = 0; i < 2; i++)
            {
                diagonal[i] = Math.Sqrt(Math.Pow(points[(i + 2)].x - points[i].x, 2) + Math.Pow(points[(i + 2)].y - points[i].y, 2));
            }
        }

        public double Square()
        {
            double p = perimeter / 2;
            square = Math.Sqrt((p - length[0]) * (p - length[1]) * (p - length[2]) * (p - length[3]));
            return square;
        }

        public void PrintData()
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"X = {points[i].x}\t Y = {points[i].y}");
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + " side length = " + length[i]);
            }

            Console.WriteLine("Diagonal length: ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine((i + 1) + ": " + diagonal[i]);
            }


        }
    }
}
