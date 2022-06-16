using System;

namespace _1._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters * 0.001;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
