using System;

namespace OperatorsDemo
{
    class ArithmeticOperators
    {
        public static void Demo()
        {
            Console.WriteLine("===== Arithmetic Operators =====");

            int a = 20;
            int b = 10;

            Console.WriteLine($"Addition       : {a + b}");
            Console.WriteLine($"Subtraction    : {a - b}");
            Console.WriteLine($"Multiplication : {a * b}");
            Console.WriteLine($"Division       : {a / b}");
            Console.WriteLine($"Modulus        : {a % b}");

            Console.WriteLine();
        }
    }
}