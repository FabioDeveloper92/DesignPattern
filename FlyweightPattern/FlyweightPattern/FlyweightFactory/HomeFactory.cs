using FlyweightPattern.Flyweight;

namespace FlyweightPattern.FlyweightFactory
{
    public class HomeFactory
    {
        private List<HomeType> _homeTypes = new List<HomeType>();

        public HomeType GetHomeType(string type, int numberOfFloor)
        {
            var homeType = _homeTypes.FirstOrDefault(x => x.Type.Equals(type) && x.NumberOfFloor == numberOfFloor);
            if (homeType == null)
            {
                Console.WriteLine($"It DOESN'T exist, I create a new HomeType: Type: {type}, NumberOfFloor: {numberOfFloor}");

                homeType = new HomeType(type, numberOfFloor);
                _homeTypes.Add(homeType);
            }
            else
            {
                Console.WriteLine($"It EXIST, I create a new HomeType: Type: {type}, NumberOfFloor: {numberOfFloor}");
            }

            return homeType;
        }
    }
}
