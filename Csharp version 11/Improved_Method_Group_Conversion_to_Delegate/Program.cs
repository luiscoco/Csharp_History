//In C# 11, the conversion of method groups to delegate types has been improved to reduce unnecessary allocations.
//Previously, converting a method group to a delegate instance would always allocate a new delegate object.
//C# 11 optimizes this by caching the delegate instance for static methods and instance methods of readonly struct instances,
//which can significantly improve performance in scenarios where delegates are frequently created from method groups.

//This enhancement is particularly useful in high-performance applications, event handling, and scenarios where delegates
//are used extensively for callbacks or LINQ queries.

//Here's a simple example of a C# Console Application that demonstrates the improved method group conversion to delegate
//in C# 11. This example will compare the behavior with a focus on how to use the feature rather than demonstrating
//the performance improvement directly, as the latter would require a more complex benchmarking setup.

// Example with a static method
Func<int, int> doubleDelegate = Double;
Console.WriteLine($"Double 2: {doubleDelegate(2)}");

// Example with an instance method
var processor = new Processor();
Func<int, int> tripleDelegate = processor.Triple;
Console.WriteLine($"Triple 3: {tripleDelegate(3)}");

// Delegate comparison to demonstrate delegate caching with static methods
Func<int, int> doubleDelegate2 = Double;
Console.WriteLine($"Are delegate instances the same (static method)? {doubleDelegate == doubleDelegate2}");

// Delegate comparison for instance methods will still show as different
// because delegate caching for instance methods does not apply in the same way
Func<int, int> tripleDelegate2 = processor.Triple;
Console.WriteLine($"Are delegate instances the same (instance method)? {tripleDelegate == tripleDelegate2}");

static int Double(int x) => x * 2;

class Processor
{
    public int Triple(int x) => x * 3;
}
