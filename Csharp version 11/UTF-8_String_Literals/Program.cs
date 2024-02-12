// A normal string in C# (encoded in UTF-16 in memory)
using System.Text;

string normalString = "This is a string: Привет, мир!";

// Convert the string to a UTF-8 byte array
byte[] utf8Bytes = Encoding.UTF8.GetBytes(normalString);

// Optionally, convert the UTF-8 byte array back to a string (still UTF-16 in memory)
string fromUtf8String = Encoding.UTF8.GetString(utf8Bytes);

// Print the original string and the string obtained from the UTF-8 byte array
Console.WriteLine("Original String:");
Console.WriteLine(normalString);
Console.WriteLine("\nString from UTF-8 Bytes:");
Console.WriteLine(fromUtf8String);