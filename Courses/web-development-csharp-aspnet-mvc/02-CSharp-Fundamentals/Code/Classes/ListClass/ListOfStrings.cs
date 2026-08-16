using System;
using System.Collections.Generic;

namespace ListClassDemo
{
    class ListOfStrings
    {
        public static void Demo()
        {
            Console.WriteLine("===== List<string> =====");

            // Creating a List of strings
            List<string> names = new List<string>();

            // Adding strings
            names.Add("Rahul");
            names.Add("Sneha");
            names.Add("Amit");

            // Reading an item
            Console.WriteLine($"First name : {names[0]}");

            // Updating an item
            names[1] = "Sneha Patil";
            Console.WriteLine($"Updated name at index 1 : {names[1]}");

            // Removing an item
            names.Remove("Amit");

            // Looping through the list
            Console.WriteLine("Remaining names:");
            foreach (string name in names)
            {
                Console.WriteLine($"- {name}");
            }

            // Checking Count
            Console.WriteLine($"Count : {names.Count}");

            Console.WriteLine();
        }
    }
}
