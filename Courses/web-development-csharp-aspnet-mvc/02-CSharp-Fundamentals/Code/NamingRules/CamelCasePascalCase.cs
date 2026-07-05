using System;

namespace NamingRulesDemo
{
    class CamelCasePascalCase
    {
        public static void Run()
        {
            Console.WriteLine("===== Naming Conventions =====");

            // camelCase (Variables)
            string employeeName = "Rahul";
            decimal monthlySalary = 55000;

            // PascalCase (Class/Method Names)
            Console.WriteLine("Variables use camelCase.");
            Console.WriteLine("Classes and Methods use PascalCase.");

            Console.WriteLine();

            Console.WriteLine($"Employee Name : {employeeName}");
            Console.WriteLine($"Salary        : {monthlySalary}");
        }
    }
}