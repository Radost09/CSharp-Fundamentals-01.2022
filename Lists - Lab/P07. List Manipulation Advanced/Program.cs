using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToList();
            string command = Console.ReadLine();

            int counter = 0; 

            while (command != "end")
            {
                string[] token = command.Split();
                
                switch (token[0])
                {
                    case "Add":
                        int addNumber = int.Parse(token[1]);
                        numbers.Add(addNumber);
                        counter++;
                        break;

                    case "Remove":
                        int removeNumber = int.Parse(token[1]);
                        numbers.Remove(removeNumber);
                        counter++;
                        break;

                    case "RemoveAt":
                        int indexToRemove = int.Parse(token[1]);
                        numbers.RemoveAt(indexToRemove);
                        counter++;
                        break;

                    case "Insert":
                        int insertNumber = int.Parse(token[1]);
                        int indexToInsert = int.Parse(token[2]);
                        numbers.Insert(indexToInsert, insertNumber);
                        counter++;
                        break;

                    case "Contains":
                        int elementToCheck = int.Parse(token[1]);

                        if (numbers.Contains(elementToCheck))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                        break;

                    case "GetSum":
                        Console.WriteLine(string.Join(" ", numbers.Sum()));
                        break;

                    case "Filter":
                        string action = token[1];
                        int numberToCompare = int.Parse(token[2]);
                        List<int> filteredList = GetFilteredList(numbers, action, numberToCompare);

                        Console.WriteLine(string.Join(" ", filteredList));
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            if(counter > 0)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        private static List<int> GetFilteredList(List<int> numbers, string action, int numberToCompare)
        {
            if (action == "<")
            {
                List<int> result =  numbers.FindAll(x => x < numberToCompare);
                return result;
            }
            if (action == ">")
            {
                List<int> result = numbers.FindAll(x => x > numberToCompare);
                return result;
            }
            if (action == "<=")
            {
                List<int> result = numbers.FindAll(x => x <= numberToCompare);
                return result;
            }
            if (action == ">=")
            {
                List<int> result = numbers.FindAll(x => x >= numberToCompare);
                return result;
            }
            return numbers;
        }
    }
}
