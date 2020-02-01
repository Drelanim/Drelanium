﻿using System;

namespace Drelanium.DesignPatterns.Behavioral.Template_Method
{
    // https://refactoring.guru/design-patterns/template-method
    // https://refactoring.guru/design-patterns/template-method/csharp/example

    // The Abstract Class defines a template method that contains a skeleton of
    // some algorithm, composed of calls to (usually) abstract primitive
    // operations.
    //
    // Concrete subclasses should implement these operations, but leave the
    // template method itself intact.
    abstract class AbstractClass
    {
        // The template method defines the skeleton of an algorithm.
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperations1();
            this.BaseOperation2();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation3();
            this.Hook2();
        }

        // These operations already have implementations.
        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
        }

        // These operations have to be implemented in subclasses.
        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation. Hooks provide additional extension points in some
        // crucial places of the algorithm.
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());
        }
    }
}

//Output

//Same client code can work with different subclasses:
//AbstractClass says: I am doing the bulk of the work
//ConcreteClass1 says: Implemented Operation1
//AbstractClass says: But I let subclasses override some operations
//ConcreteClass1 says: Implemented Operation2
//AbstractClass says: But I am doing the bulk of the work anyway

//Same client code can work with different subclasses:
//AbstractClass says: I am doing the bulk of the work
//ConcreteClass2 says: Implemented Operation1
//AbstractClass says: But I let subclasses override some operations
//ConcreteClass2 says: Overridden Hook1
//ConcreteClass2 says: Implemented Operation2
//AbstractClass says: But I am doing the bulk of the work anyway