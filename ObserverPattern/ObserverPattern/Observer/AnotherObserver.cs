using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
    public class AnotherObserver : IObserver
    {
        private readonly string _name;
        public AnotherObserver(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }

        public void Update(ISubject subject)
        {
            if (subject is ObserverPattern.Subject.Subject su)
                Console.WriteLine($"{GetName()} works with state is {su.State}");
        }
    }
}
