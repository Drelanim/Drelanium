using System;

namespace Drelanium.DesignPatterns.Behavioral.Chain_Of_Responsibility
{
    // https://refactoring.guru/design-patterns/chain-of-responsibility
    // https://refactoring.guru/design-patterns/chain-of-responsibility/csharp/example

    // Also known as CoR, or Chain of Command

    // Chain of Responsibility is a behavioral design pattern 
    // that allows passing request along the chain of potential handlers until one of them handles request.
    // The pattern allows multiple objects to handle the request without coupling sender class
    // to the concrete classes of the receivers.The chain can be composed dynamically at runtime
    // with any handler that follows a standard handler interface.

    // Usage examples: The Chain of Responsibility pattern isn’t a frequent guest
    // in a C# program since it’s only relevant when code operates with chains of objects.

    // Identification: The pattern is recognizable by behavioral methods of one group of objects
    // indirectly call the same methods in other objects, while all the objects follow the common interface.


    // The default chaining behavior can be implemented inside a base handler class.
    public class Program
    {
        static void Main(string[] args)
        {
            // The other part of the client code constructs the actual chain.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey
                .SetNext(squirrel)
                .SetNext(dog);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);

            Console.ReadKey();
        }
    }
}

//Output

//Chain: Monkey > Squirrel > Dog

//Client: Who wants a Nut?
//   Squirrel: I'll eat the Nut.
//Client: Who wants a Banana?
//   Monkey: I'll eat the Banana.
//Client: Who wants a Cup of coffee?
//   Cup of coffee was left untouched.

//Subchain: Squirrel > Dog

//Client: Who wants a Nut?
//   Squirrel: I'll eat the Nut.
//Client: Who wants a Banana?
//   Banana was left untouched.
//Client: Who wants a Cup of coffee?
//   Cup of coffee was left untouched.