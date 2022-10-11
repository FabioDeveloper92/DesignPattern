using StatePattern.State;

namespace StatePattern.ConcreteState
{
    public class StartState : IStopWatchState
    {
        public override void PauseButton()
        {
            Console.WriteLine("I'm in waiting");
            _context.TransitionTo(new WaitState());
        }

        public override void StartButton()
        {
            Console.WriteLine("I'm starting");
        }

        public override void StopButton()
        {
            Console.WriteLine("I'm stopping");
            _context.TransitionTo(new StopState());
        }
    }
}
