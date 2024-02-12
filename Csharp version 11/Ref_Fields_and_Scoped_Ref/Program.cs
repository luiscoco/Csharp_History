//C# 11 introduces the concept of ref fields and scoped references, allowing more flexible and efficient management of
//references within your applications. These features are particularly useful in performance-critical code,
//such as high-performance computing or systems programming, where manipulating references directly can lead
//to significant performance improvements.

//A ref field allows a struct field to reference another variable directly, rather than copying its value.
//This is useful for creating data structures that need to reference data stored elsewhere without duplicating it.

//Scoped references (scoped ref) restrict the lifetime of a reference to ensure that it does not outlive the scope
//it is defined in, enhancing safety when dealing with direct memory manipulation.

//Here's a simple C# Console Application example that demonstrates the use of ref fields and scoped references.
//This example will focus on illustrating how these features can be used together within a safe context.

int originalValue = 10;
Console.WriteLine($"Original Value: {originalValue}");

// Create an instance of RefStruct with a ref field pointing to originalValue
RefStruct refStruct = new RefStruct(ref originalValue);

// Modify the value through the ref field
refStruct.RefField = 20;
Console.WriteLine($"Modified Value via ref field: {originalValue}");

// Demonstrate scoped ref
ScopedRefExample();

static void ScopedRefExample()
{
    int someValue = 30;
    ref int refToLocal = ref someValue; // refToLocal is a reference to someValue

    // Scoped ref ensures that refToLocal cannot escape the scope of ScopedRefExample
    // You can modify someValue through refToLocal
    refToLocal = 40;
    Console.WriteLine($"Value modified via scoped ref: {someValue}");
}

// Define a struct with a ref field
public ref struct RefStruct
{
    public ref int RefField;

    public RefStruct(ref int refField)
    {
        RefField = ref refField;
    }
}

