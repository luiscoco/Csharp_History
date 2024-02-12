using DotNet8;
using System;
using Person = (string name, int age, string country);
using MyConsole = System.Console;

#region Alias any type

Console.WriteLine($"Alias any type examples:{Environment.NewLine}");

MyConsole.WriteLine("Test console");

var person = AliasAnyType.GetPerson();
Console.WriteLine(person);

AliasAnyType.PrintPerson(person);

Console.WriteLine("-------------------------");

#endregion


namespace DotNet8
{
    public static class AliasAnyType
    {
        public static Person GetPerson()
        {
            Person person = new("Aragorn", 33, "Netherlands");

            return person;
        }

        public static void PrintPerson(Person person)
        {
            Console.WriteLine($"{person.name}, {person.age}, {person.country}");
        }
    }
}


