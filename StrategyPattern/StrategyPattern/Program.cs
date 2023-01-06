using StrategyPattern.ConcreteStrategy;
using StrategyPattern.Context;

var myPenInUk = new ProductContext("Pen", 1.2M, new UkVATStrategy());
var sellPriceUK = myPenInUk.GetSellPrice();

Console.WriteLine($"My product sell price in UK is: {sellPriceUK}");

var myPenInItaly = new ProductContext("Pen", 1.2M, new ItalyVATStrategy());
var sellPriceItaly = myPenInItaly.GetSellPrice();

Console.WriteLine($"My product sell price in UK is: {sellPriceItaly}");