using System;
using System.Numerics;

namespace P01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            long firstSum = firstNum + secondNum;
            long secondSum = firstSum / thirdNum;
            long thirdSum = secondSum * fourthNum;

            Console.WriteLine($"{thirdSum}");
        }
    }
}
