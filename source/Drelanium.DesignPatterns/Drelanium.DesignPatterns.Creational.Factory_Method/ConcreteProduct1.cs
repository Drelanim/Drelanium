namespace Drelanium.DesignPatterns.Creational.Factory_Method
{
    // Concrete Products provide various implementations of the Product
    // interface.
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
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