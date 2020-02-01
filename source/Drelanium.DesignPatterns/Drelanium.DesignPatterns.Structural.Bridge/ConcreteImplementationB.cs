namespace Drelanium.DesignPatterns.Structural.Bridge
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform B.\n";
        }
    }
}

//Output

//Abstract: Base operation with:
//ConcreteImplementationA: The result in platform A.

//ExtendedAbstraction: Extended operation with:
//ConcreteImplementationA: The result in platform B.