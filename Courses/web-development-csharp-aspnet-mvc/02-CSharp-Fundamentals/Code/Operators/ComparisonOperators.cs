using System;

namespace OperatorsDemo
{
    class ComparisonOperators
    {
        public static void Demo()
        {
            Console.WriteLine("===== Comparison Operators =====");

            int x = 10;
            int y = 20;

            Console.WriteLine($"x == y : {x == y}");
            Console.WriteLine($"x != y : {x != y}");
            Console.WriteLine($"x > y  : {x > y}");
            Console.WriteLine($"x < y  : {x < y}");
            Console.WriteLine($"x >= y : {x >= y}");
            Console.WriteLine($"x <= y : {x <= y}");

            Console.WriteLine();
        }
    }
}