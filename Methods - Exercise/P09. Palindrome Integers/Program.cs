using System;

namespace P09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(GetBool(input).ToString().ToLower());
                }
            }
        }
        static bool GetBool(string reversed)
        {
            bool isPalindrome = false;
            if(reversed.Length == 1)
            {
                isPalindrome = true;
                return isPalindrome;
            }

            for(int i = 0; i < reversed.Length / 2; i++)
            {
                for(int j = reversed.Length - 1 - i; j >= reversed.Length / 2; j--)
                {
                    if(reversed[i] == reversed[j])
                    {
                        isPalindrome = true;
                        j--;
                        break;
                    }
                    else
                    {
                        isPalindrome = false;
                        return isPalindrome;
                    }
                }
            }
            return isPalindrome;
        }
    }
}
