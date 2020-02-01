namespace Drelanium.DesignPatterns.Behavioral.Observer
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}