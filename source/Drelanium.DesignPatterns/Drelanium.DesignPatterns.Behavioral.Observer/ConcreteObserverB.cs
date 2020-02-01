﻿using System;

namespace Drelanium.DesignPatterns.Behavioral.Observer
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
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