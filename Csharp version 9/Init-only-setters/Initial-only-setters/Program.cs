////Init - only setters introduced in C# 9, part of .NET 5, provide a way to make properties immutable after object
////construction. This feature enhances the immutability capabilities of C#, allowing for the creation of objects whose
////properties can be set at the time of initialization but remain read-only thereafter. Init-only setters contribute
////to the safety and predictability of your code by ensuring that objects cannot be inadvertently modified after
////they've been fully constructed.

//------------------------------------------------------------------------------------------------------------------------------
// EXAMPLE 1
//------------------------------------------------------------------------------------------------------------------------------

var person1 = new Person
{
    Name = "John Doe",
    Age = 30
};

Console.WriteLine($"Person created: {person1.Name}, Age: {person1.Age}");

// The following line would raise a compile-time error because of init-only setters
// person.Name = "Jane Doe";

//------------------------------------------------------------------------------------------------------------------------------
// EXAMPLE2
//------------------------------------------------------------------------------------------------------------------------------

var person2 = new Person
{
    Name = "John Doe",
    Age = 30
};
Console.WriteLine($"Person created: {person2.Name}, Age: {person2.Age}");

// Initialize a new Employee object using init-only setters through object initializer syntax
var employee = new Employee
{
    Name = "John Doe",
    Age = 30,
    Department = "IT",
    Salary = 60000M
};
Console.WriteLine($"Employee created: {employee.Name}, Age: {employee.Age}, Department: {employee.Department}, Salary: {employee.Salary}");

// Demonstrating with-expression to create a new object with modified properties based on an existing object
var promotedEmployee = employee with { Salary = 70000M };
Console.WriteLine($"After promotion: {promotedEmployee.Name}, Age: {promotedEmployee.Age}, Department: {promotedEmployee.Department}, Salary: {promotedEmployee.Salary}");

// Change Person to a record
public record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}

// Employee already a record, correctly inheriting from Person
public record Employee : Person
{
    public string Department { get; init; }
    public decimal Salary { get; init; }
}
