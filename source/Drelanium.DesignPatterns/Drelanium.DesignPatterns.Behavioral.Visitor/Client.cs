using System.Collections.Generic;

namespace Drelanium.DesignPatterns.Behavioral.Visitor
{
    public class Client
    {
        // The client code can run visitor operations over any set of elements
        // without figuring out their concrete classes. The accept operation
        // directs a call to the appropriate operation in the visitor object.
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
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