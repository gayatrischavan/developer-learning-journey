using System;

namespace MultidimensionalArraysDemo
{
    class AccessElements
    {
        public static void Demo()
        {
            Console.WriteLine("===== Access Elements =====");

            int[,] matrix =
            {
                {10,20,30},
                {40,50,60},
                {70,80,90}
            };

            Console.WriteLine($"First Element : {matrix[0,0]}");

            Console.WriteLine($"Center Element : {matrix[1,1]}");

            Console.WriteLine($"Last Element : {matrix[2,2]}");

            Console.WriteLine();
        }
    }
}