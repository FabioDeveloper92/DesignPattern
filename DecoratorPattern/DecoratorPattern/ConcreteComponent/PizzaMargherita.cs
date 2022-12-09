using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    public class PizzaMargherita : IPizza
    {
        private readonly string _name;
        public PizzaMargherita()
        {
            _name = "Pizza Margherita";
        }

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return 5.0;
        }
    }
}
