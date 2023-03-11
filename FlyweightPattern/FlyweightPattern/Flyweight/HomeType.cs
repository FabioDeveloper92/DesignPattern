namespace FlyweightPattern.Flyweight
{
    public class HomeType
    {
        public string Type { get; }
        public int NumberOfFloor { get; }

        public HomeType(string type, int numberOfFloor)
        {
            Type = type;
            NumberOfFloor = numberOfFloor;
        }
    }
}
