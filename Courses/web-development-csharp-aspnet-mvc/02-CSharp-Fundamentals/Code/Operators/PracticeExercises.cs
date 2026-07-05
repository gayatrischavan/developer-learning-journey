using System;

namespace OperatorsDemo
{
    class PracticeExercises
    {
        public static void Demo()
        {
            Console.WriteLine("===== Practice Exercises =====");

            // Exercise 1
            int a = 15;
            int b = 4;

            Console.WriteLine($"Addition : {a + b}");
            Console.WriteLine($"Remainder : {a % b}");

            // Exercise 2
            int age = 20;

            Console.WriteLine(age >= 18 ? "Eligible to Vote" : "Not Eligible");

            // Exercise 3
            bool hasLicense = true;
            bool hasHelmet = true;

            Console.WriteLine(hasLicense && hasHelmet);

            Console.WriteLine();
        }
    }
}