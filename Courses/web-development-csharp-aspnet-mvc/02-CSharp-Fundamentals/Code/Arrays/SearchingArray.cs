using System;

namespace ArraysDemo
{
    class SearchingArray
    {
        public static void Demo()
        {
            Console.WriteLine("===== Searching Array =====");

            int[] numbers = { 10, 20, 30, 40, 50 };

            int index = Array.IndexOf(numbers, 30);

            Console.WriteLine($"30 Found At Index : {index}");

            Array.Sort(numbers);

            int binaryIndex = Array.BinarySearch(numbers, 40);

            Console.WriteLine($"40 Found At Index : {binaryIndex}");

            Console.WriteLine();
        }
    }
}