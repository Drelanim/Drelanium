namespace Drelanium.DesignPatterns.Behavioral.Template_Method
{
    public class Client
    {
        // The client code calls the template method to execute the algorithm.
        // Client code does not have to know the concrete class of an object it
        // works with, as long as it works with objects through the interface of
        // their base class.
        public static void ClientCode(AbstractClass abstractClass)
        {
            // ...
            abstractClass.TemplateMethod();
            // ...
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