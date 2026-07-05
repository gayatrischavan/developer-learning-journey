using System;

namespace DataTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            long population = 1450000000;
            float percentage = 92.5f;
            double salary = 45000.75;
            decimal accountBalance = 250000.50m;
            char grade = 'A';
            bool isEmployee = true;
            string name = "Gayatri";

            Console.WriteLine("===== Data Types Demo =====");

            Console.WriteLine($"Name       : {name}");
            Console.WriteLine($"Age        : {age}");
            Console.WriteLine($"Population : {population}");
            Console.WriteLine($"Percentage : {percentage}");
            Console.WriteLine($"Salary     : {salary}");
            Console.WriteLine($"Balance    : {accountBalance}");
            Console.WriteLine($"Grade      : {grade}");
            Console.WriteLine($"Employee   : {isEmployee}");

            Console.ReadKey();
        }
    }
}