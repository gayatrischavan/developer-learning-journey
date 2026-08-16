using System;
using System.Collections.Generic;

namespace ListClassDemo
{
    class ListOfIntegers
    {
        public static void Demo()
        {
            Console.WriteLine("===== List<int> =====");

            // Creating a List of integers
            List<int> numbers = new List<int>();

            // Adding items
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            // Accessing an element by index
            Console.WriteLine($"Element at index 0 : {numbers[0]}");

            // Updating an element
            numbers[1] = 99;
            Console.WriteLine($"Updated element at index 1 : {numbers[1]}");

            // Removing an element by value
            numbers.Remove(99);
            Console.WriteLine("Removed the value 99.");

            // Removing an element by index
            numbers.RemoveAt(0);
            Console.WriteLine("Removed the element at index 0.");

            // Checking Count
            Console.WriteLine($"Count after removals : {numbers.Count}");

            // Clearing the list
            numbers.Clear();
            Console.WriteLine($"Count after Clear() : {numbers.Count}");

            Console.WriteLine();
        }
    }
}
