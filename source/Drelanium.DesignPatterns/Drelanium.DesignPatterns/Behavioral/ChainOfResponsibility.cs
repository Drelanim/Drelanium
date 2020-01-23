using System;
using System.Collections.Generic;

namespace Drelanium.DesignPatterns.Behavioral.ChainOfResponsibility
{

    // https://refactoring.guru/design-patterns/chain-of-responsibility
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

    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }

    // The default chaining behavior can be implemented inside a base handler class.
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            // Returning a handler from here will let us link handlers in a
            // convenient way like this:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }

    class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"Monkey: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return $"Dog: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class Client
    {
        // The client code is usually suited to work with a single handler. In
        // most cases, it is not even aware that the handler is part of a chain.
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The other part of the client code constructs the actual chain.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);
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