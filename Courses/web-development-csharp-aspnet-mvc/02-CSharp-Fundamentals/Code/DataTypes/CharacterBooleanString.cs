using System;

namespace DataTypesDemo
{
    class CharacterBooleanString
    {
        public static void Run()
        {
            char grade = 'A';
            bool isPassed = true;
            string studentName = "Gayatri";

            Console.WriteLine("===== Character, Boolean and String =====");

            Console.WriteLine($"Grade      : {grade}");
            Console.WriteLine($"Passed     : {isPassed}");
            Console.WriteLine($"Student    : {studentName}");
        }
    }
}