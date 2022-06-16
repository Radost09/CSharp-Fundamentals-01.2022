using System;
using System.Linq;

namespace P03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] rightDiagonal = new int[n];
            int[] leftDiagonal = new int[n];

            for (int row = 0; row < n; row++)
            {
                int[] currentArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (row % 2 == 0)
                {
                    rightDiagonal[row] = currentArr[0];
                    leftDiagonal[row] = currentArr[1];
                }
                else
                {
                    rightDiagonal[row] = currentArr[1];
                    leftDiagonal[row] = currentArr[0];
                }
            }
            Console.WriteLine(String.Join(" ", rightDiagonal));
            Console.WriteLine(String.Join(" ", leftDiagonal));
        }
    }
}
