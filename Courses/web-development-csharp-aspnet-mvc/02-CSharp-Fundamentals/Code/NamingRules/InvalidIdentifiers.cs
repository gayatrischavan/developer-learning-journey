using System;

namespace NamingRulesDemo
{
    class InvalidIdentifiers
    {
        public static void Run()
        {
            Console.WriteLine("===== Invalid Identifier Examples =====");

            Console.WriteLine("The following identifiers are INVALID in C#:");

            /*
                int 123age = 20;          // Starts with number

                int student age = 25;     // Contains space

                int class = 10;           // Reserved keyword

                int salary$ = 5000;       // Special character

                int employee-name = 10;   // Hyphen not allowed
            */

            Console.WriteLine("- 123age");
            Console.WriteLine("- student age");
            Console.WriteLine("- class");
            Console.WriteLine("- salary$");
            Console.WriteLine("- employee-name");

            Console.WriteLine();
            Console.WriteLine("Use meaningful and valid identifiers instead.");
        }
    }
}