//In C# 11, one of the new features introduced is the ability to pattern match Span<char> and ReadOnlySpan<char> against
//constant strings directly in switch expressions or if statements. This enhancement simplifies working with spans by allowing
//pattern matching operations that were previously only possible with string types. It's particularly useful
//for high-performance scenarios where avoiding string allocations is crucial, such as parsing or processing large
//text data efficiently.

//Here's an example of a C# Console Application that demonstrates how to pattern match ReadOnlySpan<char> on a constant string.
//This example will parse a command input and use pattern matching to determine the action to be performed.

using System;

//FIRST SAMPLE

// Simulate input command as a span from a larger text or input buffer
ReadOnlySpan<char> command = "update".AsSpan();

// Use pattern matching with span on constant strings
string result = command switch
{
    "update" => "Updating...",
    "delete" => "Deleting...",
    "create" => "Creating...",
    _ => "Unknown command"
};

Console.WriteLine(result);

// Demonstrating if statement usage
if (command == "update")
{
    Console.WriteLine("Confirmed: Updating...");
}
else
{
    Console.WriteLine("This block won't execute for the given command.");
}

//SECOND SAMPLE

// Simulating a command string that might be part of a larger text
string commandText = "/command:edit";
ReadOnlySpan<char> commandSpan = commandText.AsSpan();

// Extract the command keyword after "/command:" without allocating a new string
ReadOnlySpan<char> keyword = commandSpan.Slice("/command:".Length);

// Use pattern matching with ReadOnlySpan<char> on constant strings
ProcessCommand(keyword);

static void ProcessCommand(ReadOnlySpan<char> commandKeyword)
{
    switch (commandKeyword)
    {
        case "edit":
            Console.WriteLine("Edit command selected.");
            // Add further edit command handling here
            break;
        case "view":
            Console.WriteLine("View command selected.");
            // Add further view command handling here
            break;
        case "delete":
            Console.WriteLine("Delete command selected.");
            // Add further delete command handling here
            break;
        default:
            Console.WriteLine($"Unknown command: {commandKeyword.ToString()}");
            break;
    }
}