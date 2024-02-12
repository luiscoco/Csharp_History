//In C# 11, the scope of the nameof expression has been extended to allow it to access more than just accessible symbols.
//This means you can now use nameof with private or otherwise inaccessible members of other types, among other enhancements.
//This feature can be particularly useful for logging, exception messages, or data binding, where you want to reference
//a member name without hard-coding a string that could become outdated if the member's name changes during refactoring.

//Below is a simple example of a C# Console Application that demonstrates the extended scope of the nameof expression in C# 11.
//This example will include two classes to illustrate how nameof can now be used with members that are not directly accessible
//in the current context.

using System;

EmployeeLogger.LogPropertyAccess();


public class Employee
{
    public string EmployeeId { get; set; } = "E12345";

    // Imagine other properties and methods here
}

public class EmployeeLogger
{
    public static void LogPropertyAccess()
    {
        // Using nameof with a property that is not accessible in this context
        // This was not allowed in earlier versions of C# but is now possible in C# 11
        Console.WriteLine($"Accessing property: {nameof(Employee.EmployeeId)}");
    }
}

