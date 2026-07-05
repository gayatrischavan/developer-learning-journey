using System;

namespace ArraysDemo
{
    class ArrayInitialization
    {
        public static void Demo()
        {
            Console.WriteLine("===== Array Initialization =====");

            int[] numbers = { 10, 20, 30, 40, 50 };

            string[] cities =
            {
                "Pune",
                "Mumbai",
                "Nashik"
            };

            Console.WriteLine("Numbers:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Cities:");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine();
        }
    }
}