using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class ExtraTomatoDecorator : IExtraIngredientDecorator
    {
        private readonly IPizza _pizza;
        public ExtraTomatoDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetName()
        {
            return _pizza.GetName() + " with extra tomato";
        }

        public double GetPrice()
        {
            return _pizza.GetPrice() + 0.50;
        }
    }
}
