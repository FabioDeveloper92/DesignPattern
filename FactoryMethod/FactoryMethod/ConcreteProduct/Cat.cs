using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProduct
{
    public class Cat : IPet
    {
        public string Name { get; }
        public Cat(string name)
        {
            Name = name;
        }
        public string SayHello()
        {
            return "Hello!, I'm a Cat. My Name is {Name}";
        }
    }
}
