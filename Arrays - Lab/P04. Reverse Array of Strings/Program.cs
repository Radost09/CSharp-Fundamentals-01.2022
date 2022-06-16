using System;
using System.Linq;

namespace P04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var symbols = Console.ReadLine().Split().ToArray();

            for(int i = 0; i < symbols.Length/2; i++)
            {
                var oldElement = symbols[i];
                symbols[i] = symbols[symbols.Length - 1 - i];
                symbols[symbols.Length - 1 - i] = oldElement;
            }
            Console.WriteLine(String.Join(" ", symbols));
        }
    }
}
