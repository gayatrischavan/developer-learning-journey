using System;

namespace ClassAndObjectDemo
{
    // Demonstrates a property backed by a manual field, plus an
    // auto-implemented property that needs no extra logic.
    class EmployeeWithProperty
    {
        // Backing field (raw storage, kept private)
        private double salary;

        // Property declaration: controls access to the "salary" field
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Auto-implemented property: the compiler creates the backing
        // field automatically, so this is used when no extra logic is needed.
        public string Name { get; set; }
    }

    class Properties
    {
        public static void Demo()
        {
            Console.WriteLine("===== Properties =====");

            EmployeeWithProperty emp = new EmployeeWithProperty();

            // Assigning values through properties
            emp.Name = "Sneha";
            emp.Salary = 45000;

            // Reading values through properties
            Console.WriteLine($"Name   : {emp.Name}");
            Console.WriteLine($"Salary : {emp.Salary}");

            // Field vs Property:
            // - Salary is a property, backed by the private "salary" field.
            // - Name is a property too, but its backing field is hidden
            //   and generated automatically by the compiler.
            // Either way, outside code always uses emp.Name / emp.Salary,
            // never a raw field directly.

            Console.WriteLine();
        }
    }
}
