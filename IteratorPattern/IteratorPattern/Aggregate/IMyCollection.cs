using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregate
{
    public interface IMyCollection<T>
    {
        public IIterator<T> CreateIterator();
    }
}
