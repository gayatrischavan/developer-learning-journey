using System;

namespace ClassAndObjectDemo
{
    // A minimal class used only to demonstrate what a "field" is.
    // Kept separate from Employee.cs, which uses properties instead.
    class EmployeeFieldExample
    {
        // Field declaration: a variable declared directly inside a class.
        public int EmployeeID;
        public string Name;
    }

    class Fields
    {
        public static void Demo()
        {
            Console.WriteLine("===== Fields =====");

            // Creating an object so we can use its fields
            EmployeeFieldExample emp = new EmployeeFieldExample();

            // Field initialization (assigning a value to a field)
            emp.EmployeeID = 101;
            emp.Name = "Rahul";

            // Accessing fields using the dot operator
            Console.WriteLine($"Employee ID : {emp.EmployeeID}");
            Console.WriteLine($"Name        : {emp.Name}");

            // Updating a field
            emp.Name = "Rahul Sharma";
            Console.WriteLine($"Updated Name: {emp.Name}");

            Console.WriteLine();
        }
    }
}
