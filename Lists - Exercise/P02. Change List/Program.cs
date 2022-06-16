using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command;
            while((command = Console.ReadLine()) != "end")
            {
                string[] word = command.Split();
                if(word[0] == "Delete")
                {
                    int elementToDelete = int.Parse(word[1]);
                    numbers.RemoveAll(x => x == elementToDelete);
                }
                else if(word[0] == "Insert")
                {
                    int element = int.Parse(word[1]);
                    int indexOfElement = int.Parse(word[2]);
                    numbers.Insert(indexOfElement, element);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
