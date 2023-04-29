using VisitorPattern.ConcreteElement;
using VisitorPattern.ConcreteVisitor;
using VisitorPattern.ObjectStructure;

var myCart = new Cart("Jack");
var shoppingVisitor = new ShoppingVisitor() { Name = "Maria" };

myCart.AddProduct(new ProductSoldByWeight() { Name = "Apple", Price = 1.51M, Weight = 3.23M });
myCart.AddProduct(new ProductSoldByQuantity() { Name = "Pen", Price = 1.22M, Quantity = 2 });
myCart.AddProduct(new ProductSoldByQuantity() { Name = "Apple", Price = 2.37M, Quantity = 3 });

myCart.PrintTotalPrice(shoppingVisitor);