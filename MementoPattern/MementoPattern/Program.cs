using MementoPattern.Caretaker;
using MementoPattern.Originator;

var originator = new Originator("Hello");
var caretaker = new Caretaker(originator);

caretaker.Backup();
originator.Write("Hello World");

caretaker.Backup();
originator.Write("Hello World! Today");

caretaker.Backup();
originator.Write("Hello World! Today is a great day");

Console.WriteLine("PRINT HISTORY, before undo");
caretaker.PrintHistory();

caretaker.Undo();

Console.WriteLine();
Console.WriteLine("PRINT HISTORY, after undo");
caretaker.PrintHistory();