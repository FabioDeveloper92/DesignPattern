using StatePattern.Context;

namespace StatePattern.State
{
    public abstract class IStopWatchState
    {
        protected StopWatchContext _context;

        public void SetContext(StopWatchContext context)
        {
            _context = context;
        }
        public abstract void StartButton();
        public abstract void PauseButton();
        public abstract void StopButton();
    }
}
