//Native - sized integers in C# 9, introduced as part of .NET 5, are new primitive types that are represented by the nint
//and nuint keywords. These types are essentially pointers or integers that are sized to match the pointer size of
//the platform (32-bit on x86 and 64-bit on x64 architectures). They provide a more seamless and type-safe way to work
//with pointers or interoperate with native code that uses platform-specific integer sizes.

unsafe { 

// Declare native-sized integers
nint nativeInt = 10;
nuint nativeUnsignedInt = 20;

// Arithmetic operations
nativeInt *= 2;
nativeUnsignedInt += 40;

// Show the size of native-sized integers
Console.WriteLine($"Size of nint: {sizeof(nint)} bytes");
Console.WriteLine($"Size of nuint: {sizeof(nuint)} bytes");

// Display values
Console.WriteLine($"Value of nativeInt: {nativeInt}");
Console.WriteLine($"Value of nativeUnsignedInt: {nativeUnsignedInt}");

// Use in P/Invoke scenarios (as an example, not actual P/Invoke here)
IntPtr ptr = (IntPtr)nativeInt;
UIntPtr uptr = (UIntPtr)nativeUnsignedInt;

// Display pointer values (addresses)
Console.WriteLine($"IntPtr value: {ptr}");
Console.WriteLine($"UIntPtr value: {uptr}");

}