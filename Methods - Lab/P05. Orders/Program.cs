using System;

namespace P05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintFinalPrice(product, quantity);
        }
        static void PrintFinalPrice(string product, int quantity)
        {
            decimal price = 0;
            switch (product)
            {
                case "coffee":
                    price = quantity * 1.50m;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "water":
                    price = quantity * 1.00m;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "coke":
                    price = quantity * 1.40m;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "snacks":
                    price = quantity * 2.00m;
                    Console.WriteLine($"{price:f2}");
                    break;
            }
        }
    }
}
