using System;

namespace P07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintMatrix(number);
        }

        static void PrintMatrix(int number)
        {
            for(int row = 1; row <= number; row++)
            {
                for(int col = 1; col <= number; col++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
