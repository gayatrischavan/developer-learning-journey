using System;

namespace NamingRulesDemo
{
    class PracticeExercises
    {
        public static void Run()
        {
            Console.WriteLine("===== Practice Exercises =====");

            // Exercise 1

            string companyName = "OpenAI";
            int employeeCount = 5000;

            Console.WriteLine("\nExercise 1");
            Console.WriteLine($"Company Name  : {companyName}");
            Console.WriteLine($"Employees     : {employeeCount}");

            // Exercise 2

            string productName = "Laptop";
            decimal productPrice = 65000;

            Console.WriteLine("\nExercise 2");
            Console.WriteLine($"Product Name  : {productName}");
            Console.WriteLine($"Price         : {productPrice}");

            // Exercise 3

            string studentName = "Amit";
            int rollNumber = 101;
            double percentage = 88.50;

            Console.WriteLine("\nExercise 3");
            Console.WriteLine($"Student Name  : {studentName}");
            Console.WriteLine($"Roll Number   : {rollNumber}");
            Console.WriteLine($"Percentage    : {percentage}");

            Console.WriteLine();
            Console.WriteLine("Notice how every variable follows camelCase naming.");
        }
    }
}