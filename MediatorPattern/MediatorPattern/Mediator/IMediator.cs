using MediatorPattern.Colleague;

namespace MediatorPattern.Mediator
{
    public interface IMediator
    {
        public void Register(IUser user);
        public void Send(IUser from, IUser to, string message);
    }
}
