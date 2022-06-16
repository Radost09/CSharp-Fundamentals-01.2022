using System;
using System.Text.RegularExpressions;

namespace P03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"\%(?<name>[A-Z]{1}[a-z]+)\%[^|$%.]*?\<(?<product>\w+)\>[^|$%.]*?\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";
            decimal totalIncome = 0m;
            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match orderInfo = Regex.Match(input, pattern);

                if (orderInfo.Success)
                {
                    string customer = orderInfo.Groups["name"].Value;
                    string product = orderInfo.Groups["product"].Value;
                    int count = int.Parse(orderInfo.Groups["count"].Value);
                    decimal price = decimal.Parse(orderInfo.Groups["price"].Value);

                    decimal totalPrice = count * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
