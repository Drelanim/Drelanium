namespace Drelanium.DesignPatterns.Structural.Adapter
{
    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}

//Output

//Adaptee interface is incompatible with the client.
//But with adapter client can call it's method.
//This is 'Specific request.'