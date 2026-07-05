using System;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration and Initialization
            string name = "Gayatri";
            int age = 23;
            double salary = 45000.50;
            bool isEmployee = true;

            Console.WriteLine("===== Employee Details =====");
            Console.WriteLine($"Name      : {name}");
            Console.WriteLine($"Age       : {age}");
            Console.WriteLine($"Salary    : {salary}");
            Console.WriteLine($"Employee  : {isEmployee}");

            Console.WriteLine();

            // Variable Value Update
            age = 24;

            Console.WriteLine("After Birthday");
            Console.WriteLine($"Updated Age : {age}");

            Console.ReadKey();
        }
    }
}