using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Orders
{
    class Products
    {
        public Products(string name, double price, double quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double GetTotalPrice()
        {
            return this.Price * this.Quantity;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();
            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                double quantity = double.Parse(cmdArgs[2]);

                if (!products.Any(n => n.Name == name))
                {
                    products.Add(new Products(name, price, quantity));
                }
                else
                {
                    Products currentProduct = products.FirstOrDefault(n => n.Name == name);
                    currentProduct.Quantity += quantity;
                    currentProduct.Price = price;
                }
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} -> {product.GetTotalPrice():f2}");
            }
        }
    }
}
