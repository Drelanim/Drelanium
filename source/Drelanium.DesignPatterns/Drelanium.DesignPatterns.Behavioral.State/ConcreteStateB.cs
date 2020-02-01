using System;

namespace Drelanium.DesignPatterns.Behavioral.State
{
    public class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Console.Write("ConcreteStateB handles request1.");
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateB handles request2.");
            Console.WriteLine("ConcreteStateB wants to change the state of the context.");
            this._context.TransitionTo(new ConcreteStateA());
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