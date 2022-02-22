using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class Yellow : IColor
    {
        public string GetColor()
        {
            return "Yellow";
        }
    }
}
