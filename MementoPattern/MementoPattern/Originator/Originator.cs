using MementoPattern.Memento;

namespace MementoPattern.Originator
{
    public class Originator
    {
        private string _state;

        public Originator(string state)
        {
            _state = state;
        }

        public void Write(string newState)
        {
            _state = newState;
        }

        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        public void Restore(IMemento memento)
        {
            _state = memento.GetState();
        }
    }
}
