//In C# 11, enhancements have been made to IntPtr and UIntPtr types, making them more usable in numeric contexts.
//These types now support most of the numeric operators directly, which means you can perform arithmetic and comparison
//operations on IntPtr and UIntPtr instances without needing to cast them to and from int, long, or other numeric types.
//This improvement is particularly useful when working with pointers or sizes in unsafe code, interop scenarios, or when
//dealing with system API calls that require pointer arithmetic.

//Below is a simple example of a C# Console Application that demonstrates the new numeric capabilities of the IntPtr type in C#
//11. This example will perform some basic arithmetic operations on IntPtr instances to show how these operations
//are now much more straightforward.

// Initialize two IntPtr instances with arbitrary values
IntPtr ptr1 = new IntPtr(10);
IntPtr ptr2 = new IntPtr(20);

// Perform arithmetic operations directly on IntPtr instances
IntPtr sum = ptr1 + ptr2;
IntPtr diff = ptr2 - ptr1;
bool isEqual = ptr1 == ptr2;
bool isLessThan = ptr1 < ptr2;

// Display the results
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {diff}");
Console.WriteLine($"Is Equal: {isEqual}");
Console.WriteLine($"Is Less Than: {isLessThan}");

// Demonstrating multiplication, which is not directly supported by IntPtr
// You have to cast to a numeric type, such as long, for operations other than add/subtract/compare
long scaleFactor = 5;
IntPtr scaled = new IntPtr(ptr1.ToInt64() * scaleFactor);
Console.WriteLine($"Scaled (ptr1 * 5): {scaled}");