using System;
using System.Collections.Generic;

namespace Drelanium.DesignPatterns.Behavioral.Memento
{
    // The Caretaker doesn't depend on the Concrete Memento class. Therefore, it
    // doesn't have access to the originator's state, stored inside the memento.
    // It works with all mementos via the base Memento interface.
    class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private Originator _originator = null;

        public Caretaker(Originator originator)
        {
            this._originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            this._mementos.Add(this._originator.Save());
        }

        public void Undo()
        {
            if (this._mementos.Count == 0)
            {
                return;
            }

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

            try
            {
                this._originator.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in this._mementos)
            {
                Console.WriteLine(memento.GetName());
            }
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