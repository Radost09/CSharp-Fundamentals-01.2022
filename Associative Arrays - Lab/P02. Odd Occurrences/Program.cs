using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string inLowerCase = word.ToLower();
                if (counts.ContainsKey(inLowerCase))
                {
                    counts[inLowerCase]++;
                }
                else
                {
                    counts.Add(inLowerCase, 1);
                }
            }
            foreach (var count in counts)
            {
                if(count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
