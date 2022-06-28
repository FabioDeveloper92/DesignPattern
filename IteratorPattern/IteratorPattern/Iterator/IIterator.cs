namespace IteratorPattern.Iterator
{
    public interface IIterator<T>
    {
        public bool HasNext();
        public T Next();
        public T First();
        public T CurrentItem();
    }
}
