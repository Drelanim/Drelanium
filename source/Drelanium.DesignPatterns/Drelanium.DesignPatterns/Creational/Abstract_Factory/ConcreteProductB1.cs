namespace Drelanium.DesignPatterns.Creational.Abstract_Factory
{
    // Concrete Products are created by corresponding Concrete Factories.
    class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }

        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }
}

//Output

//Client: Testing client code with the first factory type...
//The result of the product B1.
//The result of the B1 collaborating with the (The result of the product A1.)

//Client: Testing the same client code with the second factory type...
//The result of the product B2.
//The result of the B2 collaborating with the (The result of the product A2.)