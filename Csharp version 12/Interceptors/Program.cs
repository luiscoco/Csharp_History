using InterceptorsTest;

Console.WriteLine($"Interceptors example:{Environment.NewLine}");

var interceptableExample = new InterceptableExample();

interceptableExample.PrintValue1();
interceptableExample.PrintValue2(); // The method PrintValue2 will be intercepted;
interceptableExample.PrintValue3();

Console.WriteLine("-------------------------");