using System;

namespace TypeConversionDemo
{
    internal class ParseVsTryParse
    {
        public static void Demo()
        {
            Console.WriteLine("----- Parse vs TryParse -----");

            string ageText = "24";

            int age = int.Parse(ageText);

            Console.WriteLine($"Parse Result : {age}");

            string input = "ABC";

            bool success = int.TryParse(input, out int result);

            Console.WriteLine($"TryParse Success : {success}");
            Console.WriteLine($"Result           : {result}");

            Console.WriteLine();
        }
    }
}