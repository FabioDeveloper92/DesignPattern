using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactory
{
    // In a concrete factories, we produce a family of items to a single type.
    // Factory guarantees that resulting items are compatible
    public class Boot : IShoe
    {

        public IBrand GetBrand()
        {
            return new AhaBrand();
        }

        public IColor GetColor()
        {
            return new Yellow();
        }
    }
}
