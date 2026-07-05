using System;

namespace ArraysDemo
{
    class ReverseArray
    {
        public static void Demo()
        {
            Console.WriteLine("===== Reverse Array =====");

            int[] numbers = { 10, 20, 30, 40, 50 };

            Array.Reverse(numbers);

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}