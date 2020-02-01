namespace Drelanium.DesignPatterns.Structural.Adapter
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}

//Output

//Adaptee interface is incompatible with the client.
//But with adapter client can call it's method.
//This is 'Specific request.'