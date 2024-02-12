//File - local types in C# 11 are a new feature that allows you to declare types that are only visible within the file
//where they are declared. This feature is particularly useful for organizing code by keeping helper classes or structs
//local to the file in which they are used, reducing the namespace clutter and enhancing encapsulation at the file level.

//Here's a simple C# Console Application example demonstrating how to use file-local types.
//This example will include a file-local type used within a program to perform a specific task,
//such as representing data that is only relevant within that file.

// Program.cs
using System;

namespace FileLocalTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the file-local type
            var myLocalData = new FileLocalData("Example", 42);
            Console.WriteLine(myLocalData);
        }
    }

    // File-local type declared with the 'file' modifier
    file class FileLocalData
    {
        public string Name { get; }
        public int Value { get; }

        public FileLocalData(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Value: {Value}";
        }
    }
}
