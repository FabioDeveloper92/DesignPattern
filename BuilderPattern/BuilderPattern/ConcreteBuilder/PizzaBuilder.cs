using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.ConcreteBuilder
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private string _name;
        private int _size;
        private bool _cheese;
        private bool _sauce;

        public PizzaBuilder() { }

        public IPizzaBuilder SetName(string name)
        {
            _name = name;
            return this;
        }
        public IPizzaBuilder SetSize(int size)
        {
            _size = size;
            return this;
        }
        public IPizzaBuilder SetCheese(bool hasCheese)
        {
            _cheese = hasCheese;
            return this;
        }
        public IPizzaBuilder SetSauce(bool hasSauce)
        {
            _sauce = hasSauce;
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(_name, _size, _cheese, _sauce);
        }
    }
}
