using System;

namespace ArraysDemo
{
    class ArrayLength
    {
        public static void Demo()
        {
            Console.WriteLine("===== Array Length =====");

            int[] numbers =
            {
                10,
                20,
                30,
                40,
                50
            };

            Console.WriteLine($"Array Length : {numbers.Length}");

            Console.WriteLine();

            Console.WriteLine("Displaying using Length Property");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i} = {numbers[i]}");
            }

            Console.WriteLine();
        }
    }
}