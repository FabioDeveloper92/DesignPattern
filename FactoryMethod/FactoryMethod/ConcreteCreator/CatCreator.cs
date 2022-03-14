using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class CatCreator : PetCreator
    {
        public override IPet Create()
        {
            return new Cat();
        }
    }
}
