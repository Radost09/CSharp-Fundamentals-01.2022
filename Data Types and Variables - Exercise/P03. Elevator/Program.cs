using System;

namespace P03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int numOfCourses = (int)Math.Ceiling((double)numPeople / capacity);

            Console.WriteLine(numOfCourses);
        }
    }
}
