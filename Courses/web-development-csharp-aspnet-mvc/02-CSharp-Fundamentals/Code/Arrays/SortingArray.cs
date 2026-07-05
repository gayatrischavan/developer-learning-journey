using System;

namespace ArraysDemo
{
    class SortingArray
    {
        public static void Demo()
        {
            Console.WriteLine("===== Sorting Array =====");

            int[] numbers = { 50, 10, 40, 20, 30 };

            Console.WriteLine("Before Sorting");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Array.Sort(numbers);

            Console.WriteLine();

            Console.WriteLine("After Sorting");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}