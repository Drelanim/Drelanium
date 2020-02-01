namespace Drelanium.DesignPatterns.Behavioral.State
{
    // The base State class declares methods that all Concrete State should
    // implement and also provides a backreference to the Context object,
    // associated with the State. This backreference can be used by States to
    // transition the Context to another State.
    public abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
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