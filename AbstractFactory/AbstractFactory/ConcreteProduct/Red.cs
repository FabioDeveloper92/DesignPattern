using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class Red : IColor
    {
        public string GetColor()
        {
            return "Red";
        }
    }
}
