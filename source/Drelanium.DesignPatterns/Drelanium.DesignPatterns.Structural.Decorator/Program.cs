using System;

namespace Drelanium.DesignPatterns.Structural.Decorator
{
    // https://refactoring.guru/design-patterns/decorator
    // https://refactoring.guru/design-patterns/decorator/csharp/example


    // The base Component interface defines operations that can be altered by
    // decorators.
    public abstract class Component
    {
        public abstract string Operation();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);
        }
    }
}

//Output

//Client: I get a simple component:
//RESULT: ConcreteComponent

//Client: Now I've got a decorated component:
//RESULT: ConcreteDecoratorB(ConcreteDecoratorA(ConcreteComponent))