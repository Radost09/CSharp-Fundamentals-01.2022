using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> warShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maximumHealth = int.Parse(Console.ReadLine());
            string command;
            while((command = Console.ReadLine()) != "Retire")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if(action == "Fire")
                {
                    int warShipIndex = int.Parse(cmdArgs[1]);
                    int damage = int.Parse(cmdArgs[2]);

                    if(warShipIndex >= 0 && warShipIndex < warShip.Count)
                    {
                        warShip[warShipIndex] -= damage;
                        if(warShip[warShipIndex] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                    
                }
                else if(action == "Defend")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int damage = int.Parse(cmdArgs[3]);

                    if(startIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if(pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (action == "Repair")
                {
                    int repairIndex = int.Parse(cmdArgs[1]);
                    int health = int.Parse(cmdArgs[2]);

                    if(repairIndex >= 0 && repairIndex < pirateShip.Count)
                    {
                        if(pirateShip[repairIndex] + health > maximumHealth)
                        {
                            pirateShip[repairIndex] = maximumHealth;
                        }
                        else
                        {
                            pirateShip[repairIndex] += health;
                        }
                    }
                }
                else if (action == "Status")
                {
                    int counter = 0;
                    double currentHealth = maximumHealth * 0.2;

                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if(pirateShip[i] < currentHealth)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine($"{counter} sections need repair.");
                }
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
