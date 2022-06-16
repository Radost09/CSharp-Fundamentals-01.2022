using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CompanyRoster
{
    class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int numOfEmplyees = int.Parse(Console.ReadLine());
            decimal averageSalary = 0m;

            for (int i = 0; i < numOfEmplyees; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = data[0];
                decimal salary = decimal.Parse(data[1]);
                string department = data[2];

                Employee currentEmployee = new Employee(name, salary, department);
                employees.Add(currentEmployee);
            }
            List<string> departmentsList = new List<string>();
            string departmentWithMaxSalary = GetHighestSalaryDepartment(employees, departmentsList);

            List<Employee> orderedDepartment = employees.Where(x => x.Department == departmentWithMaxSalary)
                .OrderByDescending(s => s.Salary)
                .ToList();
            foreach (Employee item in orderedDepartment)
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }
        }
        static string GetHighestSalaryDepartment(List<Employee> employees, List<string> departmentsList)
        {
            foreach(Employee department in employees)
            {
                if(!departmentsList.Contains(department.Department))
                {
                    departmentsList.Add(department.Department);
                }
            }
            decimal maxAvgSalary = 0m;
            decimal currAvgSalary = 0m;
            string departmentMaxAvgSalary = string.Empty;
            foreach (string item in departmentsList)
            {
                currAvgSalary = employees.Where(x => x.Department == item).Average(s => s.Salary);

                if(currAvgSalary > maxAvgSalary)
                {
                    maxAvgSalary = currAvgSalary;
                    departmentMaxAvgSalary = item;
                }
            }
            Console.WriteLine($"Highest Average Salary: {departmentMaxAvgSalary}");
            return departmentMaxAvgSalary;
        }
    }
}
