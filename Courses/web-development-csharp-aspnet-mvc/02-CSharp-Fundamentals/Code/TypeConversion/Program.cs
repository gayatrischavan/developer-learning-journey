using System;

namespace TypeConversionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== TYPE CONVERSION DEMO ======\n");

            ImplicitConversion.Demo();
            ExplicitConversion.Demo();
            ConvertClass.Demo();
            ParseVsTryParse.Demo();
            BoxingUnboxing.Demo();

            Console.ReadKey();
        }
    }
}