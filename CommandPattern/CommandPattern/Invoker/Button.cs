using CommandPattern.Command;

namespace CommandPattern.Invoker
{
    public class Button
    {
        private readonly ICommand _turnOnCommand;
        private readonly ICommand _turnOffCommand;

        public Button(ICommand turnOnCommand, ICommand turnOffCommand)
        {
            _turnOnCommand = turnOnCommand;
            _turnOffCommand = turnOffCommand;
        }

        public void TurnOn()
        {
            _turnOnCommand.Execute();
        }

        public void TurnOff()
        {
            _turnOffCommand.Execute();
        }
    }
}
