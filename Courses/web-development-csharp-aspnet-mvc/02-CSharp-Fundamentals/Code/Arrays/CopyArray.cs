using System;

namespace ArraysDemo
{
    class CopyArray
    {
        public static void Demo()
        {
            Console.WriteLine("===== Copy Array =====");

            int[] source = { 10, 20, 30, 40, 50 };

            int[] destination = new int[source.Length];

            Array.Copy(source, destination, source.Length);

            Console.WriteLine("Copied Array");

            foreach (int number in destination)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}