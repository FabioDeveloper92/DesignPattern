using CompositePattern.Composite;

var noteFile = new CompositePattern.Leaf.File("note.txt");
var cvFile = new CompositePattern.Leaf.File("CV.txt");
var personalFolder = new Folder("Personal");
personalFolder.Add(noteFile);
personalFolder.Add(cvFile);

var customerFile = new CompositePattern.Leaf.File("customer.ods");
var workFolder = new Folder("Work");
var customerFolder = new Folder("Customer");
customerFolder.Add(customerFile);
workFolder.Add(customerFolder);


workFolder.Print();
personalFolder.Print();

Console.WriteLine("Finish first visit");

workFolder.Remove(cvFile);
workFolder.Print();
personalFolder.Print();

Console.WriteLine("Finish second visit");