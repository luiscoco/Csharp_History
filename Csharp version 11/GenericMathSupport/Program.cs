using System;

namespace GenericMathDemo
{
    // Define an interface with static abstract members for basic math operations.
    public interface IBasicMath<T> where T : IBasicMath<T>
    {
        static abstract T Add(T a, T b);
        static abstract T Multiply(T a, T b);
    }

    // Implement the interface with a struct for integers.
    public struct IntMath : IBasicMath<IntMath>
    {
        private int Value;

        public IntMath(int value)
        {
            Value = value;
        }

        public static IntMath Add(IntMath a, IntMath b) => new IntMath(a.Value + b.Value);

        public static IntMath Multiply(IntMath a, IntMath b) => new IntMath(a.Value * b.Value);

        public override string ToString() => Value.ToString();
    }

    // Implement the interface with a struct for doubles.
    public struct DoubleMath : IBasicMath<DoubleMath>
    {
        private double Value;

        public DoubleMath(double value)
        {
            Value = value;
        }

        public static DoubleMath Add(DoubleMath a, DoubleMath b) => new DoubleMath(a.Value + b.Value);

        public static DoubleMath Multiply(DoubleMath a, DoubleMath b) => new DoubleMath(a.Value * b.Value);

        public override string ToString() => Value.ToString();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate generic math with IntMath
            var intResult = DoMath(new IntMath(5), new IntMath(10));
            Console.WriteLine($"IntMath Result: Add = {intResult.Item1}, Multiply = {intResult.Item2}");

            // Demonstrate generic math with DoubleMath
            var doubleResult = DoMath(new DoubleMath(5.5), new DoubleMath(10.5));
            Console.WriteLine($"DoubleMath Result: Add = {doubleResult.Item1}, Multiply = {doubleResult.Item2}");
        }

        // Generic method that can perform math operations on any type that implements IBasicMath<T>
        static (T, T) DoMath<T>(T a, T b) where T : IBasicMath<T>
        {
            var sum = T.Add(a, b);
            var product = T.Multiply(a, b);
            return (sum, product);
        }
    }
}
