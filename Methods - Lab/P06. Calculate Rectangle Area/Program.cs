﻿using System;

namespace P06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(height, width);
            Console.WriteLine(area);

        }
        static double GetRectangleArea(double height, double width)
        {
            return height * width;
        }
    }
}
