using System;

namespace TypeConversionDemo
{
    internal class PracticeExercises
    {
        public static void Exercise1()
        {
            int number = 50;

            double value = number;

            Console.WriteLine(value);
        }

        public static void Exercise2()
        {
            double marks = 78.99;

            int total = (int)marks;

            Console.WriteLine(total);
        }

        public static void Exercise3()
        {
            string age = "25";

            int number = int.Parse(age);

            Console.WriteLine(number);
        }

        public static void Exercise4()
        {
            Console.Write("Enter Age: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                Console.WriteLine($"Age = {age}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public static void Exercise5()
        {
            char letter = 'Z';

            int ascii = letter;

            Console.WriteLine(ascii);
        }
    }
}