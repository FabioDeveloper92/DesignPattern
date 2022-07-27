
using BuilderPattern.Builder;

namespace BuilderPattern.Director
{
    public class PizzaChef
    {
        private readonly IPizzaBuilder _pizzaBuilder;

        public PizzaChef(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void CookPizzaMargherita()
        {
            var pizzaMargherita = _pizzaBuilder.SetName("Margherita")
                                               .SetSize(12)
                                               .SetSauce(true)
                                               .SetCheese(true)
                                               .Build();

            pizzaMargherita.PrintPizza();
        }
    }
}
