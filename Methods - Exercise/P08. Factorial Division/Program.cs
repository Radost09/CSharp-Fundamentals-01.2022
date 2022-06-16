using System;

namespace P08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());

            long firstNumFactorial = GetFactorial(firstNum);
            long secondNumFactorial = GetFactorial(secondNum);
            double factorialResult = (double)firstNumFactorial / secondNumFactorial;

            Console.WriteLine($"{factorialResult:f2}");
        }

        static long GetFactorial(long number)
        {
            long factorial = 1;
            for(int i = 2; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
