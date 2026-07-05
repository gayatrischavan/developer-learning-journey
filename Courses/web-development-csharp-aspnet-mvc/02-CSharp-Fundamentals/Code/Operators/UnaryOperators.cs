using System;

namespace OperatorsDemo
{
    class UnaryOperators
    {
        public static void Demo()
        {
            Console.WriteLine("===== Unary Operators =====");

            int number = 10;

            Console.WriteLine($"Original : {number}");

            Console.WriteLine($"++number : {++number}");

            Console.WriteLine($"number++ : {number++}");

            Console.WriteLine($"After    : {number}");

            Console.WriteLine($"--number : {--number}");

            Console.WriteLine();
        }
    }
}