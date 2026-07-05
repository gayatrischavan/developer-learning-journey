using System;

namespace OperatorsDemo
{
    class TernaryOperator
    {
        public static void Demo()
        {
            Console.WriteLine("===== Ternary Operator =====");

            int marks = 75;

            string result = (marks >= 40) ? "Pass" : "Fail";

            Console.WriteLine($"Result : {result}");

            Console.WriteLine();
        }
    }
}