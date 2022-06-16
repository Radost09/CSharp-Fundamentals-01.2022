using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();
            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string cmdType = command[0];
                string username = command[1];

                if(cmdType == "register")
                {
                    string licensePlateNum = command[2];

                    RegisterUser(parkingRegister, username, licensePlateNum);
                }
                else if(cmdType == "unregister")
                {
                    UnregisterUser(parkingRegister, username);
                }
            }
            foreach (var kvp in parkingRegister)
            {
                string username = kvp.Key;
                string licensePlateNum = kvp.Value;
                Console.WriteLine($"{username} => {licensePlateNum}");
            }
        }
        static void RegisterUser(Dictionary<string, string> parkingRegister,
            string username, string licensePlateNum)
        {
            if(parkingRegister.ContainsKey(username))
            {
                string licensePlateRegistered = parkingRegister[username];

                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNum}");
            }
            else
            {
                parkingRegister[username] = licensePlateNum;

                Console.WriteLine($"{username} registered {licensePlateNum} successfully");
            }
        }
        static void UnregisterUser(Dictionary<string, string> parkingRegister, string username)
        {
            if(!parkingRegister.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                parkingRegister.Remove(username);

                Console.WriteLine($"{username} unregistered successfully");
            }
        }
    }
}
