using StatePattern.State;

namespace StatePattern.Context
{
    public class StopWatchContext
    {
        private IStopWatchState _state = null;
        public StopWatchContext(IStopWatchState state)
        {
            TransitionTo(state);
        }
        public void TransitionTo(IStopWatchState state)
        {
            Console.WriteLine($"I'm changing my state to {state.GetType().Name}");
            _state = state;
            _state.SetContext(this);
        }

        public void StartButton()
        {
            _state.StartButton();
        }

        public void PauseButton()
        {
            _state.PauseButton();
        }

        public void StopButton()
        {
           _state.StopButton();
        }

    }
}
