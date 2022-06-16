using System;
using System.Linq;

namespace P03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            int[] roundedNum = new int[number.Length];

            for(int i = 0; i < number.Length; i++)
            {
                roundedNum[i] = (int)Math.Round(number[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number[i]} => {roundedNum[i]}");
            }
        }
    }
}
