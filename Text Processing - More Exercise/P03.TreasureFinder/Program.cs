using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> keyNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            StringBuilder builder = new StringBuilder();

            int keyOrigin = keyNumbers.Count;

            string command;
            while((command = Console.ReadLine()) != "find")
            {
                string treasure = "";
                string place = "";

                for (int i = 0; i < command.Length; i++)
                {
                    int currentChar = (int)command[i];
                    int changedChar = currentChar - keyNumbers[i];
                    builder.Append((char)changedChar);
                    keyNumbers.Add(keyNumbers[i]);
                }
                for (int i = 0; i < builder.Length; i++)
                {
                    if(builder[i] == '&')
                    {
                        i++;

                        while(builder[i] != '&')
                        {
                            treasure += builder[i];
                            i++;
                        }
                    }
                    if(builder[i] == '<')
                    {
                        i++;

                        while(builder[i] != '>')
                        {
                            place += builder[i];
                            i++;
                        }
                    }
                }
                Console.WriteLine($"Found {treasure} at {place}");
                builder.Clear();
                keyNumbers.RemoveRange(keyOrigin, keyNumbers.Count - keyOrigin);
            }
        }
    }
}
