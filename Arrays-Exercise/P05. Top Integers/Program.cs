using System;
using System.Linq;

namespace P05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] topIntegers = new int[array .Length];
            int topIntIndex = 0;

            for(int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                bool isTopInteger = true;

                for(int j = i + 1; j < array.Length; j++)
                {
                    if(currentNum <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if(isTopInteger)
                {
                    topIntegers[topIntIndex] = currentNum;
                    topIntIndex++;
                }
            }
            for(int k = 0; k < topIntIndex; k++)
            {
                int currentTopInt = topIntegers[k];
                Console.Write($"{currentTopInt} ");
            }
           
        }
    }
}
