using System;

namespace ClassAndObjectDemo
{
    class PracticeExercises
    {
        public static void Demo()
        {
            Console.WriteLine("===== Practice Exercises =====");
            Console.WriteLine("Try to solve these on your own. No solutions are provided here.\n");

            Console.WriteLine("Easy");
            Console.WriteLine("1. Create a class named 'Student' with fields for Name and RollNumber.");
            Console.WriteLine("2. Create an object of the 'Student' class, assign values to its fields, and print them.");
            Console.WriteLine("3. Add an auto-implemented property 'Marks' to the 'Student' class and assign it a value.");

            Console.WriteLine();

            Console.WriteLine("Medium");
            Console.WriteLine("4. Add an 'Age' property to 'Student' using a manual backing field with get and set accessors.");
            Console.WriteLine("5. Add a method 'IsPassed()' to 'Student' that returns true if Marks is 40 or above.");
            Console.WriteLine("6. Create two objects of a class with EmployeeID, Name and Salary, and prove that each");
            Console.WriteLine("   object stores its own independent copy of the data.");

            Console.WriteLine();
        }
    }
}
