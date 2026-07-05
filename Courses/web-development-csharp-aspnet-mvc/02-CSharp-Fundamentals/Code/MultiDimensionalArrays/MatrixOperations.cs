using System;

namespace MultidimensionalArraysDemo
{
    class MatrixOperations
    {
        public static void Demo()
        {
            Console.WriteLine("===== Matrix Operations =====");

            int[,] matrix =
            {
                {10,20,30},
                {40,50,60},
                {70,80,90}
            };

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    sum += matrix[row, column];
                }
            }

            Console.WriteLine($"Sum of Matrix Elements : {sum}");

            Console.WriteLine();

            int diagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                diagonalSum += matrix[i, i];
            }

            Console.WriteLine($"Diagonal Sum : {diagonalSum}");

            Console.WriteLine();
        }
    }
}