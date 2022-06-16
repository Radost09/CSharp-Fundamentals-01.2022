﻿using System;

namespace P09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if(type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int outputBiggest = GetMax(first, second);
                Console.WriteLine(outputBiggest);
            }
            else if(type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char outputBiggest = GetMax(first, second);
                Console.WriteLine(outputBiggest);
            }
            else if(type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string outputBiggest = GetMax(first, second);
                Console.WriteLine(outputBiggest);
            }
        }
        static int GetMax(int first, int second)
        {
            if(first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first, char second)
        {
            if(first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string GetMax(string first, string second)
        {
            if(first.CompareTo(second) > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
