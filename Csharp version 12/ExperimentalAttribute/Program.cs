using DotNet8Examples;

Console.WriteLine($"Experimental Attribute examples:{Environment.NewLine}");

#pragma warning disable Test001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
var demo1 = new ExperimentalAttributeDemo();
#pragma warning restore Test001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

// It's configured on .csproj to ignore the Test002;
demo1.Print();

Console.WriteLine("-------------------------");