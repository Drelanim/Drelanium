﻿namespace Drelanium.DesignPatterns.Structural.Bridge
{
    // The Abstraction defines the interface for the "control" part of the two
    // class hierarchies. It maintains a reference to an object of the
    // Implementation hierarchy and delegates all of the real work to this
    // object.
    public class Abstraction
    {
        protected IImplementation implementation;

        public Abstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                implementation.OperationImplementation();
        }
    }
}