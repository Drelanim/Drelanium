namespace Drelanium.DesignPatterns.Structural.Decorator
{
    // Concrete Decorators call the wrapped object and alter its result in some
    // way.
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp)
        {
        }

        // Decorators may call parent implementation of the operation, instead
        // of calling the wrapped object directly. This approach simplifies
        // extension of decorator classes.
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}

//Output

//Client: I get a simple component:
//RESULT: ConcreteComponent

//Client: Now I've got a decorated component:
//RESULT: ConcreteDecoratorB(ConcreteDecoratorA(ConcreteComponent))