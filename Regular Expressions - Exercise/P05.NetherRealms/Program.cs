using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.NetherRealms
{
    internal class Program
    {
        public static object ToList { get; private set; }

        static void Main(string[] args)
        {
            List<string> demonsName = Console.ReadLine()
                .Split(',', '0', ' ')
                .ToList();
        }
    }
}
