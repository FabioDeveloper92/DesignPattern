using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactory
{
    public class Sneaker : IShoe
    {
        public IBrand GetBrand()
        {
            return new LuckyDenBrand();
        }

        public IColor GetColor()
        {
            return new Red();
        }
    }
}
