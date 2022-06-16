using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsInfo = new Dictionary<string, List<double>>();
            int numPair = int.Parse(Console.ReadLine());

            for (int i = 0; i < numPair; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsInfo.ContainsKey(studentName))
                {
                    studentsInfo.Add(studentName, new List<double>());
                }
                studentsInfo[studentName].Add(grade);
            }
            foreach (var student in studentsInfo)
            {
                
                if (student.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}
