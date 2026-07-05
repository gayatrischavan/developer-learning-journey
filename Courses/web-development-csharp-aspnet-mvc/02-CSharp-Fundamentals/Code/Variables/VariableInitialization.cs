using System;

namespace VariablesDemo
{
    class VariableInitialization
    {
        public static void Run()
        {
            int age = 23;
            string name = "Gayatri";
            double salary = 50000;
            bool isEmployee = true;

            Console.WriteLine($"Name     : {name}");
            Console.WriteLine($"Age      : {age}");
            Console.WriteLine($"Salary   : {salary}");
            Console.WriteLine($"Employee : {isEmployee}");
        }
    }
}