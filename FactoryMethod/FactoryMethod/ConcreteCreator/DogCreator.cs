using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class DogCreator : PetCreator
    {
        public override IPet Create(string name)
        {
            return new Dog(name);
        }
    }
}
