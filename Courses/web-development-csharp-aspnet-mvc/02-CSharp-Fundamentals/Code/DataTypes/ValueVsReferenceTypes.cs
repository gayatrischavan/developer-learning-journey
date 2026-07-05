using System;

namespace DataTypesDemo
{
    class ValueVsReferenceTypes
    {
        public static void Run()
        {
            Console.WriteLine("===== Value Type Example =====");

            int x = 10;
            int y = x;

            y = 20;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            Console.WriteLine();

            Console.WriteLine("===== Reference Type Example =====");

            string firstName = "Gayatri";
            string secondName = firstName;

            secondName = "Sakshi";

            Console.WriteLine($"First Name  : {firstName}");
            Console.WriteLine($"Second Name : {secondName}");
        }
    }
}