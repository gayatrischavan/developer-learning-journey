using System;

namespace TypeConversionDemo
{
    internal class ImplicitConversion
    {
        public static void Demo()
        {
            Console.WriteLine("----- Implicit Conversion -----");

            int number = 25;

            double value = number;

            Console.WriteLine($"Integer : {number}");
            Console.WriteLine($"Double  : {value}");

            char letter = 'A';
            int ascii = letter;

            Console.WriteLine($"Character : {letter}");
            Console.WriteLine($"ASCII Code: {ascii}");

            Console.WriteLine();
        }
    }
}