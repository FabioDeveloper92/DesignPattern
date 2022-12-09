using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class ExtraCheeseDecorator : IExtraIngredientDecorator
    {
        private readonly IPizza _pizza;
        public ExtraCheeseDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetName()
        {
            return _pizza.GetName() + " with extra cheese";
        }

        public double GetPrice()
        {
            return _pizza.GetPrice() + 1.25;
        }

    }
}
