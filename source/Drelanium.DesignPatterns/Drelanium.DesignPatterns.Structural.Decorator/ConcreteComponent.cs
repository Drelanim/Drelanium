namespace Drelanium.DesignPatterns.Structural.Decorator
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    public class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}

//Output

//Client: I get a simple component:
//RESULT: ConcreteComponent

//Client: Now I've got a decorated component:
//RESULT: ConcreteDecoratorB(ConcreteDecoratorA(ConcreteComponent))