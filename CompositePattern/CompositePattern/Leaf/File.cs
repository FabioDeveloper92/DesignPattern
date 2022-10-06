using CompositePattern.Component;

namespace CompositePattern.Leaf
{
    public class File : IFileSystem
    {
        private readonly string _name;

        public File(string name)
        {
            _name = name;
        }

        public void Add(IFileSystem myFileSystem)
        {
            Console.WriteLine("ERROR: Impossible To Add");
        }

        public void Print()
        {
            Console.WriteLine($"I'm file: {_name}");
        }

        public void Remove(IFileSystem myFileSystem)
        {
            Console.WriteLine("ERROR: Impossible To Remove");
        }
    }
}
