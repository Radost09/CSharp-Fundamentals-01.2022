using System;

namespace P01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonNums = int.Parse(Console.ReadLine());
            int sum = 0;
            string allElements = String.Empty;

            for(int i = 0; i < wagonNums; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sum += people;
                allElements += people + " ";
                
            }
            Console.WriteLine($"{allElements}");
            Console.WriteLine($"{sum}");
        }
    }
}
