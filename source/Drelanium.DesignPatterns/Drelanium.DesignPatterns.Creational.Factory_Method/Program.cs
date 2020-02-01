namespace Drelanium.DesignPatterns.Creational.Factory_Method
{
    // https://refactoring.guru/design-patterns/factory-method
    // https://refactoring.guru/design-patterns/factory-method/csharp/example

    // The Creator class declares the factory method that is supposed to return
    // an object of a Product class. The Creator's subclasses usually provide
    // the implementation of this method.
    abstract class Creator
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract IProduct FactoryMethod();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }

    // The Product interface declares the operations that all concrete products
    // must implement.
    public interface IProduct
    {
        string Operation();
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}


//Output

//App: Launched with the ConcreteCreator1.
//Client: I'm not aware of the creator's class, but it still works.
//Creator: The same creator's code has just worked with {Result of ConcreteProduct1}

//App: Launched with the ConcreteCreator2.
//Client: I'm not aware of the creator's class, but it still works.
//Creator: The same creator's code has just worked with {Result of ConcreteProduct2}