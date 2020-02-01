namespace Drelanium.DesignPatterns.Structural.Bridge
{
    // You can extend the Abstraction without changing the Implementation
    // classes.
    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }
}

//Output

//Abstract: Base operation with:
//ConcreteImplementationA: The result in platform A.

//ExtendedAbstraction: Extended operation with:
//ConcreteImplementationA: The result in platform B.