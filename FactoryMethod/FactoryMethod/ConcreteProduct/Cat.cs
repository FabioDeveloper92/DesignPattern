using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class Cat : IPet
    {
        public string SayHello()
        {
            return "Hello!, I'm a Cat.";
        }
    }
}
