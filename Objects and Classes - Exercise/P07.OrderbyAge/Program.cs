using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.OrderbyAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPeople = new List<Person>();
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] personInfo = command.Split();
                string name = personInfo[0];
                string id = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person firstPerson = new Person(name, id, age);
                Person secondPerson = allPeople.FirstOrDefault(p => p.ID == id);

                if(secondPerson == null)
                {
                    allPeople.Add(firstPerson);
                }
                else
                {
                    secondPerson.Name = name;
                    secondPerson.ID = id;
                    secondPerson.Age = age;
                }
                command = Console.ReadLine();
            }
            allPeople = allPeople.OrderBy(p => p.Age).ToList();

            foreach (Person person in allPeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
