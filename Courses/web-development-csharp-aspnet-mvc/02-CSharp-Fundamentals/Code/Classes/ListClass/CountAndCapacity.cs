using System;
using System.Collections.Generic;

namespace ListClassDemo
{
    class CountAndCapacity
    {
        public static void Demo()
        {
            Console.WriteLine("===== Count vs Capacity =====");

            List<int> numbers = new List<int>();
            Console.WriteLine($"Empty list      -> Count: {numbers.Count}, Capacity: {numbers.Capacity}");

            numbers.Add(10);
            Console.WriteLine($"After 1 Add()   -> Count: {numbers.Count}, Capacity: {numbers.Capacity}");

            numbers.Add(20);
            numbers.Add(30);
            Console.WriteLine($"After 3 Add()s  -> Count: {numbers.Count}, Capacity: {numbers.Capacity}");

            // Count = number of actual elements currently stored in the list.
            // Capacity = size of the internal storage currently allocated.
            //
            // Capacity is often GREATER than Count, because List<T> allocates
            // extra internal room in advance to avoid resizing on every single
            // Add() call. Capacity automatically grows further only when more
            // room is needed than what is currently allocated.
            //
            // Capacity is NOT the maximum number of items the list can ever
            // hold - it simply reflects the current internal storage size.

            Console.WriteLine();
        }
    }
}
