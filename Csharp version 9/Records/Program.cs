//EXAMPLE 1

// Create two record instances
using System;

var person1 = new Person("John", "Doe", 30);
var person2 = new Person("John", "Doe", 30);

// Demonstrate value-based equality
Console.WriteLine($"Person1 == Person2? {person1 == person2}");

// Demonstrate with-expression for non-destructive mutation
var person3 = person1 with { Age = 31 };
Console.WriteLine($"Person1 == Person3? {person1 == person3}");
Console.WriteLine($"Person3: {person3}");

//EXAMPLE 2

var myCar = new Car("Toyota", "Corolla", 2021);

// Using the overridden Describe method
Console.WriteLine(myCar.Describe());

// Demonstrating deconstruction
var (make, model, year) = myCar;
Console.WriteLine($"Deconstructed: {make}, {model}, {year}");

// Demonstrating polymorphism with records
Vehicle myVehicle = myCar;
myVehicle.DisplayDescription();

//--------------------------------------------------------------------------------------------

// Define a record
public record Person(string FirstName, string LastName, int Age);

// Define an interface to describe objects
public interface IDescribable
{
    string Describe();
}

// Base record with implementation of IDescribable
public record Vehicle(string Make, string Model) : IDescribable
{
    public virtual string Describe() => $"Vehicle: {Make} {Model}";

    // Demonstrating a method in a record
    public void DisplayDescription() => Console.WriteLine(Describe());
}

// Derived record with additional property and overridden Describe method
public record Car(string Make, string Model, int Year) : Vehicle(Make, Model), IDescribable
{
    public override string Describe() => $"{Year} {Make} {Model}";

    // Demonstrating deconstruction with additional properties
    public void Deconstruct(out string make, out string model, out int year)
    {
        make = Make;
        model = Model;
        year = Year;
    }
}
