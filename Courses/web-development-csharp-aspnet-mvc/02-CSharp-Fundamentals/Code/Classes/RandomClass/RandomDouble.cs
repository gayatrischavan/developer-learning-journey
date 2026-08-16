using System;

namespace RandomClassDemo
{
    class RandomDouble
    {
        public static void Demo()
        {
            Console.WriteLine("===== Random.NextDouble() =====");

            Random random = new Random();

            // NextDouble() returns a value where:
            // 0.0 is inclusive, 1.0 is EXCLUSIVE.
            double value = random.NextDouble();
            Console.WriteLine($"NextDouble() -> {value}  (range: 0.0 <= value < 1.0)");

            // Scaling the result to a wider range.
            // This produces a value from 0.0 up to, but not including, 100.0.
            double scaledValue = random.NextDouble() * 100;
            Console.WriteLine($"NextDouble() * 100 -> {scaledValue}  (range: 0.0 <= value < 100.0)");

            Console.WriteLine();
        }
    }
}
