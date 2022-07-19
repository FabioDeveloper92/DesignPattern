namespace MediatorPattern.Colleague
{
    public interface IUser
    {
        public int Id { get; }
        public string Name { get; }

        public void Receive(string from, string msg);
    }
}
