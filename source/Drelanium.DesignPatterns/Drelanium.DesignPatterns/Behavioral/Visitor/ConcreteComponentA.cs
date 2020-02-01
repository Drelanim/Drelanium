namespace Drelanium.DesignPatterns.Behavioral.Visitor
{
    // Each Concrete Component must implement the `Accept` method in such a way
    // that it calls the visitor's method corresponding to the component's
    // class.
    public class ConcreteComponentA : IComponent
    {
        // Note that we're calling `VisitConcreteComponentA`, which matches the
        // current class name. This way we let the visitor know the class of the
        // component it works with.
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        // Concrete Components may have special methods that don't exist in
        // their base class or interface. The Visitor is still able to use these
        // methods since it's aware of the component's concrete class.
        public string ExclusiveMethodOfConcreteComponentA()
        {
            return "A";
        }
    }
}

//Output

//The client code works with all visitors via the base Visitor interface:
//A + ConcreteVisitor1
//B + ConcreteVisitor1

//It allows the same client code to work with different types of visitors:
//A + ConcreteVisitor2
//B + ConcreteVisitor2