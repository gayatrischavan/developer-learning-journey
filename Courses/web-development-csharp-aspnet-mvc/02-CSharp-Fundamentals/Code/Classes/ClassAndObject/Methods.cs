using System;

namespace ClassAndObjectDemo
{
    class Methods
    {
        // Method declaration with a parameter and a return value.
        public static double CalculateBonus(double salary, double percentage)
        {
            return salary * percentage / 100;
        }

        public static void Demo()
        {
            Console.WriteLine("===== Methods =====");

            // Calling a method, passing arguments, and using its return value
            double bonus = CalculateBonus(40000, 10);
            Console.WriteLine($"Bonus : {bonus}");

            // A method that belongs to a class: Employee.FindSalary()
            // (Employee is defined in Employee.cs)
            Employee emp = new Employee();
            emp.Name = "Amit";
            emp.Salary = 40000;

            double finalSalary = emp.FindSalary();
            Console.WriteLine($"{emp.Name}'s Final Salary : {finalSalary}");

            Console.WriteLine();
        }
    }
}
