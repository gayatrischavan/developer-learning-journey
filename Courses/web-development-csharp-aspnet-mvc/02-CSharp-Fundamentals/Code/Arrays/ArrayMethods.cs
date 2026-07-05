using System;

namespace ArraysDemo
{
    class ArrayMethods
    {
        public static void Demo()
        {
            Console.WriteLine("===== Common Array Methods =====");

            int[] numbers = { 40, 10, 30, 50, 20 };

            Console.WriteLine($"Length : {numbers.Length}");

            Console.WriteLine($"First  : {numbers[0]}");

            Console.WriteLine($"Last   : {numbers[numbers.Length - 1]}");

            Console.WriteLine();

            Console.WriteLine("Original Array");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Array.Sort(numbers);

            Console.WriteLine();

            Console.WriteLine("Sorted Array");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}