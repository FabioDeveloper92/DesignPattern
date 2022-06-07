using CommandPattern.Command;
using CommandPattern.ConcreteCommand;
using CommandPattern.Invoker;
using CommandPattern.Receiver;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IApartment myApartment = new Apartment();

            ICommand turnOnCommand = new TurnOnCommand(myApartment);
            ICommand turnOffCommand = new TurnOffCommand(myApartment);

            Button button = new Button(turnOnCommand, turnOffCommand);

            button.TurnOn();
            button.TurnOff();
        }
    }
}
