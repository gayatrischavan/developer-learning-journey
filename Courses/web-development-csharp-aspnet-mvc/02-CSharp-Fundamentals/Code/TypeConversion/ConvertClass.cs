using System;

namespace TypeConversionDemo
{
    internal class ConvertClass
    {
        public static void Demo()
        {
            Console.WriteLine("----- Convert Class -----");

            double marks = 89.75;

            int rounded = Convert.ToInt32(marks);

            Console.WriteLine($"Original : {marks}");
            Console.WriteLine($"Rounded  : {rounded}");

            string number = "250";

            int value = Convert.ToInt32(number);

            Console.WriteLine($"Converted String : {value}");

            Console.WriteLine();
        }
    }
}