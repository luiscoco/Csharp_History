
using DotNet8Examples;

Console.WriteLine($"Default Lambda Parameters examples:{Environment.NewLine}");

var defaultLambdaParameters = new DefaultLambdaParameters();
defaultLambdaParameters.Demo();

Console.WriteLine("-------------------------");

var addWithDefault1 = (int addTo = 2) => Console.WriteLine(addTo + 1);
addWithDefault1();

var lambdaDemo1 = (string name = "UserLuis") => Console.WriteLine($"Hello {name}");

lambdaDemo1();

