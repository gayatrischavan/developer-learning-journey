using System;

namespace VariablesDemo
{
    class Constants
    {
        public static void Run()
        {
            const double PI = 3.14159;

            Console.WriteLine("Value of PI");
            Console.WriteLine(PI);

            // PI = 3.14; // This will cause a compile-time error.
        }
    }
}