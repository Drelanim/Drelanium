namespace Drelanium.DesignPatterns.Creational.Abstract_Factory
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
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