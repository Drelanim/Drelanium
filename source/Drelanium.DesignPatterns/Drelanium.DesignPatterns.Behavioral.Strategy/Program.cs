using System;
using System.Collections.Generic;

namespace Drelanium.DesignPatterns.Behavioral.Strategy
{
    // https://refactoring.guru/design-patterns/strategy
    // https://refactoring.guru/design-patterns/strategy/csharp/example

    public class Program
    {
        static void Main(string[] args)
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}

//Output

//Client: Strategy is set to normal sorting.
//Context: Sorting data using the strategy(not sure how it'll do it)
//a, b, c, d, e

//Client: Strategy is set to reverse sorting.
//Context: Sorting data using the strategy(not sure how it'll do it)
//e, d, c, b, a