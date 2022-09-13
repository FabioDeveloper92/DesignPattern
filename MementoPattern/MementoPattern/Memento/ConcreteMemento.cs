namespace MementoPattern.Memento
{
    public class ConcreteMemento : IMemento
    {
        private readonly string _state;
        private readonly DateTime _createDate;

        public ConcreteMemento(string state)
        {
            _state = state;
            _createDate = DateTime.Now;
        }
        public string GetState()
        {
            return _state;
        }
        public DateTime GetCreateDate()
        {
            return _createDate;
        }
    }
}
