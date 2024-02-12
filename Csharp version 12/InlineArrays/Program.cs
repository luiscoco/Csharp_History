InlineArrayDemo inlineArray = new InlineArrayDemo();

for (int i = 0; i < 10; i++)
{
    inlineArray[i] = i;
}

foreach (var item in inlineArray)
{
    Console.Write($"{item} ");
}

// Output:
//0 1 2 3 4 5 6 7 8 9

[System.Runtime.CompilerServices.InlineArray(10)]
public struct InlineArrayDemo
{
    private int _element;
}