using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command;
            int moveCount = 0;
            while((command = Console.ReadLine()) != "end")
            {
                moveCount++;
                string[] twoIntegers = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int firstInteger = int.Parse(twoIntegers[0]);
                int secondInteger = int.Parse(twoIntegers[1]);

                if(IsInvalidGuess(firstInteger, secondInteger, elements))
                {
                    int middleOfElements = elements.Count / 2;
                    string elementToAdd = $"-{moveCount}a";
                    elements.Insert(middleOfElements, elementToAdd);
                    elements.Insert(middleOfElements, elementToAdd);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements[firstInteger] == elements[secondInteger])
                {
                    string guessedElement = elements[firstInteger];
                    elements.Remove(guessedElement);
                    elements.Remove(guessedElement);

                    Console.WriteLine($"Congrats! You have found matching elements - {guessedElement}!");
                }
                else if(elements[firstInteger] != elements[secondInteger])
                {
                    Console.WriteLine("Try again!");
                }
                if(elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moveCount} turns!");
                    break;
                }
            }
            if(elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", elements));
            }
        }
        static bool IsInvalidGuess(int firstInteger, int secondInteger, List<string> elements)
        {
            return firstInteger == secondInteger
                || !IsGuessInList(firstInteger, elements)
                || !IsGuessInList(secondInteger, elements);
        }
        static bool IsGuessInList(int guess, List<string> elements)
        {
            return guess >= 0 && guess < elements.Count;

        }
    }
}
