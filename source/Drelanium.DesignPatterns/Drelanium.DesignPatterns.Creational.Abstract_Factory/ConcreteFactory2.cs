namespace Drelanium.DesignPatterns.Creational.Abstract_Factory
{
    // Each Concrete Factory has a corresponding product variant.
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
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