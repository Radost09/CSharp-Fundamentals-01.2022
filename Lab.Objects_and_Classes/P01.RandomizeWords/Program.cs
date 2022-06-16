using System;
using System.Linq;

namespace P01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(0, words.Length);

                string currentWords = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = currentWords;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
