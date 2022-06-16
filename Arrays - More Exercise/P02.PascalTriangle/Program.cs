using System;

namespace P02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;

            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column <= row; column++)
                {
                    if(row == 0 || column == 0)
                    {
                        currentNum = 1;
                        Console.Write($"{currentNum} ");
                    }
                    else
                    {
                        currentNum = currentNum * (row - column + 1) / column;
                        Console.Write($"{currentNum} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
