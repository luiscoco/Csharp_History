using GenericAttribute;
using System;
using System.Reflection;


// Instantiate TestClass and invoke its methods to see them in action
TestClass testClassInstance = new TestClass();
testClassInstance.MethodWithStringType();
testClassInstance.MethodWithDoubleType();

// Continue with the reflection-based inspection as before
var classTypeAttribute = typeof(TestClass).GetCustomAttribute<TypeInfoAttribute<int>>();
if (classTypeAttribute != null)
{
    Console.WriteLine($"Class 'TestClass' is annotated with TypeInfoAttribute specifying type: {classTypeAttribute.Type.Name}");
}

// Inspect method attributes
foreach (var method in typeof(TestClass).GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
{
    var attributes = method.GetCustomAttributes(false);
    foreach (var attribute in attributes)
    {
        var attributeType = attribute.GetType();
        if (attributeType.IsGenericType && attributeType.GetGenericTypeDefinition() == typeof(TypeInfoAttribute<>))
        {
            var specifiedType = attributeType.GetProperty("Type").GetValue(attribute);
            Console.WriteLine($"Method '{method.Name}' is annotated with TypeInfoAttribute specifying type: {((Type)specifiedType).Name}");
        }
    }
}

// Apply the generic attribute to a class and its methods
[TypeInfo<int>]
class TestClass
{
    // Method annotated with TypeInfoAttribute<string>
    [TypeInfo<string>]
    public void MethodWithStringType()
    {
        // Example functionality: print a message with a string
        Console.WriteLine("This method is associated with the string type.");
    }

    // Method annotated with TypeInfoAttribute<double>
    [TypeInfo<double>]
    public void MethodWithDoubleType()
    {
        // Example functionality: print a message with a double value
        Console.WriteLine("This method is associated with the double type, showcasing a numeric value: 3.14");
    }
}
