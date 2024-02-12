using System;


//In C# 11, a new feature called "auto-default structs" was introduced, allowing structs to be automatically
//initialized to their default values without the need for a parameterless constructor. This feature ensures that all
//fields of the struct, whether they are reference types or value types, are initialized to their default values,
//improving safety and convenience in struct handling.

//Here's a simple example of a C# Console Application that demonstrates the use of auto-default structs.
//This example will define a struct with several fields and show how instances of this struct are automatically
//initialized with default values.


namespace AutoDefaultStructsDemo
{
    // Define a struct with various fields
    public struct MyStruct
    {
        public int Number;
        public string? Text; // Nullable reference type to demonstrate defaulting to null
        public DateTime Date;

        // In C# 11, explicit parameterless constructors for structs are allowed but not required for auto-defaulting.
        // public MyStruct() { } // This is optional in C# 11 due to auto-default feature.
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MyStruct without initializing fields
            MyStruct myStruct = new();

            // Display the default values of the fields
            Console.WriteLine($"Number: {myStruct.Number}"); // Expected to output 0
            Console.WriteLine($"Text: {myStruct.Text}"); // Expected to output null
            Console.WriteLine($"Date: {myStruct.Date}"); // Expected to output DateTime.MinValue

            // In C# 11, this struct instance `myStruct` is automatically initialized with default values for its fields,
            // without needing to define a parameterless constructor explicitly.
        }
    }
}
