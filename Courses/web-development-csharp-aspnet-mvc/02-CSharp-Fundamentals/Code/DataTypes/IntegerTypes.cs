using System;

namespace DataTypesDemo
{
    class IntegerTypes
    {
        public static void Run()
        {
            byte age = 25;
            short marks = 32000;
            int salary = 45000;
            long population = 1450000000;

            Console.WriteLine("===== Integer Types =====");

            Console.WriteLine($"Byte       : {age}");
            Console.WriteLine($"Short      : {marks}");
            Console.WriteLine($"Int        : {salary}");
            Console.WriteLine($"Long       : {population}");
        }
    }
}