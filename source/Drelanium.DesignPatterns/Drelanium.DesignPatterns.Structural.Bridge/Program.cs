using System;

namespace Drelanium.DesignPatterns.Structural.Bridge
{
    // https://refactoring.guru/design-patterns/bridge
    // https://refactoring.guru/design-patterns/bridge/csharp/example

    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}

//Output

//Abstract: Base operation with:
//ConcreteImplementationA: The result in platform A.

//ExtendedAbstraction: Extended operation with:
//ConcreteImplementationA: The result in platform B.