using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Step 1: Main Method Started");

        DisplayMessage();

        Console.WriteLine("Step 3: Program Finished");
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Step 2: Inside DisplayMessage()");
    }
}