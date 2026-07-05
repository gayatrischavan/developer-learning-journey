using System;

namespace TypeConversionDemo
{
    internal class BoxingUnboxing
    {
        public static void Demo()
        {
            Console.WriteLine("----- Boxing & Unboxing -----");

            int number = 100;

            object obj = number;

            Console.WriteLine($"Boxed Object : {obj}");

            int value = (int)obj;

            Console.WriteLine($"Unboxed Value : {value}");

            Console.WriteLine();
        }
    }
}