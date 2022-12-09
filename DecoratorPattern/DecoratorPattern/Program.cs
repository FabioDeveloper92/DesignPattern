using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;

var pizzaMargherita = new PizzaMargherita();
Console.WriteLine($"I wanna a {pizzaMargherita.GetName()}, the price is {pizzaMargherita.GetPrice()} euro");

var pizzaMargheritaWithExtraCheese = new ExtraCheeseDecorator(pizzaMargherita);
Console.WriteLine($"I wanna a {pizzaMargheritaWithExtraCheese.GetName()}, the price is {pizzaMargheritaWithExtraCheese.GetPrice()} euro");

var pizzaMargheritaWithExtraCheeseAndTomato = new ExtraTomatoDecorator(pizzaMargheritaWithExtraCheese);
Console.WriteLine($"I wanna a {pizzaMargheritaWithExtraCheeseAndTomato.GetName()}, the price is {pizzaMargheritaWithExtraCheeseAndTomato.GetPrice()} euro");