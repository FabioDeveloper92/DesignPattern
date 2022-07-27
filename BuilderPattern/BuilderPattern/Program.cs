// See https://aka.ms/new-console-template for more information
using BuilderPattern.ConcreteBuilder;
using BuilderPattern.Director;

var pizzaBuilder = new PizzaBuilder();
var pizzaChef = new PizzaChef(pizzaBuilder);

pizzaChef.CookPizzaMargherita();
