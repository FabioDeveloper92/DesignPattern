using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class Dog : IPet
    {
        public string Name { get; }
        public Dog(string name)
        {
            Name = name;
        }

        public string SayHello()
        {
            return $"Hello, I'm a Dog. My Name is {Name}";
        }
    }
}
