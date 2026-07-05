using System;

namespace DataTypesDemo
{
    class PracticeExercises
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Practice Exercises ==========\n");

            // ======================================================
            // Exercise 1
            // ======================================================

            Console.WriteLine("Exercise 1: Personal Information");

            string name = "Gayatri";
            int age = 23;
            string city = "Pune";

            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age  : {age}");
            Console.WriteLine($"City : {city}");

            Console.WriteLine();

            // ======================================================
            // Exercise 2
            // ======================================================

            Console.WriteLine("Exercise 2: Student Details");

            string studentName = "Rahul";
            int rollNo = 101;
            char grade = 'A';
            bool isPassed = true;

            Console.WriteLine($"Student : {studentName}");
            Console.WriteLine($"Roll No : {rollNo}");
            Console.WriteLine($"Grade   : {grade}");
            Console.WriteLine($"Passed  : {isPassed}");

            Console.WriteLine();

            // ======================================================
            // Exercise 3
            // ======================================================

            Console.WriteLine("Exercise 3: Product Details");

            string productName = "Laptop";
            decimal price = 65000.50m;
            int quantity = 2;

            decimal totalAmount = price * quantity;

            Console.WriteLine($"Product : {productName}");
            Console.WriteLine($"Price   : {price}");
            Console.WriteLine($"Qty     : {quantity}");
            Console.WriteLine($"Total   : {totalAmount}");

            Console.WriteLine();

            // ======================================================
            // Exercise 4
            // ======================================================

            Console.WriteLine("Exercise 4: Bank Account");

            string accountHolder = "Gayatri";
            decimal balance = 25000.75m;
            bool isActive = true;

            Console.WriteLine($"Account Holder : {accountHolder}");
            Console.WriteLine($"Balance        : {balance}");
            Console.WriteLine($"Active         : {isActive}");

            Console.WriteLine();

            // ======================================================
            // Exercise 5
            // ======================================================

            Console.WriteLine("Exercise 5: Temperature");

            double temperature = 36.8;

            Console.WriteLine($"Temperature : {temperature} °C");

            Console.WriteLine();

            Console.WriteLine("========== End of Practice ==========");

            Console.ReadKey();
        }
    }
}