using System;

namespace Po6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace P01.TheBiscuitFactory
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                double numOfBiscuitsPerWorker = double.Parse(Console.ReadLine());
                double countOfWorkers = double.Parse(Console.ReadLine());
                double otherFactoryPerMonth = double.Parse(Console.ReadLine());
                double totalBiscuits = 0;
                double difference = totalBiscuits - otherFactoryPerMonth;
                double percent = difference / otherFactoryPerMonth * 100;

                for (int i = 1; i < 30; i++)
                {
                    double totalBiscuitsPerDay = numOfBiscuitsPerWorker * countOfWorkers;

                    if (i % 3 == 0)
                    {
                        totalBiscuits += Math.Floor(totalBiscuitsPerDay * 0.75);
                    }
                    else
                    {
                        totalBiscuits += totalBiscuitsPerDay;
                    }
                }
                if (totalBiscuits > otherFactoryPerMonth)
                {

                    Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
                    Console.WriteLine($"You produce {percent:f2} percent more biscuits.");
                }

                else
                {

                    Console.WriteLine($"You produce {percent:f2} percent less biscuits.");
                }
            }
        }
    }

}
    }
}
