namespace CompositePattern.Component
{
    public interface IFileSystem
    {
        public void Add(IFileSystem myFileSystem);

        public void Remove(IFileSystem myFileSystem);

        public void Print();
    }
}
