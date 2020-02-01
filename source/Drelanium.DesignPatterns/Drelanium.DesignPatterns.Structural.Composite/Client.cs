using System;

namespace Drelanium.DesignPatterns.Structural.Composite
{
    public class Client
    {
        // The client code works with all of the components via the base
        // interface.
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }

        // Thanks to the fact that the child-management operations are declared
        // in the base Component class, the client code can work with any
        // component, simple or complex, without depending on their concrete
        // classes.
        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}");
        }
    }
}

//Output

//Client: I get a simple component:
//RESULT: Leaf

//Client: Now I've got a composite tree:
//RESULT: Branch(Branch(Leaf+Leaf)+Branch(Leaf))

//Client: I don't need to check the components classes even when managing the tree:
//RESULT: Branch(Branch(Leaf+Leaf)+Branch(Leaf)+Leaf)