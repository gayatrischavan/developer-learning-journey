using System;

namespace MathClassDemo
{
    class MathBasicMethods
    {
        public static void Demo()
        {
            Console.WriteLine("===== Math Constants and Basic Methods =====");

            // Constants
            Console.WriteLine($"Math.PI : {Math.PI}");
            Console.WriteLine($"Math.E  : {Math.E}");

            // Math.Abs() - absolute (non-negative) value
            Console.WriteLine($"Math.Abs(-10) : {Math.Abs(-10)}");
            Console.WriteLine($"Math.Abs(10)  : {Math.Abs(10)}");

            // Math.Min() - the smaller of two values
            Console.WriteLine($"Math.Min(10, 20) : {Math.Min(10, 20)}");

            // Math.Max() - the larger of two values
            Console.WriteLine($"Math.Max(10, 20) : {Math.Max(10, 20)}");

            Console.WriteLine();
        }
    }
}
