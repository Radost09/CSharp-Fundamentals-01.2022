using System;
using System.Linq;

namespace P08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for(int i = 0; i < number.Length; i++)
            {
                for(int j = i; j < number.Length; j++)
                {
                    if((number[i] + number[j] == magicNum) && (i != j))
                    {
                        Console.WriteLine($"{number[i]} {number[j]}");
                    }
                }
            }
        }
    }
}
