using SingletonPattern.Client;

var myClientDavid = new MyClient("David");
var myClientAndrew = new MyClient("Andrew");

myClientDavid.SayHello();
myClientAndrew.SayHello();

var myClientJenny = new MyClient("Jenny");
myClientJenny.SayHello();
myClientDavid.SayHello();