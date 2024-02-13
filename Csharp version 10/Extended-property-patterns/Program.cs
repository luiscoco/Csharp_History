//Extended property patterns in C# 10, part of .NET 6, enhance the capabilities of pattern matching by allowing deeper
//inspection of object properties directly within a pattern. This feature makes pattern matching more expressive and concise,
//particularly when you need to match against nested properties of an object.

//To demonstrate extended property patterns, I'll provide an example of a console application that models a simple scenario.
//We'll create a model of a Person who has an Address, and we'll use extended property patterns to check if the person lives
//in a specific city without needing to explicitly navigate the properties in a nested manner.

namespace ExtendedPropertyPatternsDemo;

class Program
{
    static void Main(string[] args)
    {
        var person = new Person
        {
            Name = "John Doe",
            Address = new Address { City = "New York", Country = "USA" }
        };

        // Using extended property patterns to check the person's city
        if (person is { Address.City: "New York" })
        {
            Console.WriteLine($"{person.Name} lives in New York.");
        }
        else
        {
            Console.WriteLine($"{person.Name} does not live in New York.");
        }
    }
}


public class Person
{
    public string Name { get; set; }
    public Address Address { get; set; }
}

public class Address
{
    public string City { get; set; }
    public string Country { get; set; }
}
