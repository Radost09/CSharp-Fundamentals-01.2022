using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.OldestFamilyMember
{
    public class Family
    {
        List<Person> Members = new List<Person>();

        public void AddMember(Person newMember)
        {
            Members.Add(newMember);
        }
        public void PrintOldestMember()
        {
            Person oldestPerson = Members.OrderByDescending(x => x.Age).First();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numOfPeople; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Person newPerson = new Person
                {
                    Name = personInfo[0],
                    Age = int.Parse(personInfo[1])
                };

                family.AddMember(newPerson);
            }
            family.PrintOldestMember();
        }
    }
}
