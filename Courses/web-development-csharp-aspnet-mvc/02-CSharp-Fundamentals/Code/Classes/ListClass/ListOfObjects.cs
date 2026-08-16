using System;
using System.Collections.Generic;
using ClassAndObjectDemo; // Reuses the existing Employee class

namespace ListClassDemo
{
    class ListOfObjects
    {
        public static void Demo()
        {
            Console.WriteLine("===== List<Employee> =====");

            // Creating a List of Employee objects
            List<Employee> employees = new List<Employee>();

            Employee emp1 = new Employee();
            emp1.EmployeeID = 101;
            emp1.Name = "Rahul";
            emp1.Age = 28;
            emp1.Salary = 40000;

            Employee emp2 = new Employee();
            emp2.EmployeeID = 102;
            emp2.Name = "Sneha";
            emp2.Age = 25;
            emp2.Salary = 45000;

            // Adding Employee objects
            employees.Add(emp1);
            employees.Add(emp2);

            // Accessing an Employee and its properties
            Console.WriteLine($"First Employee : {employees[0].Name}, Salary : {employees[0].Salary}");

            // Looping through Employees
            Console.WriteLine("All Employees:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.EmployeeID} - {emp.Name} - {emp.Age} - {emp.Salary}");
            }

            Console.WriteLine();
        }
    }
}
