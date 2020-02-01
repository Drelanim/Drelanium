namespace Drelanium.DesignPatterns.Creational.Abstract_Factory
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
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