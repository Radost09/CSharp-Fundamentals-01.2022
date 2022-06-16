using System;
using System.Linq;

namespace P02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int result = GetVowelsCount(word);
            Console.WriteLine(result);
        }
        static int GetVowelsCount(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            foreach(char ch in word.ToLower())
            {
                if(vowels.Contains(ch))
                {
                    count++;
                }   
            }
            return count;
        }
    }
}
