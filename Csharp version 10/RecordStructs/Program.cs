//In C# 10, a significant new feature introduced is record structs, expanding the concept of records to structures.
//Before C# 10, records were limited to reference types, providing a concise syntax for defining immutable objects
//with value-based equality semantics. With C# 10, this capability is extended to structs, allowing developers
//to define value types with similar benefits, such as immutability and with-value semantics, but with the memory
//efficiency and performance characteristics of structs.

//Record structs are particularly useful for creating lightweight data models where value-based equality
//and immutability are desired but without the overhead of heap allocation associated with classes

// Creating instances of the record struct
var point1 = new Point(1.0, 2.0);
var point2 = new Point(1.0, 2.0);
var point3 = point1 with { X = 3.0 }; // Using the with-expression to create a new record struct instance with modified properties

// Displaying the points
Console.WriteLine($"Point 1: {point1}");
Console.WriteLine($"Point 2: {point2}");
Console.WriteLine($"Point 3: {point3}");

// Comparing two record struct instances
Console.WriteLine($"Point 1 == Point 2? {point1 == point2}"); // True, because record structs have value-based equality
Console.WriteLine($"Point 1 == Point 3? {point1 == point3}"); // False, because point3 has a different value for X

// Defining a record struct
public readonly record struct Point(double X, double Y);
