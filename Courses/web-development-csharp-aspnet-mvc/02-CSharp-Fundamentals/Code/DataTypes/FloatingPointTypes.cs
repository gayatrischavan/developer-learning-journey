using System;

namespace DataTypesDemo
{
    class FloatingPointTypes
    {
        public static void Run()
        {
            float pi = 3.14f;
            double percentage = 95.75;
            decimal amount = 5000.99m;

            Console.WriteLine("===== Floating Point Types =====");

            Console.WriteLine($"Float      : {pi}");
            Console.WriteLine($"Double     : {percentage}");
            Console.WriteLine($"Decimal    : {amount}");
        }
    }
}