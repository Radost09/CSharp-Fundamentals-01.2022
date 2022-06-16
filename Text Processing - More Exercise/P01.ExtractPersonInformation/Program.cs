using System;
using System.Linq;

namespace P01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string personInfo = Console.ReadLine();

                int indexBeforeTheName = personInfo.IndexOf('@');
                int indexAfterTheName = personInfo.IndexOf('|');

                string name = personInfo.Substring(indexBeforeTheName + 1,
                    indexAfterTheName - indexBeforeTheName - 1);

                int indexBeforeTheAge = personInfo.IndexOf('#');
                int indexAfterTheAge = personInfo.IndexOf('*');

                string age = personInfo.Substring(indexBeforeTheAge + 1,
                    indexAfterTheAge - indexBeforeTheAge - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
