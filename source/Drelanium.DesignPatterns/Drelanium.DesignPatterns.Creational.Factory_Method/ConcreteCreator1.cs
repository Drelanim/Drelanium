namespace Drelanium.DesignPatterns.Creational.Factory_Method
{
    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
    public class ConcreteCreator1 : Creator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
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