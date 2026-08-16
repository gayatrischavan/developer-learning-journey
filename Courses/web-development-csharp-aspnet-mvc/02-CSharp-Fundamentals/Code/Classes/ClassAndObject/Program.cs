using System;

namespace ClassAndObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== CLASS AND OBJECT DEMO ==========\n");

            Fields.Demo();
            Properties.Demo();
            GetSet.Demo();
            Methods.Demo();
            PracticeExercises.Demo();

            // ------------------------------------------------------
            // Complete Employee example
            // Class -> Object -> Properties -> Assign -> Read -> Method
            // ------------------------------------------------------
            Console.WriteLine("===== Employee Example =====");

            Employee employee = new Employee();

            employee.EmployeeID = 201;
            employee.Name = "Priya";
            employee.Age = 26;
            employee.Salary = 50000;

            Console.WriteLine($"Employee ID : {employee.EmployeeID}");
            Console.WriteLine($"Name        : {employee.Name}");
            Console.WriteLine($"Age         : {employee.Age}");
            Console.WriteLine($"Salary      : {employee.Salary}");

            double finalSalary = employee.FindSalary();
            Console.WriteLine($"Final Salary (with bonus) : {finalSalary}");

            Console.WriteLine("\n========== END ==========");

            Console.ReadKey();
        }
    }
}
