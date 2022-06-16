using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string resource = Console.ReadLine();

            while(resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources[resource] = quantity;
                }
                resource = Console.ReadLine();
            }
            foreach (string key in resources.Keys)
            {
                Console.WriteLine($"{key} -> {resources[key]}");
            }
        }
    }
}
