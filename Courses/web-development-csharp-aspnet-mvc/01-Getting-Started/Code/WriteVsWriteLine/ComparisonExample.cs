using System;

namespace WriteVsWriteLineDemo
{
    class ComparisonExample
    {
        public static void Run()
        {
            Console.WriteLine("Comparison");

            Console.Write("Using Write(): ");
            Console.Write("A ");
            Console.Write("B ");
            Console.Write("C");

            Console.WriteLine();

            Console.WriteLine("Using WriteLine():");
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.WriteLine("C");
        }
    }
}