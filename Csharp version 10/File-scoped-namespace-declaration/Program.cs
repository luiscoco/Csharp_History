
//File - scoped namespace declarations, introduced in C# 10 as part of .NET 6, allow for a cleaner and more concise
//way to define namespaces that span an entire file. Traditionally, namespace declarations in C# required you to wrap
//all namespace members in curly braces, leading to an additional level of indentation for the entire file. File-scoped
//namespaces streamline this by applying the namespace to all type definitions in the file without the need for braces,
//reducing nesting and making the code more readable.

//In this example, the namespace FileScopedNamespaceDemo; line at the top of the file applies to all type definitions
//in the file.This means both the Program class and the Greeter class are part of the FileScopedNamespaceDemo namespace
//without needing to be wrapped in braces.

// Program.cs
namespace FileScopedNamespaceDemo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var greeter = new Greeter();
        greeter.Greet();
    }
}

class Greeter
{
    public void Greet()
    {
        Console.WriteLine("Greetings from FileScopedNamespaceDemo.Greeter!");
    }
}
