using System;

namespace _2._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal BGP = decimal.Parse(Console.ReadLine());
            decimal USD = BGP * 1.31m;

            Console.WriteLine($"{USD:f3}");
        }
    }
}
