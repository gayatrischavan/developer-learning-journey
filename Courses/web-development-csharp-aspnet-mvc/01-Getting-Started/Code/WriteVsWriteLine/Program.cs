using System;

namespace WriteVsWriteLineDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Console.Write() vs Console.WriteLine() ===\n");

            WriteExample.Run();

            Console.WriteLine();

            WriteLineExample.Run();

            Console.WriteLine();

            ComparisonExample.Run();

            Console.ReadKey();
        }
    }
}