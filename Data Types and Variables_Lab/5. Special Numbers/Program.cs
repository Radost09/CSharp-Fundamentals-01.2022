using System;

namespace _5._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;

            for (int i = 1; i <= n; i++)
            {
                int lastDigit = i % 10;
                int middleDigit = (i / 10) % 10;
                int firstDigit = middleDigit / 10;
                sumOfDigits = lastDigit + middleDigit + firstDigit;

                if(sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
