using System;

namespace MathClassDemo
{
    class MathRound
    {
        public static void Demo()
        {
            Console.WriteLine("===== Math.Round() vs Math.Ceiling() vs Math.Floor() =====");

            // Math.Round() - nearest whole number
            Console.WriteLine($"Math.Round(10.4) : {Math.Round(10.4)}"); // 10
            Console.WriteLine($"Math.Round(10.6) : {Math.Round(10.6)}"); // 11

            // Midpoint (.5) behavior: default Math.Round() uses "banker's rounding"
            // (MidpointRounding.ToEven) - it rounds to the nearest EVEN number.
            // Do NOT assume .5 always rounds upward.
            Console.WriteLine($"Math.Round(10.5) : {Math.Round(10.5)}"); // 10 (rounds down to even)
            Console.WriteLine($"Math.Round(11.5) : {Math.Round(11.5)}"); // 12 (rounds up to even)

            // Math.Ceiling() - always toward POSITIVE infinity (up)
            Console.WriteLine($"Math.Ceiling(10.2)  : {Math.Ceiling(10.2)}");  // 11
            Console.WriteLine($"Math.Ceiling(-10.2) : {Math.Ceiling(-10.2)}"); // -10 (not -11)

            // Math.Floor() - always toward NEGATIVE infinity (down)
            Console.WriteLine($"Math.Floor(10.8)  : {Math.Floor(10.8)}");   // 10
            Console.WriteLine($"Math.Floor(-10.8) : {Math.Floor(-10.8)}");  // -11 (not -10)

            Console.WriteLine();
        }
    }
}
