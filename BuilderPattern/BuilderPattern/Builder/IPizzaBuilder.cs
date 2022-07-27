using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public interface IPizzaBuilder
    {
        public IPizzaBuilder SetName(string name);
        public IPizzaBuilder SetSize(int size);
        public IPizzaBuilder SetCheese(bool hasCheese);
        public IPizzaBuilder SetSauce(bool hasSauce);
        public Pizza Build();
    }
}
