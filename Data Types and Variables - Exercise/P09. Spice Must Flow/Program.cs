using System;

namespace P09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yeld = int.Parse(Console.ReadLine());
            int days = 0;
            int produced = 0;
            if (yeld < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(produced);
            }
            else
            {

                while (yeld >= 100)
                {
                    produced += yeld - 26;
                    yeld -= 10;
                    days++;
                }
                produced -= 26;
                Console.WriteLine(days);
                Console.WriteLine(produced);
            }
        }
    }
}
