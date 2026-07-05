using System;

namespace OperatorsDemo
{
    class BitwiseOperators
    {
        public static void Demo()
        {
            Console.WriteLine("===== Bitwise Operators =====");

            int a = 5;
            int b = 3;

            Console.WriteLine($"a & b = {a & b}");
            Console.WriteLine($"a | b = {a | b}");
            Console.WriteLine($"a ^ b = {a ^ b}");
            Console.WriteLine($"~a    = {~a}");

            Console.WriteLine();
        }
    }
}