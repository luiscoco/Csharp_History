//In C# 10, introduced as part of .NET 6, one of the new features is the ability to use interpolated strings
//with the const modifier, provided all the placeholders are themselves constant expressions. This feature enhances
//the usability of constants by allowing you to compose them from other constants using string interpolation,
//making your code more readable and maintainable.

//Before C# 10, you couldn't use interpolated strings in const declarations because interpolated strings were
//not considered constant expressions. With C# 10, as long as the expressions used in the interpolation are constants,
//the interpolated string can also be declared as const.

// Define const values
const string BaseUrl = "http://example.com";
const string Resource = "api/values";

// Use const interpolated string
const string FullUrl = $"{BaseUrl}/{Resource}";

Console.WriteLine($"The full URL is: {FullUrl}");

