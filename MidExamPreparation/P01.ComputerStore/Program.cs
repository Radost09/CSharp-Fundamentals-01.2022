using System;

namespace P01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            decimal totalPriceWithoutTax = 0;

            while(command != "special" && command != "regular")
            {
                decimal price = decimal.Parse(command);

                if(price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }

                totalPriceWithoutTax += price;

                command = Console.ReadLine();
            }

            if (totalPriceWithoutTax == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            decimal tax = totalPriceWithoutTax * 0.2m;

            if (command == "special")
            {
                decimal totalWithTaxes = totalPriceWithoutTax + tax;
                decimal totalPriceWithDiscount = totalWithTaxes * 0.9m;

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {tax:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPriceWithDiscount:f2}$");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {tax:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {(totalPriceWithoutTax + tax):f2}$");
            }
        }
    }
}
