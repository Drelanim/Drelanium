﻿namespace Drelanium.DesignPatterns.Creational.Factory_Method
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
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