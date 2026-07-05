using System;

namespace NamingRulesDemo
{
    class ValidIdentifiers
    {
        public static void Run()
        {
            Console.WriteLine("===== Valid Identifiers =====");

            string studentName = "Gayatri";
            int studentAge = 23;
            decimal monthlySalary = 45000.50m;
            bool isEmployee = true;

            Console.WriteLine($"Student Name : {studentName}");
            Console.WriteLine($"Student Age  : {studentAge}");
            Console.WriteLine($"Salary       : {monthlySalary}");
            Console.WriteLine($"Employee     : {isEmployee}");
        }
    }
}