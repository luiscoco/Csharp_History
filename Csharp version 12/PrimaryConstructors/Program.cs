using System;

public class Person(string firstName, string lastName)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new Person object
        Person person = new Person("John", "Doe");

        // Print the person's name to the console
        Console.WriteLine($"Hello, {person.FirstName} {person.LastName}!");
    }
}
