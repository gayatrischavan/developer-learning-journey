using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Console Application Demo");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Welcome, {name}!");

        Console.WriteLine("\nThis interaction happens through the Console window.");

        Console.ReadKey();
    }
}