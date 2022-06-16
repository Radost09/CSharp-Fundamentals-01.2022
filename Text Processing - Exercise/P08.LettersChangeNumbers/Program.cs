using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            decimal sum = 0;

            foreach (string word in words)
            {
                sum += CalculateSingleWordChars(word);
            }
            Console.WriteLine($"{sum:f2}");
        }

        static decimal CalculateSingleWordChars(string word)
        {
            decimal sum = 0;

            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];

            int num = int.Parse(word.Substring(1, word.Length - 2));

            int firstLetterPosition = GetAlphabeticalPositionOfCharacter(firstLetter);
            int lastLetterPosition = GetAlphabeticalPositionOfCharacter(lastLetter);

            if(firstLetterPosition == -1 || lastLetterPosition == -1)
            {
                return 0m;
            }
            if(char.IsUpper(firstLetter))
            {
                sum = (decimal)num / firstLetterPosition;
            }
            else if(char.IsLower(firstLetter))
            {
                sum = (decimal)num * firstLetterPosition;
            }
            if(char.IsUpper(lastLetter))
            {
                sum -= lastLetterPosition;
            }
            else if(char.IsLower(lastLetter))
            {
                sum += lastLetterPosition;
            }
            return sum;
        }

        private static int GetAlphabeticalPositionOfCharacter(char ch)
        {
            if(!char.IsLetter(ch))
            {
                return -1;
            }
            char chCI = char.ToLowerInvariant(ch);

            return (int)chCI - 96;
        }
    }
}
