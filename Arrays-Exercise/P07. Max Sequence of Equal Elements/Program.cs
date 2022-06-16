using System;
using System.Linq;

namespace P07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int count = 1;
            int best = 0;
            int dublicate = 0;
            int index = array[0];

            for(int i = 1; i < array.Length; i++)
            {
                if(index == array[i])
                {
                    count++;
                }
                else
                {
                    index = array[i];
                    count = 1;
                }
                if(count > best)
                {
                    best = count;
                    dublicate = array[i];
                }
            }
            for(int i = 0; i < best; i++)
            {
                Console.Write($"{dublicate} ");
            }
        }
    }
}
