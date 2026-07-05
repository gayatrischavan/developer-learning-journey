using System;

namespace OperatorsDemo
{
    class LogicalOperators
    {
        public static void Demo()
        {
            Console.WriteLine("===== Logical Operators =====");

            bool isAdmin = true;
            bool isLoggedIn = false;

            Console.WriteLine($"AND (&&): {isAdmin && isLoggedIn}");
            Console.WriteLine($"OR (||): {isAdmin || isLoggedIn}");
            Console.WriteLine($"NOT (!): {!isAdmin}");

            Console.WriteLine();
        }
    }
}