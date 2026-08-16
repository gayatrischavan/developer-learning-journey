using System;

namespace ClassAndObjectDemo
{
    class EmployeeAge
    {
        private int age;

        public int Age
        {
            get
            {
                // "get" runs whenever the property is READ.
                Console.WriteLine("Get accessor called.");
                return age;
            }
            set
            {
                // "set" runs whenever the property is ASSIGNED.
                // "value" holds the data being assigned.
                Console.WriteLine("Set accessor called.");
                age = value;
            }
        }
    }

    class GetSet
    {
        public static void Demo()
        {
            Console.WriteLine("===== Get and Set =====");

            EmployeeAge emp = new EmployeeAge();

            // Assigning a value -> triggers "set"
            emp.Age = 28;

            // Reading a value -> triggers "get"
            Console.WriteLine($"Age : {emp.Age}");

            Console.WriteLine();
        }
    }
}
