using CommandPattern.Command;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommand
{
    public class TurnOffCommand : ICommand
    {
        private readonly IApartment _apartment;

        public TurnOffCommand(IApartment apartment)
        {
            _apartment = apartment;
        }

        public void Execute()
        {
            _apartment.TurnOff();
        }
    }
}
