using SingletonPattern.Singleton;

namespace SingletonPattern.Client
{
    public class MyClient
    {
        private readonly string _name;

        public MyClient(string name)
        {
            _name = name;
        }

        public void SayHello()
        {
            var greetingSingleton = GreetingSingleton.GetInstance();
            greetingSingleton.SayHello(_name);
        }
    }
}
