using System;

namespace ArraysDemo
{
    class PracticeExercises
    {
        public static void Demo()
        {
            Console.WriteLine("===== Practice Exercises =====");

            // Exercise 1
            int[] marks = { 75, 80, 85, 90, 95 };

            Console.WriteLine("Student Marks");

            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Exercise 2
            int total = 0;

            foreach (int mark in marks)
            {
                total += mark;
            }

            Console.WriteLine($"Total Marks : {total}");

            double average = (double)total / marks.Length;

            Console.WriteLine($"Average Marks : {average}");

            Console.WriteLine();

            // Exercise 3
            int highest = marks[0];

            foreach (int mark in marks)
            {
                if (mark > highest)
                {
                    highest = mark;
                }
            }

            Console.WriteLine($"Highest Mark : {highest}");

            Console.WriteLine();

            // Exercise 4
            Console.WriteLine("Reverse Order");

            for (int i = marks.Length - 1; i >= 0; i--)
            {
                Console.Write(marks[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Practice Completed Successfully.");
        }
    }
}