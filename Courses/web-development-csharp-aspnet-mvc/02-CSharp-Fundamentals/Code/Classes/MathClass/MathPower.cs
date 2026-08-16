using System;

namespace MathClassDemo
{
    class MathPower
    {
        public static void Demo()
        {
            Console.WriteLine("===== Math.Pow() =====");

            // Math.Pow(base, exponent) -> base raised to the power of exponent.
            // Math.Pow() always returns a double, never an int.
            double result1 = Math.Pow(2, 3); // 2^3 = 8
            Console.WriteLine($"Math.Pow(2, 3) : {result1}");

            double result2 = Math.Pow(5, 2); // 5^2 = 25
            Console.WriteLine($"Math.Pow(5, 2) : {result2}");

            Console.WriteLine();
        }
    }
}
