//C# 10 introduced an enhancement to deconstruction syntax that allows for both assignment to existing variables
//and declaration of new variables in the same deconstruction expression. This feature adds flexibility and conciseness
//to the deconstruction of tuples or types that support deconstruction, making code easier to read and write, especially
//when working with mixed data that needs to be partially updated and partially initialized.

//To demonstrate this feature, let's create a console application that showcases how to use both assignment
//and declaration in the same deconstruction operation.


//EXAMPLE 1

var person = ("John Doe", 30); // Tuple representing a person's name and age
string name; // Declare a variable for the name
             // Deconstruct the tuple, assigning the name to an existing variable, and declaring a new variable for the age
(name, int age) = person;

Console.WriteLine($"Name: {name}, Age: {age}");

//EXAMPLE 2

var employee = new Employee("Jane Doe", 28, new Address("New York", "USA"));
string existingName = "John Doe"; // An existing variable for name
Address existingAddress = new Address("Los Angeles", "USA"); // An existing variable for address

// Deconstructing the employee, updating existing variables, and declaring new ones
(existingName, int newAge, existingAddress) = employee;

// Further deconstruct the address to extract city and country
var (city, country) = existingAddress;

Console.WriteLine($"Updated Name: {existingName}, New Age: {newAge}");
Console.WriteLine($"Updated Address: City - {city}, Country - {country}");


public class Address
{
    public string City { get; set; }
    public string Country { get; set; }

    public Address(string city, string country)
    {
        City = city;
        Country = country;
    }

    // Deconstruction method for Address
    public void Deconstruct(out string city, out string country)
    {
        city = City;
        country = Country;
    }
}

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }

    public Employee(string name, int age, Address address)
    {
        Name = name;
        Age = age;
        Address = address;
    }

    // Deconstruction method for Employee
    public void Deconstruct(out string name, out int age, out Address address)
    {
        name = Name;
        age = Age;
        address = Address;
    }
}
