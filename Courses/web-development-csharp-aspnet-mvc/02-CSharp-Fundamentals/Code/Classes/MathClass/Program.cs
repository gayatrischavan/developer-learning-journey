using System;

namespace MathClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== MATH CLASS DEMO ==========\n");

            MathBasicMethods.Demo();
            MathPower.Demo();
            MathSqrt.Demo();
            MathRound.Demo();
            PracticeExercises.Demo();

            // ------------------------------------------------------
            // Consolidated Math example
            // ------------------------------------------------------
            Console.WriteLine("===== Consolidated Math Example =====");

            Console.WriteLine($"Math.PI              : {Math.PI}");
            Console.WriteLine($"Math.E               : {Math.E}");

            Console.WriteLine($"Math.Abs(-10)        : {Math.Abs(-10)}");
            Console.WriteLine($"Math.Min(10, 20)     : {Math.Min(10, 20)}");
            Console.WriteLine($"Math.Max(10, 20)     : {Math.Max(10, 20)}");

            Console.WriteLine($"Math.Pow(2, 3)       : {Math.Pow(2, 3)}");
            Console.WriteLine($"Math.Sqrt(25)        : {Math.Sqrt(25)}");

            Console.WriteLine($"Math.Round(10.5)     : {Math.Round(10.5)}");
            Console.WriteLine($"Math.Ceiling(10.2)   : {Math.Ceiling(10.2)}");
            Console.WriteLine($"Math.Floor(10.8)     : {Math.Floor(10.8)}");

            Console.WriteLine("\n========== END ==========");

            Console.ReadKey();
        }
    }
}
