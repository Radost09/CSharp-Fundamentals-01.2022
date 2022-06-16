using System;
using System.Linq;

namespace P06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToList();
            for (int i = 0; i < word.Count - 1; i++)
            {
                char currentCh = word[i];
                char nextCh = word[i + 1];

                if(currentCh == nextCh)
                {
                    word.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(String.Join("", word));
        }
    }
}
