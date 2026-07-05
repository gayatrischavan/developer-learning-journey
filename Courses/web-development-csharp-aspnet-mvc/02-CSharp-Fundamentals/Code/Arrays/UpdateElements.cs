using System;

namespace ArraysDemo
{
    class UpdateElements
    {
        public static void Demo()
        {
            Console.WriteLine("===== Update Elements =====");

            int[] marks =
            {
                60,
                70,
                80,
                90
            };

            Console.WriteLine("Before Update");

            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }

            Console.WriteLine();

            marks[2] = 95;

            Console.WriteLine();

            Console.WriteLine("After Update");

            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }

            Console.WriteLine();

            Console.WriteLine();
        }
    }
}