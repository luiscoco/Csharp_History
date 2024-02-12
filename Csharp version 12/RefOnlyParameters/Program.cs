
Console.WriteLine($"Ref Readonly Parameters examples:{Environment.NewLine}");

var refOnlyParametersDemo = new RefOnlyParameters();

Console.WriteLine("Method with ref readonly:");
var numberExample1 = 1;
refOnlyParametersDemo.PrintWithRefReadonly(ref numberExample1);
Console.WriteLine($"Your number is now {numberExample1}");

Console.WriteLine("Method with in:");
var numberExample2 = 2;
refOnlyParametersDemo.PrintWithIn(numberExample2);
Console.WriteLine($"Your number is now {numberExample2}");

Console.WriteLine("Method with ref:");
var numberExample3 = 3;
refOnlyParametersDemo.PrintWithRef(ref numberExample3);
Console.WriteLine($"Your number is now {numberExample3}");

Console.WriteLine("-------------------------");

public class RefOnlyParameters
{
    // Example using "ref" and "readonly" keywords;
    public void PrintWithRefReadonly(ref readonly int number)
    {
        Console.WriteLine($"Your number is {number}");
        //number++; // This will make the compiler issue an error;
    }

    // Example using the "in" keyword;
    public void PrintWithIn(in int number)
    {
        Console.WriteLine($"Your number is {number}");
        //number++; // This will make the compiler issue an error;
    }

    // Example using only the "ref" keyword;
    public void PrintWithRef(ref int number)
    {
        Console.WriteLine($"Your number is {number}");
        number++;
    }
}