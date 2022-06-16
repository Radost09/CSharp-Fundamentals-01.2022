using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while(true)
            {
                if(firstPlayer.Count == 0 || secondPlayer.Count == 0)
                {
                    break;
                }
                if(firstPlayer[0] == secondPlayer[0])
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if(firstPlayer[0] > secondPlayer[0])
                {
                    int firstCard = secondPlayer[0];
                    int secondCard = firstPlayer[0];
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.Add(firstCard);
                    firstPlayer.Add(secondCard);
                }
                else if(secondPlayer[0] > firstPlayer[0])
                {
                    int firstCard = firstPlayer[0];
                    int secondCard = secondPlayer[0];
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                    secondPlayer.Add(firstCard);
                    secondPlayer.Add(secondCard);
                }
            }
            if(firstPlayer.Sum() > secondPlayer.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
