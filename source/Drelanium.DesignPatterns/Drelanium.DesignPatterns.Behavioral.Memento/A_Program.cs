using System;
using System.Linq;
using System.Threading;

namespace Drelanium.DesignPatterns.Behavioral.Memento
{
    // https://refactoring.guru/design-patterns/memento
    // https://refactoring.guru/design-patterns/memento/csharp/example

    // The Originator holds some important state that may change over time. It
    // also defines a method for saving the state inside a memento and another
    // method for restoring the state from it.
    class Originator
    {
        // For the sake of simplicity, the originator's state is stored inside a
        // single variable.
        private string _state;

        public Originator(string state)
        {
            this._state = state;
            Console.WriteLine("Originator: My initial state is: " + state);
        }

        // The Originator's business logic may affect its internal state.
        // Therefore, the client should backup the state before launching
        // methods of the business logic via the save() method.
        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            this._state = this.GenerateRandomString(30);
            Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        // Saves the current state inside a memento.
        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        // Restores the Originator's state from a memento object.
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this._state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_state}");
        }
    }

    // The Memento interface provides a way to retrieve the memento's metadata,
    // such as creation date or name. However, it doesn't expose the
    // Originator's state.
    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Client code.
            Originator originator = new Originator("Super-duper-super-puper-super.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();

            Console.WriteLine();
        }
    }
}

//Output

//Originator: My initial state is: Super-duper-super-puper-super.

//Caretaker: Saving Originator's state...
//Originator: I'm doing something important.
//Originator: and my state has changed to: oGyQIIatlDDWNgYYqJATTmdwnnGZQj

//Caretaker: Saving Originator's state...
//Originator: I'm doing something important.
//Originator: and my state has changed to: jBtMDDWogzzRJbTTmEwOOhZrjjBULe

//Caretaker: Saving Originator's state...
//Originator: I'm doing something important.
//Originator: and my state has changed to: exoHyyRkbuuNEXOhhArKccUmexPPHZ

//Caretaker: Here's the list of mementos:
//12.06.2018 15:52:45 / (Super-dup...)
//12.06.2018 15:52:46 / (oGyQIIatl...)
//12.06.2018 15:52:46 / (jBtMDDWog...)

//Client: Now, let's rollback!

//Caretaker: Restoring state to: 12.06.2018 15:52:46 / (jBtMDDWog...)
//Originator: My state has changed to: jBtMDDWogzzRJbTTmEwOOhZrjjBULe

//Client: Once more!

//Caretaker: Restoring state to: 12.06.2018 15:52:46 / (oGyQIIatl...)
//Originator: My state has changed to: oGyQIIatlDDWNgYYqJATTmdwnnGZQj