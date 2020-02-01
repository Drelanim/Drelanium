﻿using System.Collections;

namespace Drelanium.DesignPatterns.Behavioral.Iterator
{
    abstract class IteratorAggregate : IEnumerable
    {
        // Returns an Iterator or another IteratorAggregate
        // for the implementing object.
        public abstract IEnumerator GetEnumerator();
    }
}