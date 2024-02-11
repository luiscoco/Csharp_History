# C# History

https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history

## Summary

C# Value Types: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types

C# Reference Types: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types

C# Keyword: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/

C# Operators and expressions: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/

C# Statements: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/declarations

C# Special characters: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/

C# Attributes: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/attributes/global

## 1. C# Version 1.0

C# version 1.0, released with Visual Studio .NET 2002

The major features of C# 1.0 included:

**Classes** (object oriented programming features)

**Structs**

**Interfaces**

**Events**

**Properties**

**Delegates**

**Operators and expressions**

**Statements**

**Attributes**

## 2. C# Version 1.2

C# version 1.2 shipped with Visual Studio .NET 2003

Most notable is that starting with this version, the code generated in a **foreach loop** called **Dispose** on an **IEnumerator** when that **IEnumerator** implemented **IDisposable**.

## 3. C# Version 2.0

Let's take a look at some major features of C# 2.0, released in 2005, along with Visual Studio 2005:

**Generics**

**Partial types**

**Anonymous methods**

**Nullable value types**

**Iterators**

**Covariance and contravariance**

Other C# 2.0 features added capabilities to existing features:

**Getter/setter separate accessibility**

**Method group conversions (delegates)**

**Static classes**

**Delegate inference**

## 4. C# Version 3.0

C# version 3.0 came in late 2007, along with Visual Studio 2008, though the full boat of language features would actually come with .NET Framework version 3.5.

C# 3.0 had begun to lay the groundwork for turning C# into a **hybrid Object-Oriented / Functional language**.

Let's take a look at some major features in this version:

**Language-Integrated Query (LINQ)**

**Auto-implemented properties**

**Anonymous types**

**Query expressions**

**Lambda expressions**

**Expression trees**

**Extension methods**

**Implicitly typed local variables**

**Partial methods**

**Object and collection initializers**

## 5. C# Version 4.0

C# version 4.0, released with Visual Studio 2010

This version introduced some interesting new features:

**Dynamic binding**

**Named/optional arguments**

**Generic covariant and contravariant**

**Embedded interop types**

## 6. C# Version 5.0

C# version 5.0, released with Visual Studio 2012

Nearly all of the effort for that version went into another groundbreaking language concept: the **async** and **await** model for asynchronous programming

Here's the major features list:

**Asynchronous members**

**Caller info attributes**

**Code Project: Caller Info Attributes in C# 5.0**

## 7. C# Version 6.0

Version 6.0, released with Visual Studio 2015

Here are some of them:

**Static imports**

**Exception filters**

**Auto-property initializers**

**Expression bodied members**

**Null propagator**

**String interpolation**

**nameof operator**

Other new features include:

**Index initializers**

**Await in catch/finally blocks**

**Default values for getter-only properties**

## 8. C# Version 7.0

C# version 7.0 was released with Visual Studio 2017

Here are some of the new features:

**Out variables**

**Tuples and deconstruction**

**Pattern matching**

**Local functions**

**Expanded expression bodied members**

**Ref locals**

**Ref returns**

Other features included:

**Discards**

**Binary Literals and Digit Separators**

**Throw expressions**

## 9. C# Version 7.1

Released August, 2017

The new language features in this release are:

**async Main method**: The entry point for an application can have the async modifier

**default literal expressions**: You can use default literal expressions in default value expressions when the target type can be inferred

**Inferred tuple element names**: The names of tuple elements can be inferred from tuple initialization in many cases

**Pattern matching on generic type parameters**: You can use pattern match expressions on variables whose type is a generic type parameter

Finally, the compiler has two options -refout and -refonly that control reference assembly generation

## 10. C# Version 7.2

Released November, 2017

C# 7.2 added several small language features:

Initializers on **stackalloc** arrays.

Use **fixed** statements with any type that supports a pattern.

Access fixed fields without pinning.

Reassign **ref** local variables.

Declare **readonly struct** types, to indicate that a struct is immutable and should be passed as an in parameter to its member methods.

