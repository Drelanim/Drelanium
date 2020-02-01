using System;

namespace Drelanium.DesignPatterns.Structural.Facade
{
    class Client
    {
        // The client code works with complex subsystems through a simple
        // interface provided by the Facade. When a facade manages the lifecycle
        // of the subsystem, the client might not even know about the existence
        // of the subsystem. This approach lets you keep the complexity under
        // control.
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}

//Output

//Facade initializes subsystems:
//Subsystem1: Ready!
//Subsystem2: Get ready!
//Facade orders subsystems to perform the action:
//Subsystem1: Go!
//Subsystem2: Fire!
