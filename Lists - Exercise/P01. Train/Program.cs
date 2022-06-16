using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command;
            while((command = Console.ReadLine()) != "end")
            {
                string[] addPassengers = command.Split();

                if (addPassengers[0] == "Add")
                {
                    int passengersInWagon = int.Parse(addPassengers[1]);
                    wagon.Add(passengersInWagon);
                }
                else
                {
                    int passengersToFit = int.Parse(addPassengers[0]);

                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if(wagon[i] + passengersToFit <= maxCapacity)
                        {
                            wagon[i] += passengersToFit;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", wagon));
        }
    }
}
