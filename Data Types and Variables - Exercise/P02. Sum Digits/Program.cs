using System;

namespace P02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while(num > 0)
            {
                int digits = num;
                digits %= 10;
                sum += digits;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
