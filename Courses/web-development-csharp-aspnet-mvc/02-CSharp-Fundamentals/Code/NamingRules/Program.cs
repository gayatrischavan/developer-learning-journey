using System;

namespace NamingRulesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Naming Rules Demo ==========\n");

            ValidIdentifiers.Run();

            Console.WriteLine();

            CamelCasePascalCase.Run();

            Console.WriteLine();

            PracticeExercises.Run();

            Console.WriteLine("\n========== End ==========");

            Console.ReadKey();
        }
    }
}