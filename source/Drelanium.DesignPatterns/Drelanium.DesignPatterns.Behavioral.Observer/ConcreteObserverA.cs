using System;

namespace Drelanium.DesignPatterns.Behavioral.Observer
{
    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}

//Output

//Subject: Attached an observer.
//Subject: Attached an observer.

//Subject: I'm doing something important.
//Subject: My state has just changed to: 2
//Subject: Notifying observers...
//ConcreteObserverA: Reacted to the event.
//ConcreteObserverB: Reacted to the event.

//Subject: I'm doing something important.
//Subject: My state has just changed to: 1
//Subject: Notifying observers...
//ConcreteObserverA: Reacted to the event.
//Subject: Detached an observer.

//Subject: I'm doing something important.
//Subject: My state has just changed to: 5
//Subject: Notifying observers...