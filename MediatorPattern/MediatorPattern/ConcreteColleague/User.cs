using MediatorPattern.Colleague;

namespace MediatorPattern.ConcreteColleague
{
    public class User : IUser
    {
        public int Id { get; }
        public string Name { get;}

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine($"Message: {message} (received from {from})");
        }
    }
}
