using System;

namespace Drelanium.DesignPatterns.Behavioral.State
{
    // https://refactoring.guru/design-patterns/state
    // https://refactoring.guru/design-patterns/state/csharp/example

    public class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }
    }
}

//Output

//Context: Transition to ConcreteStateA.
//ConcreteStateA handles request1.
//ConcreteStateA wants to change the state of the context.
//Context: Transition to ConcreteStateB.
//ConcreteStateB handles request2.
//ConcreteStateB wants to change the state of the context.
//Context: Transition to ConcreteStateA.