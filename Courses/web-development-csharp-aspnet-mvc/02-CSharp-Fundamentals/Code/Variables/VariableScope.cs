using System;

namespace VariablesDemo
{
    class VariableScope
    {
        public static void Run()
        {
            int localVariable = 100;

            Console.WriteLine("Inside Method");
            Console.WriteLine(localVariable);
        }
    }
}