using System;

namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double tottalPrice = 0;

            for(int i = 1; i <= lostGames; i++)
            {
                if(i % 12 == 0)
                {
                    tottalPrice += displayPrice;
                }
                if(i % 6 == 0)
                {
                    tottalPrice += keyboardPrice;
                }
                if(i % 3 == 0)
                {
                    tottalPrice += mousePrice;
                }
                if(i % 2 == 0)
                {
                    tottalPrice += headsetPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {tottalPrice:f2} lv.");
        }
    }
}
