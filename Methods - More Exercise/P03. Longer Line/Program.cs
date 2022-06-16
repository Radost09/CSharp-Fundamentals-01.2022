using System;

namespace P03._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintTheCloserPoint(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void PrintTheCloserPoint(double x1, double y1, double x2, double y2
            , double x3, double y3, double x4, double y4)
        {
            double firstLine = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
            double secondLine= (x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - x3);

            if(firstLine >= secondLine)
            {
                double firstArea = x1 * x1 + y1 * y1;
                double secondArea = x2 * x2 + y2 * y2;

                if(firstArea <= secondArea)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                double firstArea = x3 * x3 + y3 * y3;
                double secondArea = x4 * x4 + y4 * y4;

                if (firstArea <= secondArea)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
    }
}
