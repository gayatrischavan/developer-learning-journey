using System;

namespace RandomClassDemo
{
    class RandomRange
    {
        public static void Demo()
        {
            Console.WriteLine("===== Random.Next(min, max) =====");

            Random random = new Random();

            // min is inclusive, max is EXCLUSIVE.
            // random.Next(1, 10) can produce 1 through 9, never 10.
            int number = random.Next(1, 10);
            Console.WriteLine($"Next(1, 10) -> {number}  (possible: 1-9, never 10)");

            // Practical example: simulating a dice roll (1 to 6).
            // 7 is exclusive, so 7 itself is never produced.
            int diceRoll = random.Next(1, 7);
            Console.WriteLine($"Dice Roll Next(1, 7) -> {diceRoll}  (possible: 1-6, never 7)");

            // The output above is not guaranteed or fixed - it changes on every run.
            Console.WriteLine();
        }
    }
}
