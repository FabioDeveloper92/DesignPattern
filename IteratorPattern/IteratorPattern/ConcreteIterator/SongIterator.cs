using IteratorPattern.Class;
using IteratorPattern.Iterator;

namespace IteratorPattern.ConcreteIterator
{
    public class SongIterator : IIterator<Song>
    {
        private readonly Song[] _songs;
        private int _pos = 0;

        public SongIterator(Song[] songs)
        {
            this._songs = songs;
        }

        public Song CurrentItem()
        {
            return _songs[_pos];
        }

        public Song First()
        {
            return _songs[0];
        }

        public bool HasNext()
        {
            return _pos < _songs.Length && _songs[_pos] != null;
        }

        public Song Next()
        {
            // return next element in the array and increment pos
            var song = _songs[_pos];
            _pos += 1;
            return song;
        }
    }
}
