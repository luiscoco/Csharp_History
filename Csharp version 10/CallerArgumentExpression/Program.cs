//The CallerArgumentExpression attribute introduced in C# 10 enables developers to capture the expressions passed
//to methods at the call site as strings. This feature is particularly useful for creating more informative diagnostic
//messages, assertions, or validation logic without manually duplicating the expression as a string argument.
//It can automatically provide the expression used in the caller, improving the debugging experience and making
//the code more readable.

//To demonstrate the CallerArgumentExpression attribute, we'll create a console application that includes a method
//leveraging this attribute to print the expression passed to it. This example will help illustrate how the attribute
//can be used for logging or validation purposes.

using System.Runtime.CompilerServices;

int x = 5;
int y = 0;
ValidateArgument(y != 0, nameof(y));

static void ValidateArgument(bool condition, string paramName, [CallerArgumentExpression("condition")] string? conditionExpression = null)
{
    if (!condition)
    {
        Console.WriteLine($"Validation failed for argument '{paramName}', condition: {conditionExpression}");
        // In a real-world scenario, you might throw an exception here
        // throw new ArgumentException($"Validation failed for argument '{paramName}', condition: {conditionExpression}");
    }
    else
    {
        Console.WriteLine("Validation succeeded.");
    }
}
