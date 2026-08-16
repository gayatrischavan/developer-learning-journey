using System;

namespace MathClassDemo
{
    class MathSqrt
    {
        public static void Demo()
        {
            Console.WriteLine("===== Math.Sqrt() =====");

            // Math.Sqrt() returns the square root of a value.
            // The return type is double, never int.
            double result1 = Math.Sqrt(25); // 5
            Console.WriteLine($"Math.Sqrt(25) : {result1}");

            double result2 = Math.Sqrt(2); // not a whole number
            Console.WriteLine($"Math.Sqrt(2)  : {result2}");

            Console.WriteLine();
        }
    }
}
