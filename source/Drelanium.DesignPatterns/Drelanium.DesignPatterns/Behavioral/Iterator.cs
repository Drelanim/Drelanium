﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Drelanium.DesignPatterns.Behavioral.Iterator
{
    // https://refactoring.guru/design-patterns/iterator

    // Iterator is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation(list, stack, tree, etc.).
    // Iterator is a behavioral design pattern that allows sequential traversal through a complex data structure without exposing its internal details.

    // Thanks to the Iterator, clients can go over elements of different collections in a similar fashion using a single iterator interface.

    // Usage examples: The pattern is very common in C# code.
    // Many frameworks and libraries use it to provide a standard way for traversing their collections.

    // Identification: Iterator is easy to recognize by the navigation methods(such as next, previous and others).
    // Client code that uses iterators might not have direct access to the collection being traversed.

    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Returns the key of the current element
        public abstract int Key();

        // Returns the current element
        public abstract object Current();

        // Move forward to next element
        public abstract bool MoveNext();

        // Rewinds the Iterator to the first element
        public abstract void Reset();
    }

    abstract class IteratorAggregate : IEnumerable
    {
        // Returns an Iterator or another IteratorAggregate
        // for the implementing object.
        public abstract IEnumerator GetEnumerator();
    }

    // Concrete Iterators implement various traversal algorithms.
    // These classes store the current traversal position at all times.
    class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;

        // Stores the current traversal position. An iterator may have a lot of
        // other fields for storing iteration state, especially when it is
        // supposed to work with a particular kind of collection.
        private int _position = -1;

        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                _position = collection.getItems().Count;
            }
        }

        public override object Current()
        {
            return _collection.getItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.getItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.getItems().Count - 1 : 0;
        }
    }

    // Concrete Collections provide one or several methods for retrieving fresh
    // iterator instances, compatible with the collection class.
    class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> getItems()
        {
            return _collection;
        }

        public void AddItem(string item)
        {
            _collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}

//Output

//Straight traversal:
//First
//Second
//Third

//Reverse traversal:
//Third
//Second
//First