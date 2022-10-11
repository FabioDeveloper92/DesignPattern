using StatePattern.ConcreteState;
using StatePattern.Context;

var stopWatchContext = new StopWatchContext(new StartState());
stopWatchContext.StartButton();
stopWatchContext.StopButton();

stopWatchContext.StartButton();
stopWatchContext.PauseButton();
stopWatchContext.PauseButton();
stopWatchContext.StopButton();