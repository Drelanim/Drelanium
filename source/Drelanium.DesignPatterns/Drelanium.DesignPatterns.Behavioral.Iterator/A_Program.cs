using System;
using System.Collections;

namespace Drelanium.DesignPatterns.Behavioral.Iterator
{
    // https://refactoring.guru/design-patterns/iterator
    // https://refactoring.guru/design-patterns/iterator/csharp/example

    // Iterator is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation(list, stack, tree, etc.).
    // Iterator is a behavioral design pattern that allows sequential traversal through a complex data structure without exposing its internal details.

    // Thanks to the Iterator, clients can go over elements of different collections in a similar fashion using a single iterator interface.

    // Usage examples: The pattern is very common in C# code.
    // Many frameworks and libraries use it to provide a standard way for traversing their collections.

    // Identification: Iterator is easy to recognize by the navigation methods(such as next, previous and others).
    // Client code that uses iterators might not have direct access to the collection being traversed.

    class Program
    {
        static void Main(string[] args)
        {
            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}

//Output

//Straight traversal:
//First
//Second
//Third

//Reverse traversal:
//Third
//Second
//First