using System;

namespace P10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int pokeDivide = powerN / 2;
            int targets = 0;

            while(distanceM <= powerN)
            {
                powerN -= distanceM;
                targets++;

                if(powerN == pokeDivide && exhaustionFactorY > 0)
                {
                    powerN /= exhaustionFactorY;
                }
            }
            Console.WriteLine(powerN);
            Console.WriteLine(targets);
        }
    }
}
