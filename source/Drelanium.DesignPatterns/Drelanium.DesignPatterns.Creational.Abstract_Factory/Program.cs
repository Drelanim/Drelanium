namespace Drelanium.DesignPatterns.Creational.Abstract_Factory
{
    // https://refactoring.guru/design-patterns/abstract-factory
    // https://refactoring.guru/design-patterns/abstract-factory/csharp/example

    public class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
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