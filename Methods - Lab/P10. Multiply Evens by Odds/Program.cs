using System;

namespace P10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvenAndOdds(Math.Abs(number)));
        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }
        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            
            while(number != 0)
            {
                int currentNumber = number % 10;

                if(number % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                number = number / 10;
            }
            return evenSum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;

            while( number != 0)
            {
                int currentNumber = number % 10;

                if (number % 2 != 0)
                {
                    oddSum += currentNumber;
                }
                number = number / 10;
            }
            return oddSum;
        }
    }
}
