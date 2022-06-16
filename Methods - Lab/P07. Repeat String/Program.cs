using System;

namespace P07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(command, count));
        }
        static string RepeatString(string command, int count)
        {
            string result = String.Empty;

            for(int i = 0; i < count; i++)
            {
                result += command;
            }
            return result;
        }
    }
}
