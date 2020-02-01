using System;

namespace Drelanium.DesignPatterns.Structural.Adapter
{
    // https://refactoring.guru/design-patterns/adapter
    // https://refactoring.guru/design-patterns/adapter/csharp/example

    // The Target defines the domain-specific interface used by the client code.
    public interface ITarget
    {
        string GetRequest();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}

//Output

//Adaptee interface is incompatible with the client.
//But with adapter client can call it's method.
//This is 'Specific request.'