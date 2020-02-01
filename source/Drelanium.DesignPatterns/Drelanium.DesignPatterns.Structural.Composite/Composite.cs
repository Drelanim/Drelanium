using System.Collections.Generic;

namespace Drelanium.DesignPatterns.Structural.Composite
{
    // The Composite class represents the complex components that may have
    // children. Usually, the Composite objects delegate the actual work to
    // their children and then "sum-up" the result.
    public class Composite : Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }

        // The Composite executes its primary logic in a particular way. It
        // traverses recursively through all its children, collecting and
        // summing their results. Since the composite's children pass these
        // calls to their children and so forth, the whole object tree is
        // traversed as a result.
        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in this._children)
            {
                result += component.Operation();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
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