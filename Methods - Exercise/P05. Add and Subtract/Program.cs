using System;

namespace P05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int sumOfFirstAndSecond = SumOfFirstAndSecond(firstNum, secondNum);
            Console.WriteLine(SubstractThirdFromSum(sumOfFirstAndSecond, thirdNum));
        }

        static int SumOfFirstAndSecond(int firstNum, int secondNum)
        {
            int sum = 0;
            sum = firstNum + secondNum;
            return sum;
        }

        static int SubstractThirdFromSum(int sum, int thirdNum)
        {
            return sum - thirdNum;
        }
    }
}
