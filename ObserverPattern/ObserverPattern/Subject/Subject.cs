using ObserverPattern.Observer;

namespace ObserverPattern.Subject
{
    public class Subject : ISubject
    {
        public int State { get; set; } = 0;

        private List<IObserver> _observers = new();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers = _observers.Where(o => !o.GetName().Equals(observer.GetName()))
                                   .ToList();
        }

        public void Notify()
        {
            Console.WriteLine("I'm notifying all observers");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void DoSomething()
        {
            State = new Random().Next(0, 100);
            Notify();
        }
    }
}
