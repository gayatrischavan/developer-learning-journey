using System;

namespace RandomClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== RANDOM CLASS DEMO ==========\n");

            RandomNumbers.Demo();
            RandomRange.Demo();
            RandomDouble.Demo();
            RandomBytes.Demo();
            RandomPassword.Demo();
            PracticeExercises.Demo();

            // ------------------------------------------------------
            // Complete Random example, all using ONE Random instance
            // Create -> Next() -> Next(min, max) -> NextDouble() -> NextBytes() -> Random string
            // ------------------------------------------------------
            Console.WriteLine("===== Complete Random Example =====");

            Random random = new Random();

            int number = random.Next();
            Console.WriteLine($"Next()               : {number}");

            int rangedNumber = random.Next(1, 10);
            Console.WriteLine($"Next(1, 10)          : {rangedNumber}  (never 10)");

            double doubleValue = random.NextDouble();
            Console.WriteLine($"NextDouble()         : {doubleValue}  (never 1.0)");

            byte[] bytes = new byte[5];
            random.NextBytes(bytes);
            Console.Write("NextBytes()          : ");
            foreach (byte b in bytes)
            {
                Console.Write($"{b} ");
            }
            Console.WriteLine();

            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string randomString = "";
            for (int i = 0; i < 5; i++)
            {
                int index = random.Next(0, characters.Length);
                randomString += characters[index];
            }
            Console.WriteLine($"Random String        : {randomString}");

            Console.WriteLine("\n========== END ==========");

            Console.ReadKey();
        }
    }
}
