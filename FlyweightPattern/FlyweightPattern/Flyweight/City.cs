using FlyweightPattern.Context;
using FlyweightPattern.FlyweightFactory;

namespace FlyweightPattern.Flyweight
{
    public class City
    {
        private List<Home> _homes = new List<Home>();
        private HomeFactory _homeFactory = new HomeFactory();

        public void BuildHome(string address, string homeType, int numberOfFloor)
        {
            var myHomeType = _homeFactory.GetHomeType(homeType, numberOfFloor);
            var home = new Home() { Address = address, HomeType = myHomeType };
            _homes.Add(home);
        }

        public void PrintHomes()
        {
            Console.WriteLine();
            Console.WriteLine("My City have this homes: ");
            Console.WriteLine();

            foreach (var home in _homes.OrderBy(x => x.HomeType.Type).ToList())
                home.PrintInfo();
        }
    }
}
