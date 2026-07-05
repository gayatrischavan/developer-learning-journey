using System;

namespace MultidimensionalArraysDemo
{
    class UpdateElements
    {
        public static void Demo()
        {
            Console.WriteLine("===== Update Elements =====");

            int[,] matrix =
            {
                {10,20,30},
                {40,50,60},
                {70,80,90}
            };

            Console.WriteLine("Before Update");

            PrintMatrix(matrix);

            matrix[1,2] = 100;

            Console.WriteLine();

            Console.WriteLine("After Update");

            PrintMatrix(matrix);

            Console.WriteLine();
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}