using MediatorPattern.Colleague;
using MediatorPattern.Mediator;

namespace MediatorPattern.ConcreteMediator
{
    public class ChatMediator : IMediator
    {
        private Dictionary<int, IUser> _users;
        public ChatMediator()
        {
            _users = new Dictionary<int, IUser>();
        }
        public void Register(IUser user)
        {
            if (!_users.ContainsKey(user.Id))
                _users.Add(user.Id, user);
        }

        public void Send(IUser from, IUser to, string message)
        {
            if (_users.ContainsKey(to.Id))
                _users[to.Id].Receive(from.Name, message);
        }
    }
}
