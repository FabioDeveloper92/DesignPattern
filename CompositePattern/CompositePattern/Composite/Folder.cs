using CompositePattern.Component;

namespace CompositePattern.Composite
{
    public class Folder : IFileSystem
    {
        private readonly string _name;
        private List<IFileSystem> _myFiles;
        public Folder(string name)
        {
            _name = name;
            _myFiles = new List<IFileSystem>();
        }
        public void Add(IFileSystem myFileSystem)
        {
            _myFiles.Add(myFileSystem);
        }

        public void Print()
        {
            Console.WriteLine($"I'm folder: {_name}");
            foreach (var file in _myFiles)
                file.Print();
        }

        public void Remove(IFileSystem myFileSystem)
        {
            _myFiles.Remove(myFileSystem);
        }
    }
}
