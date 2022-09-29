
using ObserverPattern.Observer;
using ObserverPattern.Subject;

var subject = new Subject();
var observerA = new Observer(1);
subject.Attach(observerA);

var observerB = new Observer(2);
subject.Attach(observerB);

subject.DoSomething();

var anotherObserver = new AnotherObserver("MagicObserver");
subject.Attach(anotherObserver);
Thread.Sleep(5);
subject.DoSomething();

subject.Detach(observerB);

Thread.Sleep(5);
subject.DoSomething();