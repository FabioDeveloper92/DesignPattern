using StatePattern.Context;
using StatePattern.State;

namespace StatePattern.ConcreteState
{
    public class StopState : IStopWatchState
    {

        public override void PauseButton()
        {
            Console.WriteLine("This state isn't allowed");
            
        }

        public override void StartButton()
        {
            Console.WriteLine("I'm starting");
            _context.TransitionTo(new StartState());
        }

        public override void StopButton()
        {
            Console.WriteLine("I'm stopping");
        }
    }
}
