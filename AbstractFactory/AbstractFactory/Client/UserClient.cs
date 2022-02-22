using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Client
{

    // The client works with factories and products only through abstract types
    // because you can pass any factory or subclass without you create a bug
    public class UserClient
    {
        IColor _color;
        IBrand _brand;

        public UserClient(IShoe factory)
        {
            _color = factory.GetColor();
            _brand = factory.GetBrand();
        }

        public string GetColor()
        {
            return _color.GetColor();
        }

        public string GetBrandName()
        {
            return _brand.GetName();
        }
    }
}
