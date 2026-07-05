using System;

namespace MultidimensionalArraysDemo
{
    class Initialization
    {
        public static void Demo()
        {
            Console.WriteLine("===== Initialization =====");

            int[,] matrix =
            {
                {10,20,30},
                {40,50,60},
                {70,80,90}
            };

            Console.WriteLine("Matrix Initialized Successfully.");

            Console.WriteLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}