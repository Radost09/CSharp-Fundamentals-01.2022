using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dungeonsRooms = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int initialHealth = 100;
            int initialBitCoin = 0;
        }
    }
}
