using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._List_Operations
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
            while((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string cmdType = cmdArgs[0];

                if(cmdType == "Add")
                {
                    int addNumber = int.Parse(cmdArgs[1]);

                    numbers.Add(addNumber);
                }
                else if(cmdType == "Insert")
                {
                    int insertNumber = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if(index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, insertNumber);
                }
                else if(cmdType == "Remove")
                {
                    int removeIndex = int.Parse(cmdArgs[1]);

                    if (removeIndex < 0 || removeIndex >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(removeIndex);
                }
                else if(cmdType == "Shift")
                {
                    string direction = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);
                    

                    if(direction == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if(direction == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
        static void ShiftLeft(List<int> numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;

            for (int cnt = 0; cnt < realPerformedCount; cnt++)
            {
                int firstElement = numbers.First();
                numbers.Remove(firstElement);
                numbers.Add(firstElement);
            }
        }
        static void ShiftRight(List<int> numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;

            for (int i = 0; i < realPerformedCount; i++)
            {
                int lastElement = numbers.Last();
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastElement);
            }
        }
    }
}
