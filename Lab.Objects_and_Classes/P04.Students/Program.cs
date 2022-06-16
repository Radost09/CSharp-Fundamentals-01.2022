using System;
using System.Collections.Generic;

namespace P04.Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> newStudent = new List<Student>();

            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] cmdArgs = command.Split(' ');
                string firstName = cmdArgs[0];
                string lastName = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                string homeTown = cmdArgs[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };
                newStudent.Add(student);
                command = Console.ReadLine();
            }
            string filterTown = Console.ReadLine();

            foreach (Student student in newStudent)
            {
                if(student.HomeTown == filterTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
