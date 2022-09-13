
using MementoPattern.Memento;

namespace MementoPattern.Caretaker
{
    public class Caretaker
    {
        private readonly Stack<IMemento> _mementos;

        private readonly Originator.Originator _originator;

        public Caretaker(Originator.Originator originator)
        {
            _originator = originator;
            _mementos = new Stack<IMemento>();
        }

        public void Backup()
        {
            _mementos.Push(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
                return;

            var memento = _mementos.Pop();
            _originator.Restore(memento);
        }

        public void PrintHistory()
        {
            foreach (var memento in _mementos.ToArray())
                Console.WriteLine(memento.GetState());
        }
    }
}
