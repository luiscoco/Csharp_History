//C# 10 introduced several improvements to structure types aimed at enhancing their usability and consistency
//with other features in the language. These improvements include parameterless constructors, field initializers,
//and more, which make structs more flexible and easier to use, especially when defining value types that require
//custom initialization logic or default values.
// Instantiate MyStruct using the parameterless constructor
var myStruct = new MyStruct();

// The field initializer for Number and the parameterless constructor logic for Text are applied
myStruct.Display();

// Modify properties to demonstrate their independent functionality
myStruct.Number = 20;
myStruct.Text = "Updated Text";
myStruct.Display();

public struct MyStruct
{
    // Field initializer
    public int Number { get; set; } = 10;

    // Custom property with a backing field
    private string _text;
    public string Text
    {
        get => _text;
        set => _text = value ?? throw new ArgumentNullException(nameof(Text), "Text cannot be null");
    }

    // Parameterless constructor
    public MyStruct()
    {
        _text = "Default Text";
    }

    public void Display()
    {
        Console.WriteLine($"Number: {Number}, Text: {Text}");
    }
}