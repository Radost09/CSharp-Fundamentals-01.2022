using System;
using System.Collections.Generic;

namespace P06.StoreBoxes
{
    class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
    class Box
    {
        public Box()
            {
               Item = new Item();
            }
        public int SerialNumber { get; set; }
        
        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PriceForBox
        {
            get
            {
                return this.Quantity * this.Item.Price;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command = Console.ReadLine();

            while(command == "end")
            {
                string[] cmdArgs = command.Split(' ');

                string serialNumber = cmdArgs[0];
                string itemName = cmdArgs[1];
                int quantity = int.Parse(cmdArgs[2]);
                decimal price = decimal.Parse(cmdArgs[3]);

                command = Console.ReadLine();
            }
        }
    }
}
