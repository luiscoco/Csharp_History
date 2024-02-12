// Example 1: Multi-line string without needing escape sequences
string multiLineString = """
            This is a multi-line string
            that spans several lines
            without needing escape sequences.
            """;

Console.WriteLine("Multi-Line String:");
Console.WriteLine(multiLineString);

// Example 2: A JSON string
string jsonString = """
            {
                "name": "John Doe",
                "age": 30,
                "isEmployed": true
            }
            """;

Console.WriteLine("JSON String:");
Console.WriteLine(jsonString);

// Example 3: A string with quotes
string stringWithQuotes = """
            This is a string with "quotes" and doesn't need escape characters.
            """;

Console.WriteLine("String with Quotes:");
Console.WriteLine(stringWithQuotes);
