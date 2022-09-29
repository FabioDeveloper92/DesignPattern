using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
    public interface IObserver
    {
        public string GetName();
        public void Update(ISubject subject);
    }
}
