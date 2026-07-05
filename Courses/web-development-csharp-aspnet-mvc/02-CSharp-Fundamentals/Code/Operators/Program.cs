using System;

namespace OperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== C# Operators ==========\n");

            ArithmeticOperators.Demo();
            AssignmentOperators.Demo();
            ComparisonOperators.Demo();
            LogicalOperators.Demo();
            UnaryOperators.Demo();
            TernaryOperator.Demo();
            BitwiseOperators.Demo();
            OperatorPrecedence.Demo();

            Console.ReadKey();
        }
    }
}