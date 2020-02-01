namespace Drelanium.DesignPatterns.Structural.Bridge
{
    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}

//Output

//Abstract: Base operation with:
//ConcreteImplementationA: The result in platform A.

//ExtendedAbstraction: Extended operation with:
//ConcreteImplementationA: The result in platform B.