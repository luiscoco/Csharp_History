using System;

//In C# 11, the concept of "required members" was introduced to make it easier to ensure that certain properties or fields
//are initialized when an object is created. This feature helps developers avoid common mistakes related to uninitialized
//members, enhancing code safety and readability. A "required" member must be explicitly assigned a value when the objec
//t is instantiated, either through an object initializer or a constructor, helping to ensure that objects are always
//in a valid state.

//Here's a simple example of a C# Console Application that demonstrates the use of required members.
//The example will define a class with required properties and show how to instantiate objects of that class,
//ensuring required properties are assigned.

namespace RequiredMembersDemo
{
    public class Person
    {
        // Required property
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        // Optional property
        public string? MiddleName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a Person object with all required properties
            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };

            Console.WriteLine($"Person: {person.FirstName} {person.LastName}");

            // Uncommenting the following lines will result in a compile-time error
            // because the required properties are not assigned.
            // var personWithoutRequired = new Person();
        }
    }
}
