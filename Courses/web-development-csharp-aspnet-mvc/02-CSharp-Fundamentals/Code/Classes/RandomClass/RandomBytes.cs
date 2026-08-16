using System;

namespace RandomClassDemo
{
    class RandomBytes
    {
        public static void Demo()
        {
            Console.WriteLine("===== Random.NextBytes() =====");

            Random random = new Random();

            // Creating the byte array first - NextBytes() does not create it.
            byte[] bytes = new byte[5];

            // Passing the array to NextBytes().
            // NextBytes() fills the EXISTING array in place and returns void:
            //     byte[] result = random.NextBytes(bytes); // this would NOT compile
            random.NextBytes(bytes);

            // Each byte now holds a pseudo-random value from 0 to 255.
            Console.Write("Random Bytes : ");
            foreach (byte b in bytes)
            {
                Console.Write($"{b} ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
