using System;

namespace ListPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Using list pattern in a switch expression
            string result = numbers switch
            {
                // Matches if the array starts with 1, followed by any number of elements, and ends with 5
                [1, .., 5] => "Starts with 1 and ends with 5",

                // Matches if the array starts with 2
                [2, ..] => "Starts with 2",

                // Default case
                _ => "Does not match any pattern"
            };

            Console.WriteLine(result);
        }
    }
}
