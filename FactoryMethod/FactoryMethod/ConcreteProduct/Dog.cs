using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class Dog : IPet
    {
        public string SayHello()
        {
            return $"Hello, I'm a Dog";
        }
    }
}
