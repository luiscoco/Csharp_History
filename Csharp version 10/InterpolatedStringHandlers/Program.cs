//C# 10 introduced interpolated string handlers, a powerful feature that enhances the way interpolated strings are processed
//and constructed. This feature allows for more efficient string interpolation, particularly in scenarios where the
//interpolated string is passed to a method that does not use it or when only parts of the interpolated string are
//conditionally used. It enables custom handling of the interpolation process, reducing allocations and improving
//performance by avoiding the creation of intermediate strings.

//Interpolated string handlers work by transforming an interpolated string into a call to a constructor of a type that
//implements the System.Runtime.CompilerServices.IInterpolatedStringHandler interface. This allows for custom logic to
//be executed as each part of the interpolated string is processed.

//Here's an example of a C# Console Application that demonstrates how to use interpolated string handlers by creating
//a custom logging mechanism that only processes the interpolated string if the logging level is set to a level that
//requires the log message to be written. This example will highlight the efficiency and flexibility that interpolated
//string handlers provide.

using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

var numbers = Enumerable.Range(0, 10).ToArray();
Numbers.Write($"Call {numbers:(###) ###-####} For A Good Time!");
Numbers.Write('x', $"Call {numbers:(xxx) xxx-xxxx} For A Good Time!");
Numbers.Range(numbers, $"Call ({0..3}) {3..6}-{6..9} For A Good Time!");

public static class Numbers
{
    public static void Write(PlaceholderInterpolatedStringHandler builder)
    {
        Write('#', builder);
    }

    public static void Write(char placeholder,
        [InterpolatedStringHandlerArgument("placeholder")] PlaceholderInterpolatedStringHandler builder
    )
    {
        Console.WriteLine(builder.GetFormattedText());
    }

    public static void Range<T>(
        T[] args,
        [InterpolatedStringHandlerArgument("args")]
        RangeInterpolatedStringHandler<T> handler)
    {
        Console.WriteLine(handler.ToString());
    }
}


[InterpolatedStringHandler]
public readonly struct PlaceholderInterpolatedStringHandler
{
    private char Placeholder { get; }
    private StringBuilder Builder { get; }

    public PlaceholderInterpolatedStringHandler(int literalLength, int formattedCount, char placeholder = '#')
        => (Placeholder, Builder) = (placeholder, new StringBuilder());

    public void AppendLiteral(string s) => Builder.Append(s);
    internal string GetFormattedText() => Builder.ToString();

    public void AppendFormatted(IEnumerable t, string format)
    {
        var enumerator = t.GetEnumerator();
        foreach (var c in format)
        {
            if (c == Placeholder && enumerator.MoveNext())
                Builder.Append(enumerator.Current);
            else
                Builder.Append(c);
        }
    }
}

[InterpolatedStringHandler]
public readonly struct RangeInterpolatedStringHandler<T>
{
    public RangeInterpolatedStringHandler(int literalLength, int formattedCount, T[] args)
        => (Args, Builder) = (args, new StringBuilder());

    private StringBuilder Builder { get; }
    private T[] Args { get; }

    public void AppendFormatted(Range range)
        => Builder.Append(string.Concat(Args[range]));

    public void AppendLiteral(string value)
        => Builder.Append(value);

    public string ToString() =>
        Builder.ToString();
}
