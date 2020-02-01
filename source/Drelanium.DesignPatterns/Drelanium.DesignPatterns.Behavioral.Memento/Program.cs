using System;
using System.Linq;
using System.Threading;

namespace Drelanium.DesignPatterns.Behavioral.Memento
{
    // https://refactoring.guru/design-patterns/memento
    // https://refactoring.guru/design-patterns/memento/csharp/example

    public class Program
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