//Init - only setters introduced in C# 9, part of .NET 5, provide a way to make properties immutable after object
//construction. This feature enhances the immutability capabilities of C#, allowing for the creation of objects whose
//properties can be set at the time of initialization but remain read-only thereafter. Init-only setters contribute
//to the safety and predictability of your code by ensuring that objects cannot be inadvertently modified after
//they've been fully constructed.

// Initialize a new Person object
var person = new Person
{
    Name = "John Doe",
    Age = 30
};

Console.WriteLine($"Person created: {person.Name}, Age: {person.Age}");

// The following line would raise a compile-time error because of init-only setters
// person.Name = "Jane Doe";

public class Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}