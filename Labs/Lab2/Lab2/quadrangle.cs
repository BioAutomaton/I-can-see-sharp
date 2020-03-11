using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public struct point2D
    {
        public int x;
        public int y;
    }
        class quadrangle
    {
        point2D[] points;
        Random r = new Random();

        public quadrangle()
        {
            this.points = new point2D[4];

            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = r.Next(-10,10);
                points[i].y = r.Next(-10,10);
   
            }
        }

        public void print()
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"X = {points[i].x} Y = {points[i].y}");
            }
        }
        public void sideLengt()
        { }
    }
}
