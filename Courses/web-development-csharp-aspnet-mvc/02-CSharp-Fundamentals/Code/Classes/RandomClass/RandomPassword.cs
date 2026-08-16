using System;

namespace RandomClassDemo
{
    class RandomPassword
    {
        public static void Demo()
        {
            Console.WriteLine("===== Random Password (LEARNING EXAMPLE ONLY) =====");

            // IMPORTANT: This is only a learning example for practicing
            // Random and string building. It is NOT secure and must NOT be
            // used for real authentication, tokens, or production passwords.
            // Security-sensitive password/token generation should use a
            // proper cryptographic API, such as System.Security.Cryptography,
            // not ordinary System.Random.

            Random random = new Random();

            // Character set: uppercase letters + lowercase letters + numbers
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            string password = "";

            for (int i = 0; i < 8; i++)
            {
                // Random index -> Random character -> append -> repeat
                int index = random.Next(0, characters.Length);
                char character = characters[index];
                password += character;
            }

            Console.WriteLine($"Generated Password (educational only) : {password}");
            Console.WriteLine();
        }
    }
}
