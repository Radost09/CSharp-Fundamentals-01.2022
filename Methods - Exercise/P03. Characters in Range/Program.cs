using System;

namespace P03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintCharInRange(firstChar, secondChar);
        }

        static void PrintCharInRange(char firstChar, char secondChar)
        {
            if(secondChar < firstChar)
            {
                char currentChar = firstChar;
                firstChar = secondChar;
                secondChar = currentChar;
            }
            for(char i = (char)(firstChar + 1); i < secondChar; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
