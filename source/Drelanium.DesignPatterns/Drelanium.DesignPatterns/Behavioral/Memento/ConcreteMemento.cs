using System;

namespace Drelanium.DesignPatterns.Behavioral.Memento
{
    // The Concrete Memento contains the infrastructure for storing the
    // Originator's state.
    class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        // The Originator uses this method when restoring its state.
        public string GetState()
        {
            return this._state;
        }

        // The rest of the methods are used by the Caretaker to display
        // metadata.
        public string GetName()
        {
            return $"{this._date} / ({this._state.Substring(0, 9)})...";
        }

        public DateTime GetDate()
        {
            return this._date;
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