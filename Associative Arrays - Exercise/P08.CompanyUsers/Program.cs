using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyInfo = new Dictionary<string, List<string>>();

            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.
                    Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string companyName = cmdArgs[0];
                string employeeID = cmdArgs[1];

                if(!companyInfo.ContainsKey(companyName))
                {
                    companyInfo.Add(companyName, new List<string>());
                }
                if(!companyInfo[companyName].Contains(employeeID))
                {
                    companyInfo[companyName].Add(employeeID);
                }
            }
            foreach (var company in companyInfo)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
