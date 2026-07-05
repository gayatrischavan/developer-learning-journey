using System;

class Program
{
    static void Main()
    {
        Console.Title = "Common Console Methods";

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to C#");
        Console.ResetColor();

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Hello, {name}");

        Console.Beep();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}