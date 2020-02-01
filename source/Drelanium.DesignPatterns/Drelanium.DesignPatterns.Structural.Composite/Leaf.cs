namespace Drelanium.DesignPatterns.Structural.Composite
{
    // The Leaf class represents the end objects of a composition. A leaf can't
    // have any children.
    //
    // Usually, it's the Leaf objects that do the actual work, whereas Composite
    // objects only delegate to their sub-components.
    public class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}

//Output

//Client: I get a simple component:
//RESULT: Leaf

//Client: Now I've got a composite tree:
//RESULT: Branch(Branch(Leaf+Leaf)+Branch(Leaf))

//Client: I don't need to check the components classes even when managing the tree:
//RESULT: Branch(Branch(Leaf+Leaf)+Branch(Leaf)+Leaf)