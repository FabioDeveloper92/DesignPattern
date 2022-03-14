using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public abstract class PetCreator
    {
        public abstract IPet Create();
    }
}
