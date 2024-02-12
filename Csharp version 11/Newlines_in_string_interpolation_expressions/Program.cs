using System;

namespace NewlineInterpolationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";

            // Using newlines directly in string interpolation
            string greeting = $"""
                Hello, 
                {firstName} {lastName}!
                Welcome to C# 11.
                """;

            Console.WriteLine(greeting);
        }
    }
}
