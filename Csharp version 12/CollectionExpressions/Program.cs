#region Default

// Default Array;
using CollectionExpressions;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System.Collections.Immutable;
using System.Text.Json;

int[] myArray1 = new int[] { 10, 20, 30, 40, 50 };
var myArray2 = new int[] { 10, 20, 30, 40, 50 };

// Default List;
List<string> myList1 = new List<string> { "apple", "banana", "orange" };
var myList2 = new List<string> { "apple", "banana", "orange" };

// Default Span;
var array3 = new char[] { 'a', 'b', 'c', 'd', 'e' };
Span<char> mySpan1 = array3.AsSpan();
var mySpan2 = array3.AsSpan();

#endregion

#region Collection Expressions

// Array with Collection Expressions;
int[] demoArray = [10, 20, 30, 40, 50];

// List with Collection Expressions;
List<string> demoList = ["apple", "banana", "orange"];

// Span with Collection Expressions;
Span<char> demoSpan = ['a', 'b', 'c', 'd', 'e'];

// Jagged 2D Array with Collection Expressions;
int[][] demoJagged2DArray = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

// Jagged 2D Array from variables;
int[] row0 = [1, 2, 3];
int[] row1 = [4, 5, 6];
int[] row2 = [7, 8, 9];
int[][] demoJagged2DDArrayFromVariables = [row0, row1, row2];

// Array with spread operator;
int[] demoWithSpreadOperator = [.. row0, .. row1, .. row2];

#endregion

Console.WriteLine($"{nameof(demoArray)}: {JsonSerializer.Serialize(demoArray)}");
Console.WriteLine($"{nameof(demoList)}: {JsonSerializer.Serialize(demoList)}");
Console.Write($"{nameof(demoSpan)}: ");
foreach (var item in demoSpan) Console.Write($"{item} ");
Console.WriteLine();

Console.WriteLine($"{nameof(demoJagged2DArray)}: {JsonSerializer.Serialize(demoJagged2DArray)}");
Console.WriteLine($"{nameof(demoJagged2DDArrayFromVariables)}: {JsonSerializer.Serialize(demoJagged2DDArrayFromVariables)}");
Console.WriteLine($"{nameof(demoWithSpreadOperator)}: {JsonSerializer.Serialize(demoWithSpreadOperator)}");


var complexDictionary = new Dictionary<int, string>
{
    [1] = "One",
    [2] = DateTime.Now.DayOfWeek == DayOfWeek.Monday ? "Special Day" : "Two",
};

// Displaying dictionary contents
foreach (var kvp in complexDictionary)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

// List initialization with conditional logic
var filteredNumbers = new List<int>();
if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
{
    filteredNumbers.Add(13);
}
// Simulating range inclusion in a list
filteredNumbers.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

// Displaying list contents
foreach (var number in filteredNumbers)
{
    Console.WriteLine(number);
}

Span<string> weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];
foreach (var day in weekDays)
{
    Console.WriteLine(day);
}

// Initialize private field:
ImmutableArray<string> _months = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];

int Sum(IEnumerable<int> values) =>
    values.Sum();

void Example()
{
    // As a parameter:
    int sum = Sum([1, 2, 3, 4, 5]);
}

string hydrogen = "H";
string helium = "He";
string lithium = "Li";
string beryllium = "Be";
string boron = "B";
string carbon = "C";
string nitrogen = "N";
string oxygen = "O";
string fluorine = "F";
string neon = "Ne";
string[] elements = [hydrogen, helium, lithium, beryllium, boron, carbon, nitrogen, oxygen, fluorine, neon];
foreach (var element in elements)
{
    Console.WriteLine(element);
}


string[] vowels = ["a", "e", "i", "o", "u"];
string[] consonants = ["b",
    "c",
    "d",
    "f",
    "g",
    "h",
    "j",
    "k",
    "l",
    "m",
    "n",
    "p",
    "q",
    "r",
    "s",
    "t",
    "v",
    "w",
    "x",
    "z"];
string[] alphabet = [.. vowels, .. consonants, "y"];

// Creando una cadena de caracteres para inicializar LineBuffer
string message = "Hello World!";
ReadOnlySpan<char> span = message.AsSpan();

// Instanciando LineBuffer con el ReadOnlySpan<char>
LineBuffer lineBuffer = new LineBuffer(span);

// Usando lineBuffer...
foreach (var ch in lineBuffer)
{
    Console.Write(ch);
}