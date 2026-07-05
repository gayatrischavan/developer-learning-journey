using System;

namespace MultidimensionalArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== MULTIDIMENSIONAL ARRAYS =====\n");

            Declaration.Demo();
            Initialization.Demo();
            AccessElements.Demo();
            UpdateElements.Demo();
            MemoryRepresentation.Demo();
            NestedLoops.Demo();
            MatrixOperations.Demo();
            TraversingMatrix.Demo();
            PracticeExercises.Demo();

            Console.WriteLine("===== END =====");

            Console.ReadKey();
        }
    }
}