using System.Runtime.CompilerServices;

// The InterceptsLocationAttribute can be defined either in this file or in a separate file.
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class InterceptsLocationAttribute(string filePath, int line, int character) : Attribute
    {
    }
}

namespace InterceptorsTest
{
    public static class Interceptors
    {
        [InterceptsLocation(
            filePath: @"C:\Csharp History\Csharp version 12\Interceptors\Program.cs",
            line: 8,
            character: 22)]
        public static void InterceptMethodPrintValue2(this InterceptableExample example)
        {
            Console.WriteLine("Interceptor is here!");
        }
    }

    public class InterceptableExample
    {
        // This method will not be intercepted;
        public void PrintValue1()
        {
            Console.WriteLine("Test 1");
        }

        // This method will be intercepted;
        public void PrintValue2()
        {
            Console.WriteLine("Test 2");
        }

        // This method will not be intercepted;
        public void PrintValue3()
        {
            Console.WriteLine("Test 3");
        }
    }
}
