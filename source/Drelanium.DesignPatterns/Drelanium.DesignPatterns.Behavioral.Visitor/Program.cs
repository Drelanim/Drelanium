using System;
using System.Collections.Generic;

namespace Drelanium.DesignPatterns.Behavioral.Visitor
{
    // https://refactoring.guru/design-patterns/visitor
    // https://refactoring.guru/design-patterns/visitor/csharp/example

    public class Program
    {
        static void Main(string[] args)
        {
            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);
        }
    }
}

//Output

//The client code works with all visitors via the base Visitor interface:
//A + ConcreteVisitor1
//B + ConcreteVisitor1

//It allows the same client code to work with different types of visitors:
//A + ConcreteVisitor2
//B + ConcreteVisitor2