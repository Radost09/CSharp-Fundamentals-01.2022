using System;

namespace P08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestVol = 0;
            string biggestModel = "";

            for(int i = 0; i < n; i++)
            {
                string modelKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double heigh = double.Parse(Console.ReadLine());
                double volOfKeg = Math.PI * Math.Pow(radius, 2) * heigh;

                if (volOfKeg > biggestVol)
                {
                    biggestModel = modelKeg;
                    biggestVol = volOfKeg;
                }
            }
            
            Console.WriteLine($"{biggestModel}");
        }
    }
}
