namespace Drelanium.DesignPatterns.Behavioral.Observer
{
    // https://refactoring.guru/design-patterns/observer
    // https://refactoring.guru/design-patterns/observer/csharp/example

    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        // Attach an observer to the subject.
        void Attach(IObserver observer);

        // Detach an observer from the subject.
        void Detach(IObserver observer);

        // Notify all observers about an event.
        void Notify();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
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