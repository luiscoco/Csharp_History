//C# 10 introduced several improvements to lambda expressions, making them more powerful and flexible.
//These improvements include the ability to use attributes on lambda expression parameters, specify return types explicitly,
//and use natural types for lambdas, allowing them to be used in more contexts. These enhancements can significantly
//streamline code, especially in scenarios involving advanced function manipulation or where precise control over lambda
//expressions is needed.

//To demonstrate these improvements, I'll provide an example of a console application that showcases each of these enhancements.
//We'll create a simple application that processes a collection of data using lambda expressions, illustrating
//the new capabilities.


//  Example: Lambda expression with an explicit return type
Func<int, string> numberToString = (int number) => number.ToString();
Console.WriteLine($"Number to string: {numberToString(10)}");

// Example of a simple action with no return type
Action<string> greet = (string name) => Console.WriteLine($"Hello, {name}!");
greet("World");

// Example: Explicit return type
Func<int, string> intToString = (int x) => x.ToString();
var result = intToString(123);
Console.WriteLine($"Integer 123 to string: '{result}'");

// Example: Natural type for lambdas
var divide = (double x, double y) => x / y;
Console.WriteLine($"Dividing 10 by 2 gives: {divide(10, 2)}");

// Natural type for lambda expressions (assignment and invocation)
var product = (double x, double y) => x * y;
Console.WriteLine($"Product of 3.5 and 2.5 is: {product(3.5, 2.5)}");
