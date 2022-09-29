using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
    public class Observer : IObserver
    {
        private readonly int _id;
        public Observer(int id)
        {
            _id = id;
        }
        public string GetName()
        {
            return $"Observer{_id}";
        }

        public void Update(ISubject subject)
        {
            if (subject is ObserverPattern.Subject.Subject su)
                Console.WriteLine($"{GetName()} said I received notify, the state is {su.State}");
        }
    }
}
