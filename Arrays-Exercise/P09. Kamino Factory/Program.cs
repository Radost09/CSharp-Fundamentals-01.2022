using System;
using System.Linq;

namespace P09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] sequence = new int[length];
            int longestSubseqence = -1;
            int longestSubIndex = -1;
            int longestSubSum = -1;
            int indexOfLongest = 0;

            string command = String.Empty;
            while(command != "Clone them!")
            {
                int[] currentSequence = Console.ReadLine()
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int subsequence = 0;
                int subIndex = -1;
                int subSum = 0;
                int count = 0;
            }

            for(int i = 0; i < length; i++)
            {

            }

        }
    }
}
