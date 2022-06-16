using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> first = new Dictionary<char, int>();

            foreach (var ch in text)
            {
                if(!first.ContainsKey(ch))
                {
                    first.Add(ch, 1);
                }
                else if(first.ContainsKey(ch))
                {
                    first[ch]++;
                }
            }
            foreach (KeyValuePair<char, int> ch in first.Where(args => args.Key != ' '))
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}
