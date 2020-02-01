using System;

namespace Drelanium.DesignPatterns.Behavioral.State
{
    // https://refactoring.guru/design-patterns/state
    // https://refactoring.guru/design-patterns/state/csharp/example

    // The Context defines the interface of interest to clients. It also
    // maintains a reference to an instance of a State subclass, which
    // represents the current state of the Context.
    public class Context
    {
        // A reference to the current state of the Context.
        private State _state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        // The Context allows changing the State object at runtime.
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        // The Context delegates part of its behavior to the current State
        // object.
        public void Request1()
        {
            this._state.Handle1();
        }

        public void Request2()
        {
            this._state.Handle2();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
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