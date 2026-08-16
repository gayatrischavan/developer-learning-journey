using System;
using System.Collections.Generic;
using ClassAndObjectDemo; // Reuses the existing Employee class

namespace ListClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== LIST CLASS DEMO ==========\n");

            ListOfIntegers.Demo();
            ListOfStrings.Demo();
            ListOfObjects.Demo();
            ListMethods.Demo();
            CountAndCapacity.Demo();
            PracticeExercises.Demo();

            // ------------------------------------------------------
            // Complete List<string> example
            // Create -> Add -> Access -> Update -> Loop -> Remove -> Count
            // ------------------------------------------------------
            Console.WriteLine("===== Complete List<string> Example =====");

            List<string> cities = new List<string>();

            cities.Add("Pune");
            cities.Add("Mumbai");
            cities.Add("Nagpur");

            Console.WriteLine($"First city : {cities[0]}");

            cities[0] = "Pune City";
            Console.WriteLine($"Updated first city : {cities[0]}");

            Console.WriteLine("All cities:");
            foreach (string city in cities)
            {
                Console.WriteLine($"- {city}");
            }

            cities.Remove("Mumbai");
            Console.WriteLine($"Count after removing Mumbai : {cities.Count}");

            // ------------------------------------------------------
            // Small List<Employee> example
            // ------------------------------------------------------
            Console.WriteLine("\n===== Small List<Employee> Example =====");

            List<Employee> employees = new List<Employee>();

            Employee emp = new Employee();
            emp.EmployeeID = 201;
            emp.Name = "Priya";
            emp.Age = 26;
            emp.Salary = 50000;

            employees.Add(emp);

            Console.WriteLine($"{employees[0].Name}'s Final Salary : {employees[0].FindSalary()}");

            Console.WriteLine("\n========== END ==========");

            Console.ReadKey();
        }
    }
}
