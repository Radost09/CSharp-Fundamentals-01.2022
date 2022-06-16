﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();

            string command;
            while((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.
                    Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string courseName = cmdArgs[0];
                string studentName = cmdArgs[1];

                if(!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }

                courseInfo[courseName].Add(studentName);
            }
            PrintCoursesInfo(courseInfo);
        }
        static void PrintCoursesInfo(Dictionary<string, List<string>> courseInfo)
        {
            foreach (var kvp in courseInfo)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;

                Console.WriteLine($"{courseName}: {students.Count}");

                foreach (string studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
