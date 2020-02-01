using System;

namespace Drelanium.DesignPatterns.Behavioral.State
{
    // Concrete States implement various behaviors, associated with a state of
    // the Context.
    class ConcreteStateA : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.");
            this._context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateA handles request2.");
        }
    }
}

//Output

//Context: Transition to ConcreteStateA.
//ConcreteStateA handles request1.
//ConcreteStateA wants to change the state of the context.
//Context: Transition to ConcreteStateB.
//ConcreteStateB handles request2.
//ConcreteStateB wants to change the state of the context.
//Context: Transition to ConcreteStateA.