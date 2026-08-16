using System;

namespace RandomClassDemo
{
    class RandomNumbers
    {
        public static void Demo()
        {
            Console.WriteLine("===== Random.Next() =====");

            // Creating a single Random object
            Random random = new Random();

            // Generating a non-negative random integer
            int number = random.Next();
            Console.WriteLine($"Random Number 1 : {number}");

            // Reusing the SAME Random object for more values.
            // A new Random object is NOT created for every number.
            int number2 = random.Next();
            int number3 = random.Next();

            Console.WriteLine($"Random Number 2 : {number2}");
            Console.WriteLine($"Random Number 3 : {number3}");

            // The exact values above will differ on every run.
            Console.WriteLine();
        }
    }
}
