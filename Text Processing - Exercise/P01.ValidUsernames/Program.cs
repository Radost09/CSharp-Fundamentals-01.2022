using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernameToValid = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();

            for (int i = 0; i < usernameToValid.Length; i++)
            {
                string user = usernameToValid[i];
                if(user.Length >= 3 && user.Length <= 16)
                {
                    bool validUserName = IsValid(user);
                    if(validUserName == true)
                    {
                        validUsernames.Add(user);
                    }
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, validUsernames));
        }
        static bool IsValid(string user)
        {
            foreach (var symbol in user)
            {
                if(char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
