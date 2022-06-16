using System;

namespace P07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLitters = 0;
            int capacity = 255;

            for(int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if ((sumLitters + liters) > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sumLitters += liters;
                }
            }
            Console.WriteLine(sumLitters);
        }
    }
}
