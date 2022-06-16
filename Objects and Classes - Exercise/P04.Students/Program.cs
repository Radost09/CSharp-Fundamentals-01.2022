using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Students
{
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int numOfStudents = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOfStudents; i++)
            {
                string[] studentsArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string currStudentFirstName = studentsArgs[0];
                string currStudenrLastName = studentsArgs[1];
                double currStudentGrade = double.Parse(studentsArgs[2]);

                Student currStudent = new Student(currStudentFirstName, currStudenrLastName, currStudentGrade);

                students.Add(currStudent);     
            }
            List<Student> orderedStudents = students.OrderByDescending(s => s.Grade)
               .ToList();
            foreach (Student student in orderedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
