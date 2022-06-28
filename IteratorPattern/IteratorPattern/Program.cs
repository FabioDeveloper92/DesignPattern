using IteratorPattern.Class;
using IteratorPattern.ConcreteAggregate;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySongs = new Song[] {
                new Song() { Title = "Devs Song", Singer = "BoyBand" },
                new Song() { Title = "Happy Song", Singer = "Unknow Singer" },
                new Song() { Title = "Love Song", Singer = "BoyBand" }
            };

            var mySongsCollection = new MySongCollection(mySongs);

            var iterator = mySongsCollection.CreateIterator();

            Console.WriteLine("Start Music");

            while (iterator.HasNext())
            {
                var song = iterator.Next();
                Console.WriteLine($"Now, is playing {song.Title} by {song.Singer}");
            }

            Console.WriteLine("End Music");
        }
    }
}