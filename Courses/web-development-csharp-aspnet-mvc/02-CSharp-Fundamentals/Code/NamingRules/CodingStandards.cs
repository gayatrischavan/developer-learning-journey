using System;

namespace NamingRulesDemo
{
    /// <summary>
    /// Demonstrates Microsoft's recommended C# coding standards.
    /// </summary>
    class CodingStandards
    {
        // Constant → PascalCase
        private const double Pi = 3.14159;

        // Field → _camelCase
        private string _departmentName = "Software Development";

        public static void Run()
        {
            Console.WriteLine("===== C# Coding Standards =====\n");

            // Local Variables → camelCase
            string employeeName = "Gayatri";
            int employeeId = 101;
            decimal monthlySalary = 50000.75m;
            bool isPermanentEmployee = true;

            Console.WriteLine("Local Variables (camelCase)");
            Console.WriteLine($"Employee Name : {employeeName}");
            Console.WriteLine($"Employee ID   : {employeeId}");
            Console.WriteLine($"Salary        : {monthlySalary}");
            Console.WriteLine($"Permanent     : {isPermanentEmployee}");

            Console.WriteLine();

            // Method → PascalCase
            DisplayWelcomeMessage();

            Console.WriteLine();

            Console.WriteLine("Constant (PascalCase)");
            Console.WriteLine($"PI = {Pi}");

            Console.WriteLine();

            Console.WriteLine("Field (_camelCase)");
            CodingStandards codingStandards = new CodingStandards();
            Console.WriteLine($"Department : {codingStandards._departmentName}");

            Console.WriteLine();

            Console.WriteLine("Interface Naming Example");
            Console.WriteLine("IEmployeeService");
            Console.WriteLine("IRepository");
            Console.WriteLine("ILogger");

            Console.WriteLine();

            Console.WriteLine("Class Naming Example");
            Console.WriteLine("Employee");
            Console.WriteLine("Student");
            Console.WriteLine("BankAccount");

            Console.WriteLine();

            Console.WriteLine("Property Naming Example");
            Console.WriteLine("FirstName");
            Console.WriteLine("LastName");
            Console.WriteLine("Salary");

            Console.WriteLine();

            Console.WriteLine("Parameter Naming Example");
            CalculateBonus(monthlySalary);

            Console.WriteLine();

            Console.WriteLine("===== Coding Standards Summary =====");
            Console.WriteLine("✔ Variables       → camelCase");
            Console.WriteLine("✔ Methods         → PascalCase");
            Console.WriteLine("✔ Classes         → PascalCase");
            Console.WriteLine("✔ Properties      → PascalCase");
            Console.WriteLine("✔ Constants       → PascalCase");
            Console.WriteLine("✔ Interfaces      → Prefix with 'I'");
            Console.WriteLine("✔ Private Fields  → _camelCase");
        }

        // Method → PascalCase
        private static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Method Name : DisplayWelcomeMessage()");
        }

        // Parameter → camelCase
        private static void CalculateBonus(decimal monthlySalary)
        {
            decimal bonus = monthlySalary * 0.10m;

            Console.WriteLine("Method Parameter (camelCase)");
            Console.WriteLine($"Monthly Salary : {monthlySalary}");
            Console.WriteLine($"Bonus (10%)    : {bonus}");
        }
    }
}