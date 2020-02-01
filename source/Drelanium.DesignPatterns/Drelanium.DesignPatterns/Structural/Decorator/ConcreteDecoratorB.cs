﻿namespace Drelanium.DesignPatterns.Structural.Decorator
{
    // Decorators can execute their behavior either before or after the call to
    // a wrapped object.
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}

//Output

//Client: I get a simple component:
//RESULT: ConcreteComponent

//Client: Now I've got a decorated component:
//RESULT: ConcreteDecoratorB(ConcreteDecoratorA(ConcreteComponent))