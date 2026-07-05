using System;

namespace OperatorsDemo
{
    class OperatorPrecedence
    {
        public static void Demo()
        {
            Console.WriteLine("===== Operator Precedence =====");

            int result = 10 + 5 * 2;

            Console.WriteLine($"10 + 5 * 2 = {result}");

            result = (10 + 5) * 2;

            Console.WriteLine($"(10 + 5) * 2 = {result}");

            Console.WriteLine();
        }
    }
}