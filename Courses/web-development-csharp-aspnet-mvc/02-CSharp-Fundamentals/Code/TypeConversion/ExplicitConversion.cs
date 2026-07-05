using System;

namespace TypeConversionDemo
{
    internal class ExplicitConversion
    {
        public static void Demo()
        {
            Console.WriteLine("----- Explicit Conversion -----");

            double price = 199.95;

            int amount = (int)price;

            Console.WriteLine($"Original Value : {price}");
            Console.WriteLine($"After Casting  : {amount}");

            Console.WriteLine();
        }
    }
}