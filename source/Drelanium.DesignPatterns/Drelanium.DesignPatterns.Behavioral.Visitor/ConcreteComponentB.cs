namespace Drelanium.DesignPatterns.Behavioral.Visitor
{
    public class ConcreteComponentB : IComponent
    {
        // Same here: VisitConcreteComponentB => ConcreteComponentB
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return "B";
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