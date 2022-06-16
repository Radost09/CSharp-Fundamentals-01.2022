using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            string command;
            int shootCounter = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                int indexOfTarget = int.Parse(command);

                if(indexOfTarget >= 0 
                    && indexOfTarget < targets.Length 
                    && targets[indexOfTarget] != -1)
                {
                    ShootTarget(indexOfTarget, targets);
                    shootCounter++;
                }
            }
            Console.WriteLine($"Shot targets: {shootCounter} -> {string.Join(" ", targets)}");
        }
        static void ShootTarget(int indexOfTarget, int[] targets)
        {
            var valueOfTargets = targets[indexOfTarget];
            targets[indexOfTarget] = -1;

            for (int i = 0; i < targets.Length; i++)
            {
                if(targets[i] == -1)
                {
                    continue;
                }
                if(targets[i] > valueOfTargets)
                {
                    targets[i] -= valueOfTargets;
                }
                else
                {
                    targets[i] += valueOfTargets;
                }
            }
        }
    }
}
