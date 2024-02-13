//C# 9 introduced several features aimed at improving performance and enhancing interoperability with low-level code,
//making it easier to work efficiently with memory and operating system resources. While these improvements are more
//technical and primarily benefit developers working on high-performance applications, libraries, or interop scenarios,
//they are significant enhancements to the language. Key features include:

//Init-only setters: Allow for more efficient object initialization.
//Record types: Provide value-based equality and immutability, which can lead to performance benefits in certain scenarios.
//Native-sized integers (nint and nuint): Facilitate direct operations on pointers and sizes, improving interop scenarios with native code.
//Function pointers: Offer a way to directly invoke unmanaged code, improving performance in interop scenarios.
//Source Generators: Enable compile-time code generation, reducing runtime costs and enhancing the developer experience without sacrificing performance.
//For this demonstration, we'll focus on native-sized integers and function pointers, as they are particularly relevant to performance and interop.
//We will create a console application that uses these features to call a simple method in an unmanaged DLL, simulating a common interop scenario.

//Modify the Program.cs file to demonstrate using native-sized integers and function pointers for interop. Note that calling unmanaged code requires the use of the unsafe keyword, and you should enable unsafe code in your project settings.

//First, edit your PerformanceInteropDemo.csproj file to allow unsafe code:

//xml
//Copy code
//<PropertyGroup>
//    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
//</PropertyGroup>

// This is a global using directive for .NET 6 and later
global using System.Runtime.InteropServices;

// Your unsafe code block
unsafe
{
    // Load the DLL containing the unmanaged function
    var libraryHandle = NativeLibrary.Load("ExampleDLL.dll");

    // Get a pointer to the unmanaged function
    var addPtr = NativeLibrary.GetExport(libraryHandle, "add");

    // Cast the pointer to the unmanaged function to a function pointer
    var add = (delegate* unmanaged<int, int, int>)addPtr;

    // Call the unmanaged function
    int result = add(2, 3);
    Console.WriteLine($"The result of adding 2 and 3 is {result}");

    // Don't forget to free the library handle if necessary
    NativeLibrary.Free(libraryHandle);
}

// Rest of your top-level code
