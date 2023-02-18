namespace SingletonPattern.Singleton
{
    public class GreetingSingleton
    {
        private static GreetingSingleton _greetingSingleton;
        private GreetingSingleton()
        {
        }

        public static GreetingSingleton GetInstance()
        {
            if (_greetingSingleton == null)
            {
                _greetingSingleton = new GreetingSingleton();
                Console.WriteLine("I'm creating a new instance of greeting singleton");
            }
            else
            {
                Console.WriteLine("I don't need a new instance of greeting singleton");
            }

            return _greetingSingleton;
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}"!);
        }
    }
}
