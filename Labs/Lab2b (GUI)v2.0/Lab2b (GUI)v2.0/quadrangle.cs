﻿using System;


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

        public double Perimeter { get => perimeter; }
        public double Square { get => square; }
        public double[] Diagonal { get => diagonal; }
        public double[] Length { get => length; }

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

        public void GetSideLength()
        {
            length = new double[pointsNumber];
            for (int i = 0; i < pointsNumber; i++)
            {
                length[i] = Math.Sqrt(Math.Pow(points[(i + 1) % pointsNumber].x - points[i].x, 2) + Math.Pow(points[(i + 1) % pointsNumber].y - points[i].y, 2));
            }
        }

        public void GetPerimeter()
        {
            for (int i = 0; i < pointsNumber; i++)
            {
                perimeter += Length[i];
            }
        }

        public void GetDiagonals()
        {
            diagonal = new double[2];
            for (int i = 0; i < 2; i++)
            {
                diagonal[i] = Math.Sqrt(Math.Pow(points[(i + 2)].x - points[i].x, 2) + Math.Pow(points[(i + 2)].y - points[i].y, 2));
            }
        }

        public void GetSquare()
        {
            double p = perimeter / 2;
            square = Math.Sqrt((p - Length[0]) * (p - Length[1]) * (p - Length[2]) * (p - Length[3]));
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
                data += $"{(i + 1)} diagonal = {diagonal[i]:N1}\n";
            }

            data += $"Perimeter = {Perimeter:N1}\n";
            data += $"Square = {Square:N1}\n";
            
            return data;

        }


    }
}
