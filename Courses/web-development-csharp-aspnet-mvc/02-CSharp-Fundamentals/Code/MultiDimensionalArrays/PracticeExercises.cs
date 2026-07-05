using System;

namespace MultidimensionalArraysDemo
{
    class PracticeExercises
    {
        public static void Demo()
        {
            Console.WriteLine("===== Practice Exercises =====");

            int[,] marks =
            {
                {80,90,70},
                {60,75,85},
                {95,88,92}
            };

            Console.WriteLine("Student Marks");

            for (int row = 0; row < marks.GetLength(0); row++)
            {
                for (int column = 0; column < marks.GetLength(1); column++)
                {
                    Console.Write(marks[row, column] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            int highest = marks[0,0];

            for (int row = 0; row < marks.GetLength(0); row++)
            {
                for (int column = 0; column < marks.GetLength(1); column++)
                {
                    if (marks[row,column] > highest)
                    {
                        highest = marks[row,column];
                    }
                }
            }

            Console.WriteLine($"Highest Mark : {highest}");

            Console.WriteLine();

            int total = 0;

            foreach (int mark in marks)
            {
                total += mark;
            }

            Console.WriteLine($"Total Marks : {total}");

            double average = (double)total / marks.Length;

            Console.WriteLine($"Average Marks : {average:F2}");

            Console.WriteLine();
        }
    }
}