using System;

namespace P10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            GetTopNumber(number);
        }

        static void GetTopNumber(int number)
        {
            for(int i = 1; i <= number; i++)
            {
                int sum = 0;
                int currentNum = i;
                int reversedNum = currentNum;
                int digitCount = 0;

                while(reversedNum != 0)
                {
                    currentNum = reversedNum % 10;
                    reversedNum /= 10;

                    if(currentNum % 2 != 0)
                    {
                        digitCount++;
                    }
                    sum += currentNum;
                }
                if(sum % 8 == 0 && digitCount >= 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
