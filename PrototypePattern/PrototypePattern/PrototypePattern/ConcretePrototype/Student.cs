using PrototypePattern.Prototype;

namespace PrototypePattern.ConcretePrototype
{
    public class Student : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Addresses { get; set; }
        public OtherInfo OtherInfo { get; set; }

        public IPerson Clone()
        {
            var clone = (Student)MemberwiseClone();

            clone.Addresses = Addresses.ToList();
            clone.OtherInfo = new OtherInfo() { FatherName = OtherInfo.FatherName, MotherName = OtherInfo.MotherName };

            return clone;
        }

        public void DisplayWhoIAm()
        {
            Console.WriteLine($"Hello, I'm {Name}, age {Age}. My addresses are {string.Join(", ", Addresses)}. Other Info: {OtherInfo.Print()}");
        }
    }

    public class OtherInfo
    {
        public string FatherName { get; set; }
        public string MotherName { get; set; }

        public string Print()
        {
            return $"Father is {FatherName}, Mother is {MotherName}";
        }
    }
}
