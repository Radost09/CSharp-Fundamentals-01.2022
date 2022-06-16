using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();

            while(true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    break;
                }
                string[] token = command.Split();

                switch (token[0])
                {
                    case "Add": 
                        int addNumber = int.Parse(token[1]);
                        numbers.Add(addNumber);
                        break;
                    case "Remove":
                        int removeNumber = int.Parse(token[1]);
                        numbers.Remove(removeNumber);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(token[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int insertNumber = int.Parse(token[1]);
                        int indexToInsert = int.Parse(token[2]);
                        numbers.Insert(indexToInsert, insertNumber);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
