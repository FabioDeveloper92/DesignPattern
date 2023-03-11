using FlyweightPattern.Flyweight;

namespace FlyweightPattern.Context
{
    public class Home
    {
        public string Address { get; set; }
        public HomeType HomeType { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"This home is a {HomeType.Type} and it had {HomeType.NumberOfFloor}. Its address is {Address}");
        }
    }
}
