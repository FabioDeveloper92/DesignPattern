using StatePattern.State;

namespace StatePattern.ConcreteState
{
    public class WaitState : IStopWatchState
    {
        public override void PauseButton()
        {
            Console.WriteLine("I'm in waiting...");
        }

        public override void StartButton()
        {
            Console.WriteLine("I'm starting...");
            _context.TransitionTo(new StartState());
        }

        public override void StopButton()
        {
            Console.WriteLine("I'm stopping");
            _context.TransitionTo(new StopState());
        }
    }
}
