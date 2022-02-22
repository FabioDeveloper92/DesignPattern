using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class LuckyDenBrand : IBrand
    {
        public string GetName()
        {
            return "LuckyDen";
        }
    }
}
