using System;

namespace Drelanium.DesignPatterns.Behavioral.Template_Method
{
    // https://refactoring.guru/design-patterns/template-method
    // https://refactoring.guru/design-patterns/template-method/csharp/example

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());
        }
    }
}

//Output

//Same client code can work with different subclasses:
//AbstractClass says: I am doing the bulk of the work
//ConcreteClass1 says: Implemented Operation1
//AbstractClass says: But I let subclasses override some operations
//ConcreteClass1 says: Implemented Operation2
//AbstractClass says: But I am doing the bulk of the work anyway

//Same client code can work with different subclasses:
//AbstractClass says: I am doing the bulk of the work
//ConcreteClass2 says: Implemented Operation1
//AbstractClass says: But I let subclasses override some operations
//ConcreteClass2 says: Overridden Hook1
//ConcreteClass2 says: Implemented Operation2
//AbstractClass says: But I am doing the bulk of the work anyway