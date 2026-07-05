using System;

namespace ArraysDemo
{
    class LoopThroughArray
    {
        public static void Demo()
        {
            Console.WriteLine("===== Loop Through Array =====");

            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Using for loop:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i} = {numbers[i]}");
            }

            Console.WriteLine();

            Console.WriteLine("Using foreach loop:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
        }
    }
}