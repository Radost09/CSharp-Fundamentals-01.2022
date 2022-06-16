using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, patern);

            string[] matchedPhones = matches.Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
