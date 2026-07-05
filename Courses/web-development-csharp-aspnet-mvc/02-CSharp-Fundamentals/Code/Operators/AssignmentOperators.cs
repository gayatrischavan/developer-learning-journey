using System;

namespace OperatorsDemo
{
    class AssignmentOperators
    {
        public static void Demo()
        {
            Console.WriteLine("===== Assignment Operators =====");

            int number = 10;

            number += 5;
            Console.WriteLine($"+=  : {number}");

            number -= 3;
            Console.WriteLine($"-=  : {number}");

            number *= 2;
            Console.WriteLine($"*=  : {number}");

            number /= 4;
            Console.WriteLine($"/=  : {number}");

            Console.WriteLine();
        }
    }
}