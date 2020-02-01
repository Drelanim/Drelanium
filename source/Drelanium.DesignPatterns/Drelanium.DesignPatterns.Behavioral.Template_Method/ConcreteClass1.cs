using System;

namespace Drelanium.DesignPatterns.Behavioral.Template_Method
{
    // Concrete classes have to implement all abstract operations of the base
    // class. They can also override some operations with a default
    // implementation.
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
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