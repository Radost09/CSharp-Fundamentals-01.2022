using System;
using System.Linq;

namespace P10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugsIndex = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[fieldSize];

            for(int i = 0; i < fieldSize; i++)
            {
                if(ladyBugsIndex.Contains(i))
                {
                    field[i] = 1;
                }
            }
            string command;
            while((command = Console.ReadLine()) != "end")
            {  
                string[] cmndArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int initialIndex = int.Parse(cmndArgs[0]);
                string direction = cmndArgs[1];
                int flyLength = int.Parse(cmndArgs[2]);

                if(initialIndex < 0 || initialIndex >= field.Length)
                {
                    continue;
                }
                if(field[initialIndex] == 0)
                {
                    continue;
                }

                field[initialIndex] = 0;
                int nextIndex = initialIndex;

                while(true)
                {
                    if(direction == "right")
                    {
                        nextIndex += flyLength;
                    }
                    else if(direction == "left")
                    {
                        nextIndex -= flyLength;
                    }
                    if(nextIndex < 0 || nextIndex >= fieldSize)
                    {
                        break;
                    }
                    if(field[nextIndex] == 0)
                    {
                        break;
                    }
                }
                if(nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}
