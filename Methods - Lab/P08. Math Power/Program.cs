using System;

namespace P08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double theBase = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(theBase, power));
        }

        static double RaiseToPower(double theBase, int power)
        {
            double result = 0;
            result = Math.Pow(theBase, power);

            return result;
        }
    }
}
