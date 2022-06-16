using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destoyedPlanets = new List<string>();

            string pattern =
                @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:(?<population>\d+)[^\@\-\!\:\>]*?\!(?<attackType>A|D{1})\![^\@\-\!\:\>]*?\-\>(?<souldierCount>\d+)";

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decriptedMessage = DecriptMessage(encryptedMessage);

                Match orderInfo = Regex.Match(decriptedMessage, pattern);
                if (orderInfo.Success)
                {
                    string planet = orderInfo.Groups["planet"].Value;
                    string attackType = orderInfo.Groups["attackType"].Value;

                    if(attackType == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if(attackType == "D")
                    {
                        destoyedPlanets.Add(planet);
                    }
                }
            }
            PrintOutput(attackedPlanets, destoyedPlanets);
        }
        static void PrintOutput(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (string planetName in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planetName}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (string planetName in destroyedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planetName}");
            }
        }
        static string DecriptMessage(string encryptedMessage)
        {
            StringBuilder decryptedMessage = new StringBuilder();

            int decryptionKey = GetDecryptionKey(encryptedMessage);

            foreach (char currCh in encryptedMessage)
            {
                char decryptedCh = (char)(currCh - decryptionKey);
                decryptedMessage.Append(decryptedCh);
            }
            return decryptedMessage.ToString();
        }
        static int GetDecryptionKey(string encryptedMessage)
        {
            string decryptionPattern = "[star]{1}";
            MatchCollection matches = 
                Regex.Matches(encryptedMessage, decryptionPattern, RegexOptions.IgnoreCase);

            return matches.Count;
        }
    }
}
