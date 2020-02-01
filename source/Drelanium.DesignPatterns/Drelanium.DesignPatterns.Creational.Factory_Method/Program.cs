namespace Drelanium.DesignPatterns.Creational.Factory_Method
{
    // https://refactoring.guru/design-patterns/factory-method
    // https://refactoring.guru/design-patterns/factory-method/csharp/example

    public class Program
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