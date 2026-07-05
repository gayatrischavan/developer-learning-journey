using System;

namespace ArraysDemo
{
    class AccessElements
    {
        public static void Demo()
        {
            Console.WriteLine("===== Access Elements =====");

            int[] marks =
            {
                80,
                75,
                90,
                85
            };

            Console.WriteLine($"First Mark  : {marks[0]}");

            Console.WriteLine($"Second Mark : {marks[1]}");

            Console.WriteLine($"Third Mark  : {marks[2]}");

            Console.WriteLine($"Fourth Mark : {marks[3]}");

            Console.WriteLine();
        }
    }
}