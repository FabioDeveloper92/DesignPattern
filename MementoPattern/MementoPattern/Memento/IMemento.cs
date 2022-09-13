namespace MementoPattern.Memento
{
    public interface IMemento
    {
        public string GetState();
        public DateTime GetCreateDate();
    }
}
