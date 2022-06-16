using System;

namespace P01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfStrings = int.Parse(Console.ReadLine());
            int[] number = new int[numOfStrings];

            string vowels = "AaEeIiOoUu";
            char[] vowelsArray = vowels.ToCharArray();
            string consonants = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxYyZz";
            char[] consonantsArray = consonants.ToCharArray();

            for (int i = 0; i < numOfStrings; i++)
            {
                string word = Console.ReadLine();
                char[] letters = word.ToCharArray();

                int sum = 0;
                for (int j = 0; j < letters.Length; j++)
                {
                    char currentChar = letters[j];

                    if(vowels.Contains(currentChar))
                    {
                        sum += letters[j] * letters.Length;
                    }
                    else
                    {
                        sum += letters[j] / letters.Length;
                    }
                }
                number[i] = sum;
            }
            Array.Sort(number);
            foreach (var element in number)
            {
                Console.WriteLine($"{element}");
            }
        }
    }
}
