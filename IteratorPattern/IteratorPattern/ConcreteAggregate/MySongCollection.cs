using IteratorPattern.Aggregate;
using IteratorPattern.Class;
using IteratorPattern.ConcreteIterator;
using IteratorPattern.Iterator;

namespace IteratorPattern.ConcreteAggregate
{
    public class MySongCollection : IMyCollection<Song>
    {
        private Song[] _songs;

        public MySongCollection(Song[] songs)
        {
            _songs = songs ?? new Song[0];
        }

        public IIterator<Song> CreateIterator()
        {
            return new SongIterator(_songs);
        }

        public void AddArray(Song[] songs)
        {
            _songs = songs ?? new Song[0];
        }
    }
}
