using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();
            List<string> result = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                result.AddRange(numbers[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList());
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
