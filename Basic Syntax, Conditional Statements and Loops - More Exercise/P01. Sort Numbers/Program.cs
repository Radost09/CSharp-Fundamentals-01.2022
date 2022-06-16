using System;

namespace P01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int largestNum = Math.Max(Math.Max(firstNum, secondNum), thirdNum);

            if(largestNum == thirdNum)
            {
                Console.WriteLine(thirdNum);
                Console.WriteLine(Math.Max(firstNum, secondNum));
                Console.WriteLine(Math.Min(firstNum, secondNum));
            }
            else if(largestNum == secondNum)
            {
                Console.WriteLine(secondNum);
                Console.WriteLine(Math.Max(firstNum, thirdNum));
                Console.WriteLine(Math.Min(firstNum, thirdNum));
            }
            else
            {
                Console.WriteLine(firstNum);
                Console.WriteLine(Math.Max(secondNum, thirdNum));
                Console.WriteLine(Math.Min(thirdNum, thirdNum));
            }
        }
    }
}
