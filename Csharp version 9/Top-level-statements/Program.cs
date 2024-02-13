
//Top - level statements in C# 9 simplify the coding for small programs and scripts by reducing the boilerplate code
//traditionally required in C# applications. This feature makes it easier to get started with C# programs, as you no
//longer need to define a class and a Main method for the entry point of your application. It's particularly useful for
//teaching, scripting, or writing simple console applications.

//in this simple program, we're directly writing the code that would traditionally go inside the Main method.
//The compiler implicitly generates the Main method for us.

// This is a top-level statement
Console.WriteLine("Hello, World from Top-Level Statements!");

// You can even define variables and logic directly
var names = new[] { "Alice", "Bob", "Charlie" };
foreach (var name in names)
{
    Console.WriteLine($"Hello, {name}!");
}
