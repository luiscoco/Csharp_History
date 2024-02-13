//In C# 9, records were introduced as a way to simplify the creation of immutable data types, providing a concise syntax
//for defining data-carrying types. One of the benefits of records is their built-in behavior for methods like ToString(),
//Equals(), and GetHashCode(), which are automatically implemented based on the record's properties.

//C# 10 introduced the ability for record types to explicitly seal the ToString() method. This means that if you have a
//record type and you override ToString(), you can also prevent any further derived record types from overriding this
//method by using the sealed modifier. Sealing ToString() can be useful when you want to ensure a consistent string
//representation of your record instances that cannot be altered by subclasses.

Person person = new Person("John", "Doe");
Console.WriteLine(person); // Uses default ToString() implementation

Employee employee = new Employee("Jane", "Doe", "IT");
Console.WriteLine(employee); // Uses the sealed ToString() implementation

record Person(string FirstName, string LastName);

// Derived record with sealed ToString()
record Employee(string FirstName, string LastName, string Department) : Person(FirstName, LastName)
{
    // Sealing the ToString() method to prevent further overriding
    public sealed override string ToString()
    {
        return $"{base.ToString()}, Department: {Department}";
    }
}



