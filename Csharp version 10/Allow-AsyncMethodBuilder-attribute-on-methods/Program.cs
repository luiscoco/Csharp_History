//C# 10 introduced the AsyncMethodBuilder attribute, which allows developers to customize the async method builder
//used for an asynchronous method. This attribute can be applied to async methods or async lambda expressions
//to specify a custom method builder that controls the behavior of the asynchronous operation, such as how the
//task is constructed, how the state machine is managed, and how the result is returned.

//Custom async method builders can be used for various purposes, such as implementing specialized task types
//(e.g., for performance optimizations), integrating with different task-like objects, or extending the
//behavior of asynchronous operations with additional functionality.

//To demonstrate the AsyncMethodBuilder attribute and how it can be used in a console application,
//we'll create a simple example. We'll define a custom async method builder and then apply it to an
//async method to see how it affects the behavior of that method.

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncMethodBuilderDemo
{
    // Define a custom async method builder
    public class CustomAsyncMethodBuilder
    {
        private AsyncTaskMethodBuilder _builder = AsyncTaskMethodBuilder.Create();

        public static CustomAsyncMethodBuilder Create() => new CustomAsyncMethodBuilder();

        public void Start<TStateMachine>(ref TStateMachine stateMachine)
            where TStateMachine : IAsyncStateMachine => _builder.Start(ref stateMachine);

        public void SetStateMachine(IAsyncStateMachine stateMachine) => _builder.SetStateMachine(stateMachine);

        public void SetResult() => _builder.SetResult();

        public void SetException(Exception exception) => _builder.SetException(exception);

        public Task Task => _builder.Task;

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : INotifyCompletion
            where TStateMachine : IAsyncStateMachine => _builder.AwaitOnCompleted(ref awaiter, ref stateMachine);

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : ICriticalNotifyCompletion
            where TStateMachine : IAsyncStateMachine => _builder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
    }

    // Use the AsyncMethodBuilder attribute to specify the custom async method builder for an async method
    [AsyncMethodBuilder(typeof(CustomAsyncMethodBuilder))]
    public static class CustomAsyncExtensions
    {
        public static async Task CustomDelayAsync(int millisecondsDelay)
        {
            Console.WriteLine("Custom delay before awaiting Task.Delay...");
            await Task.Delay(millisecondsDelay);
            Console.WriteLine("Custom delay after awaiting Task.Delay.");
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting custom async operation...");
            await CustomAsyncExtensions.CustomDelayAsync(1000);
            Console.WriteLine("Custom async operation completed.");
        }
    }
}
