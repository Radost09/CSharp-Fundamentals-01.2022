using System;

namespace P03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double spendedMoney = 0;

            while(true)
            {
                string command = Console.ReadLine();
                if(command == "Game Time")
                {
                    break;
                }
                double price = 0;
                switch(command)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default: Console.WriteLine("Not Found"); continue;
                }
                if(currentBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                currentBalance -= price;
                spendedMoney += price;
                Console.WriteLine($"Bought {command}");

                if(currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${spendedMoney:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
