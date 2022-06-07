using CommandPattern.Command;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommand
{
    public class TurnOnCommand : ICommand
    {
        private readonly IApartment _apartment;

        public TurnOnCommand(IApartment apartment)
        {
            _apartment = apartment;
        }

        public void Execute()
        {
            _apartment.TurnOn();
        }
    }
}