Add the **in** modifier on parameters, to specify that an argument is passed by reference but not modified by the called method.

Use the **ref readonly** modifier on method returns, to indicate that a method returns its value by reference but doesn't allow writes to that object.

Declare **ref struct** types, to indicate that a struct type accesses managed memory directly and must always be stack allocated.

Use additional generic constraints.

**Non-trailing named arguments**

Named arguments can be followed by positional arguments.

Leading **underscores** in numeric literals

Numeric literals can now have leading underscores before any printed digits.

**private protected access modifier**

The private protected access modifier enables access for derived classes in the same assembly.

Conditional **ref** expressions

The result of a conditional expression (**?:**) can now be a reference.

## 11. C# Version 7.3

Released May, 2018

The following new features support the theme of better performance for safe code:

You can access fixed fields without pinning

You can reassign ref local variables

You can use initializers on stackalloc arrays

You can use fixed statements with any type that supports a pattern

You can use more generic constraints

The following enhancements were made to existing features:

You can test == and != with tuple types

You can use expression variables in more locations

You may attach attributes to the backing field of auto-implemented properties

Method resolution when arguments differ by in has been improved.

Overload resolution now has fewer ambiguous cases

The new compiler options are:

-publicsign to enable Open Source Software (OSS) signing of assemblies

-pathmap to provide a mapping for source directories

## 12. C# Version 8.0

Released September, 2019

C# 8.0 adds the following features and enhancements to the C# language:

**Readonly members**

**Default interface methods**

Pattern matching enhancements:

**Switch expressions**

**Property patterns**

**Tuple patterns**

**Positional patterns**

**Using declarations**

**Static local functions**

**Disposable ref structs**

**Nullable reference types**

**Asynchronous streams**

**Indices and ranges**

**Null-coalescing assignment**

**Unmanaged constructed types**

**Stackalloc in nested expressions**

**Enhancement of interpolated verbatim strings**

## 13. C# Version 9.0

Released November, 2020

C# 9 was released with .NET 5

It contains the following new and enhanced features:

Records

**Init only setters**

**Top-level statements**

**Pattern matching enhancements: relational patterns and logical patterns**

**Performance and interop**

**Native sized integers**

**Function pointers**

**Suppress emitting localsinit flag**

**Module initializers**

**New features for partial methods**

**Fit and finish features**

**Target-typed new expressions**

**static anonymous functions**

**Target-typed conditional expressions**

**Covariant return types**

**Extension GetEnumerator support for foreach loops**

**Lambda discard parameters**

**Attributes on local functions**

C# 9 includes new pattern matching improvements:

**Type patterns** match an object matches a particular type

**Parenthesized patterns** enforce or emphasize the precedence of pattern combinations

**Conjunctive and patterns** require both patterns to match

**Disjunctive or patterns** require either pattern to match

**Negated not patterns** require that a pattern doesn't match

**Relational patterns** require the input be less than, greater than, less than or equal, or greater than or equal to a given constant.

## 14. C# Version 10.0

Released November, 2021

C# 10 adds the following features and enhancements to the C# language:

**Record structs**

**Improvements of structure types**

**Interpolated string handlers**

**global using directives**

**File-scoped namespace declaration**

**Extended property patterns**

**Improvements on lambda expressions**

**Allow const interpolated strings**

**Record types can seal ToString()**

**Improved definite assignment**

**Allow both assignment and declaration in the same deconstruction**

**Allow AsyncMethodBuilder attribute on methods**

**CallerArgumentExpression attribute**

**Enhanced #line pragma**

## 15. C# Version 11.0

Released November, 2022

The following features were added in C# 11:

**Raw string literals**

**Generic math support**

**Generic attributes**

**UTF-8 string literals**

**Newlines in string interpolation expressions**

**List patterns**

**File-local types**

**Required members**

**Auto-default structs**

**Pattern match Span<char> on a constant string**

**Extended nameof scope**

**Numeric IntPtr**

**ref fields and scoped ref**

**Improved method group conversion to delegate**

**Warning wave 7**


