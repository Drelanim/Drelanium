using System;

namespace Drelanium.DesignPatterns.Behavioral.Mediator
{
    // https://refactoring.guru/design-patterns/mediator
    // https://refactoring.guru/design-patterns/mediator/csharp/example

    // The Mediator interface declares a method used by components to notify the
    // mediator about various events. The Mediator may react to these events and
    // pass the execution to other components.

    public class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggets operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}

//Output

//Client triggers operation A.
//Component 1 does A.
//Mediator reacts on A and triggers following operations:
//Component 2 does C.

//Client triggers operation D.
//Component 2 does D.
//Mediator reacts on D and triggers following operations:
//Component 1 does B.
//Component 2 does C.