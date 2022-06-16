﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furnitureBought = new List<string>();
            decimal totalPrice = 0m;

            string pattern = @"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";

            string input;
            while((input = Console.ReadLine()) != "Purchase")
            {
                Match furnitureInfo = Regex.Match(input, pattern);

                if(furnitureInfo.Success)
                {
                    string furnitureName = furnitureInfo.Groups["name"].Value;
                    decimal furniturePrice = decimal.Parse(furnitureInfo.Groups["price"].Value);
                    int quantity = int.Parse(furnitureInfo.Groups["quantity"].Value);

                    furnitureBought.Add(furnitureName);
                    totalPrice += furniturePrice * quantity;
                }
            }
            PrintOutput(furnitureBought, totalPrice);
        }
        static void PrintOutput(List<string> furnitures, decimal moneySpend)
        {
            Console.WriteLine("Bought furniture:");

            foreach (string furnitureName in furnitures)
            {
                Console.WriteLine(furnitureName);
            }
            Console.WriteLine($"Total money spend: {moneySpend:f2}");
        }
    }
}
