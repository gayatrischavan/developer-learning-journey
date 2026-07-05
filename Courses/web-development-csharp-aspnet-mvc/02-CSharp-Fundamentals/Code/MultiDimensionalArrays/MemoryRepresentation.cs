using System;

namespace MultidimensionalArraysDemo
{
    class MemoryRepresentation
    {
        public static void Demo()
        {
            Console.WriteLine("===== Memory Representation =====");

            int[,] matrix =
            {
                {10,20,30},
                {40,50,60},
                {70,80,90}
            };

            Console.WriteLine($"Rows    : {matrix.GetLength(0)}");

            Console.WriteLine($"Columns : {matrix.GetLength(1)}");

            Console.WriteLine();

            Console.WriteLine("Memory Layout");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"[{row},{column}]={matrix[row,column]}\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Total Elements : " + matrix.Length);

            Console.WriteLine();
        }
    }
}