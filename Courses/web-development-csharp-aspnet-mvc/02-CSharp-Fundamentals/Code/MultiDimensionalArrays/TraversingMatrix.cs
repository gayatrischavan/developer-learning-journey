using System;

namespace MultidimensionalArraysDemo
{
    class TraversingMatrix
    {
        public static void Demo()
        {
            Console.WriteLine("===== Traversing Matrix =====");

            string[,] students =
            {
                {"Rahul","Amit","Sneha"},
                {"Riya","Priya","Gayatri"}
            };

            for (int row = 0; row < students.GetLength(0); row++)
            {
                Console.WriteLine($"Row {row}");

                for (int column = 0; column < students.GetLength(1); column++)
                {
                    Console.Write(students[row, column] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}