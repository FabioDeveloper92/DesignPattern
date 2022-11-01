using PrototypePattern.ConcretePrototype;

var studentOriginal = new Student()
{
    Name = "David",
    Age = 20,
    Addresses = new List<string>() { "NY, str white 21", "LA, str ocean 8" },
    OtherInfo = new OtherInfo() { FatherName = "Mark", MotherName = "Jenny"}
};

var studentClone = (Student)studentOriginal.Clone();

Console.WriteLine("Original student:");
studentOriginal.DisplayWhoIAm();

Console.WriteLine("Original student:");
studentClone.DisplayWhoIAm();

studentOriginal.Name = "David Junior";
studentOriginal.Age = 19;
studentOriginal.Addresses.RemoveAt(1);
studentOriginal.OtherInfo.FatherName = "Luka";

Console.WriteLine("");
Console.WriteLine("After Update:");
Console.WriteLine("Original student:");
studentOriginal.DisplayWhoIAm();

Console.WriteLine("Original student:");
studentClone.DisplayWhoIAm();