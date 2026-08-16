using System;
using System.Collections.Generic;

namespace ListClassDemo
{
    class ListMethods
    {
        public static void Demo()
        {
            Console.WriteLine("===== Commonly Used List Methods =====");

            List<int> numbers = new List<int>();

            // Add() - appends an item to the end of the list
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            Console.WriteLine("After Add(10), Add(20), Add(30) -> [10, 20, 30]");

            // Insert() - inserts an item at a specific index, shifting later items
            numbers.Insert(1, 15);
            Console.WriteLine("After Insert(1, 15) -> [10, 15, 20, 30]");

            // Contains() - checks whether a value exists in the list
            bool hasTwenty = numbers.Contains(20);
            Console.WriteLine($"Contains(20) : {hasTwenty}");

            // IndexOf() - returns the index of the first matching value, or -1
            int index = numbers.IndexOf(20);
            Console.WriteLine($"IndexOf(20) : {index}");

            // Remove(value) removes the first matching VALUE, wherever it is.
            numbers.Remove(20);
            Console.WriteLine("After Remove(20) -> removes the value 20 (not a position)");

            // RemoveAt(index) removes the item at a specific POSITION,
            // regardless of what value is stored there.
            numbers.RemoveAt(0);
            Console.WriteLine("After RemoveAt(0) -> removes whatever value is currently at index 0");

            // Clear() removes every item
            numbers.Clear();
            Console.WriteLine($"After Clear() -> Count = {numbers.Count}");

            Console.WriteLine();
        }
    }
}
