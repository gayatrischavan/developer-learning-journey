using System;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== ARRAYS DEMO ==========\n");

            ArrayDeclaration.Demo();
            ArrayInitialization.Demo();
            AccessElements.Demo();
            UpdateElements.Demo();
            ArrayLength.Demo();
            LoopThroughArray.Demo();
            ArrayMethods.Demo();
            SearchingArray.Demo();
            SortingArray.Demo();
            CopyArray.Demo();
            ReverseArray.Demo();
            PracticeExercises.Demo();

            Console.WriteLine("========== END ==========");

            Console.ReadKey();
        }
    }
}