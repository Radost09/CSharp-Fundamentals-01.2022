using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();

            string command;
            while((command = Console.ReadLine()) != "end of contest")
            {
                string[] lines = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contestTitle = lines[0];
                string passForcontest = lines[1];

                if(!contests.ContainsKey(contestTitle))
                {
                    contests.Add(contestTitle, passForcontest);
                }
            }
            string newCommand;
            while ((newCommand = Console.ReadLine()) != "end of submissions")
            {
                string[] newLines = newCommand
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contest = newLines[0];
                string password = newLines[1];
                string username = newLines[2];
                int points = int.Parse(newLines[3]);

                if(contests.ContainsKey(contest) || contests[contest] != password)
                {
                    if(!results.ContainsKey(username))
                    {
                        results[username] = new Dictionary<string, int>();
                    }
                }
            }
        }
    }
}
