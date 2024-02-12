using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpressions
{
    // Hypothetical attribute usage, assuming such a feature exists
    [CollectionBuilder(typeof(LineBufferBuilder), "Create")]
    public class LineBuffer : IEnumerable<char>
    {
        private readonly char[] _buffer = new char[80];

        // Constructor that initializes the buffer from a ReadOnlySpan<char>
        public LineBuffer(ReadOnlySpan<char> buffer)
        {
            int number = Math.Min(_buffer.Length, buffer.Length);
            for (int i = 0; i < number; i++)
            {
                _buffer[i] = buffer[i];
            }
        }

        // IEnumerable<char> implementation to allow enumeration over the buffer
        public IEnumerator<char> GetEnumerator() => ((IEnumerable<char>)_buffer).GetEnumerator();

        // Non-generic IEnumerable implementation
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        // Additional functionality for LineBuffer can be added here,
        // such as methods to manipulate the buffer, access elements, etc.

        public void Add(char item)
        {
            // Example implementation, adjust according to your needs
            // This is a simplistic approach and does not handle capacity exceeding 80 characters
            for (int i = 0; i < _buffer.Length; i++)
            {
                if (_buffer[i] == '\0') // Assuming unused slots are default '\0'
                {
                    _buffer[i] = item;
                    return;
                }
            }

            // Handle the case where the buffer is full or resize the buffer as needed
        }
    }
    internal static class LineBufferBuilder
    {
        internal static LineBuffer Create(ReadOnlySpan<char> values) => new LineBuffer(values);
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class CollectionBuilderAttribute : Attribute
    {
        public Type BuilderType { get; }
        public string MethodName { get; }

        public CollectionBuilderAttribute(Type builderType, string methodName)
        {
            BuilderType = builderType;
            MethodName = methodName;
        }
    }
}
