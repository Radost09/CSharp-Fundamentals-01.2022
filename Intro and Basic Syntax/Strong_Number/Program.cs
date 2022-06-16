using System;

namespace Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int newNum = number;
            int sum = 0;

            while (newNum > 0)
            {
                int lastDigit = newNum % 10;
                newNum /= 10;

                int currentFactorial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    currentFactorial *= i;
                }
                sum += currentFactorial;
            }
            bool isStrong = number == sum;

            if (isStrong)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
