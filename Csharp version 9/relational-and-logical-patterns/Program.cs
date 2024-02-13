
//C# 9 introduced significant enhancements to pattern matching, making it more powerful and flexible.
//These enhancements include relational patterns, which allow you to use relational operators
//like <, >, <=, and >= in patterns, and logical patterns, which introduce logical operations
//and, or, and not into patterns. These features make it easier to express complex conditional
//logic in a more concise and readable way.

Console.WriteLine(ActivitySuggestion(25, "sunny")); // Example for a sunny day
Console.WriteLine(ActivitySuggestion(10, "rainy")); // Example for a rainy day
Console.WriteLine(ActivitySuggestion(30, "sunny")); // Example for a hot day
Console.WriteLine(ActivitySuggestion(-5, "snowy")); // Example for a snowy day

static string ActivitySuggestion(int temperature, string weatherCondition)
{
    return (temperature, weatherCondition) switch
    {
        ( > 20, "sunny") => "It's a great day for a walk!",
        ( <= 20 and >= 0, "rainy") => "A perfect day to read a book.",
        ( > 25, _) => "Stay hydrated, it's hot outside!",
        ( < 0, "snowy") => "How about building a snowman?",
        _ => "Let's just stay home."
    };
}